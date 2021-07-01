using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace OscilloscopeTest
{
    public partial class testProg : Form
    {
        // GLOBAL VARIABLES
        Boolean drawing;
        Boolean playing;
        Boolean live;
        ASCII ascii;
        List<Point> points;
        BackgroundWorker wave;
        SoundPlayer playWave;
        int limit;

        // INITIALIZE STUFF
        public testProg()
        {
            InitializeComponent();

            //variables
            drawing = false;
            playing = false;
            live = false;
            limit = 2000;
            points = new List<Point>();

            // ASCII point values
            ascii = new ASCII();

            // background worker for running the calculations and playing the wave
            wave = new BackgroundWorker();
            wave.DoWork += new DoWorkEventHandler(wave_DoWork);
            wave.WorkerSupportsCancellation = true;
        }

        // FORM LOAD
        private void testProg_Load(object sender, EventArgs e)
        {
        }


        //
        // --Main Buttons--
        //

        // PLAY WAVE
        private void btnCust_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                // first checks if the thread is busy
                if (nudFreq.Value > 0 && !wave.IsBusy)
                {

                    Boolean error = stringInput(txtString.Text);

                    // runs thread if no error was found
                    if (!error)
                    {
                        btnCust.Text = "Stop Wave";
                        playing = true;
                        lblPlaying.Visible = true;
                        btnSwitch.Visible = true;
                        wave.RunWorkerAsync();
                        if (radString.Checked) txtString.Select();
                    }
                }
            }

            // stops thread if playing is currently true
            else
            {
                lblPlaying.Visible = false;
                btnSwitch.Visible = false;
                playWave.Stop();
                btnCust.Text = "Play Wave";
                playing = false;
            }
        }

        // CLEAR
        private void button1_Click(object sender, EventArgs e)
        {
            clearCanvas();
        }

        // UPDATE
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (!stringInput(txtString.Text))
            {
                updateDisplay();
            }
        }


        //
        // --Wave Settings--
        //

        // FREQUENCY TRACKBAR
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nudFreq.Value = trkFrequency.Value;
            if (points.Count != 0) clearCanvas();
        }

        // FREQUENCY NUMERIC UP/DOWN
        private void nudFreq_ValueChanged(object sender, EventArgs e)
        {
            // tests that the user types valid input
            if (!nudFreq.Text.Equals(""))
            {
                if (int.Parse(nudFreq.Text) > 0 && int.Parse(nudFreq.Text) < 2001)
                {
                    trkFrequency.Value = int.Parse(nudFreq.Text);
                    if (points.Count != 0) clearCanvas();
                }
            }
            else nudFreq.Text.Equals("1");
        }


        //
        // --Radio Buttons--
        //

        // SINE
        private void radSine_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radSine);
        }

        // SQUARE
        private void radSquare_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radSquare);
        }

        // TRIANGLE
        private void radTriangle_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radTriangle);
        }

        // SAWTOOTH
        private void radSawtooth_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radSawtooth);
        }

        // FREE 1D
        private void radFree1D_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radFree1D);
        }

        // FREE 2D
        private void radFree2D_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radFree2D);
        }

        // STRING
        private void radString_CheckedChanged(object sender, EventArgs e)
        {
            updateText(radString);
            //btnSwitch.Visible = false;        
        }


        //
        // --Simulated Preview Screen + Interaction--
        //

        // DRAW (DRAG) (only if free draw is selected)
        private void panDrawY_MouseMove(object sender, MouseEventArgs e)
        {
            // sets drawing to false if the cursor is out of bounds
            if (e.X < 0 || e.Y < 0 || e.X > panDrawY.Width || e.Y > panDrawY.Height)
            {
                drawing = false;
            }
                // otherwise, shows where the cursor is currently
            else
            {
                lblCustY.Text = "X: " + (e.X - 225) + "; Y: " + (450 - e.Y - 225);
            }

            // if the mouse is down on the canvas, then...
            if (drawing == true)
            {
                // draws the point at the cursor's location
                drawPoint(e.X, e.Y, true);

            }
        }

        // DRAW (MOUSE DOWN)
        private void panDrawY_MouseDown(object sender, MouseEventArgs e)
        {
            // only allows the user to draw if one of the drawing options is selected
            if (radFree1D.Checked == true || radFree2D.Checked == true)
            {
                drawing = true;
                drawPoint(e.X, e.Y, false);
            }
        }

        // DISABLE DRAW (MOUSE UP)
        private void panDrawY_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }


        //
        // --KeyDown and Text Events--
        //

        // CHARACTER TEXTBOX
        private void txtChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnCust_Click(sender, e);
            }
        }

        // TEXT SIZE
        private void nudSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnCust_Click(sender, e);
            }
        }

        // FREQUENCY TRACKBAR
        private void trkFrequency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnCust_Click(sender, e);
            }
        }

        // FREQUENCY
        private void nudFreq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnCust_Click(sender, e);
            }
        }

        // STRING CONTENTS
        private void txtString_TextChanged(object sender, EventArgs e)
        {
            lblStringErr.Text = "";
        }


        //
        // --Other methods--
        //

        // GENERATES WAVE BASED ON PARAMETERS
        // takes in three parameters: freq, dur, type and size
        // freq is the frequency, dur is the duration, and type is the type of wave
        // size is used to determine the text size for ASCII input
        // frequency is NOT used for custom waves!
        public void genWave(int freq, String type, int size = 1)
        {
            // calculates the angular frequency
            double angular = 2 * Math.PI * freq / (double)44100;

            // setting amplitude to a static value...
            int amp = 15000;

            // calculates number of samples we will be storing in the wave
            int samples = 441 * 100 / 10;

            // calculates size of the wave file based on the number of samples
            int bytes = samples * 4;

            // a counter for the number of samples written
            int sampWritten = 0;

            Boolean exception = false;

            using (MemoryStream MS = new MemoryStream(44 + bytes))
            {
                using (BinaryWriter BW = new BinaryWriter(MS))
                {
                    // WRITING THE WAVE HEADER

                    //  specifies the "RIFF" part
                    BW.Write(Encoding.ASCII.GetBytes("RIFF"), 0, 4);

                    // "chunk" size
                    BW.Write(BitConverter.GetBytes(36 + bytes));

                    // specifies the format, which is "WAVE"
                    BW.Write(Encoding.ASCII.GetBytes("WAVE"), 0, 4);

                    // "Sub-chunk"
                    BW.Write(Encoding.ASCII.GetBytes("fmt "), 0, 4);

                    // "Sub-chunk" size
                    BW.Write(BitConverter.GetBytes(16), 0, 4);

                    // Format; does not indicate compression
                    BW.Write(0X20001);

                    // Number of channels (TWO)
                    BW.Write(44100);

                    // Sample rate
                    BW.Write(176400);

                    // Bit rate
                    BW.Write(0X100004);

                    // Block Align
                    BW.Write(0X61746164);

                    // Bits/sample
                    BW.Write(bytes);

                    for (int T = 0; T < samples; T++)
                    {
                        short Sample = 5;

                        // sine wave
                        if (type.Equals("sin")) Sample = System.Convert.ToInt16(amp * Math.Sin(angular * T) + 1000);

                        // square wave
                        else if (type.Equals("square")) Sample = System.Convert.ToInt16(amp * Math.Sign(Math.Sin(2 * Math.PI * angular * T)));

                        // triangle wave
                        else if (type.Equals("tri")) Sample = System.Convert.ToInt16(Math.Abs(((-1 * (2 * amp)) / Math.PI) * Math.Atan(1 / Math.Tan((T * Math.PI) / angular))));

                        // sawtooth wave
                        else if (type.Equals("saw")) Sample = System.Convert.ToInt16(((-1 * (2 * amp)) / Math.PI) * Math.Atan(1 / Math.Tan((T * Math.PI) / angular)));

                        // creates a custom 1-D or 2-D wave
                        else
                        {

                            // loops the array inside the wave
                            int i = 0;
                            while (sampWritten < samples)
                            {
                                // only goes through the list if there is at least one point
                                if (points.Count > 0)
                                {
                                    try
                                    {
                                        try
                                        {
                                            // if 1-D mode is selected, writes Y data on both channels
                                            Sample = System.Convert.ToInt16(size * 100 * points[i].Y);
                                            BW.Write(Sample);
                                            if (type.Equals("Y")) BW.Write(Sample);

                                            // if 2-D mode is selected, writes X data on other channel
                                            else
                                            {
                                                Sample = System.Convert.ToInt16(size * 100 * points[i].X);
                                                BW.Write(Sample);
                                            }

                                            if (i >= (points.Count - 1)) i = 0;
                                            else i++;
                                        }
                                        catch (ArgumentOutOfRangeException e)
                                        {
                                            exception = true;
                                        }
                                    }
                                    catch (OverflowException e)
                                    {
                                        exception = true;
                                    }
                                    if (exception)
                                    {
                                        BW.Write(0);
                                        BW.Write(0);
                                    }
                                }

                                // fills in empty sample space if needed
                                else
                                {
                                    BW.Write(0);
                                    BW.Write(0);
                                }

                                sampWritten++;
                                T++;
                            }
                        }

                        // only uses these if the option is not custom
                        if (!type.Equals("Y") && !type.Equals("XY") && !type.Equals("text"))
                        {
                            
                            // writes data on both channels
                            BW.Write(System.Convert.ToInt16(Sample));
                            BW.Write(System.Convert.ToInt16(Sample));

                            sampWritten++;

                            //draws lines between the points
                            if (T < 486)
                            {
                                points.Add(new Point(T, ((Sample / 88) + 225)));
                                if (T > 0)
                                {
                                    drawLine(points[T - 1], points[T], true, false);
                                }
                            }
                        }
                    }

                    // end-of-the-day clean-up stuff
                    BW.Flush();
                    MS.Seek(0, SeekOrigin.Begin);
                    
                    // plays the shiny, new wave file
                    using (playWave = new SoundPlayer(MS))
                    {
                        playWave.PlayLooping();
                    }
                }
            }

        }
        
        // CLEAR CANVAS
        // clears the preview, and resets all the label objects
        public void clearCanvas()
        {
            points.Clear();
            lblRecord.Text = "Points: " + points.Count + "/" + limit;
            panDrawY.Refresh();
            lblCustY.Text = "X: 0; Y: 0";
        }

        // DRAW POINT
        // takes in two parameters: X and Y locations of the cursor
        // draws the point at the cursor's location, then adds that to a list
        public void drawPoint(int x, int y, Boolean drag)
        {
            // adds the X and Y values to a list of points (with an offset)
            if (points.Count < limit)
            {
                points.Add(new Point((x - 243), (349 - y - 175)));

                lblRecord.Text = "Points: " + points.Count + "/" + limit;

                // draws a single dot only if you are not dragging
                Graphics g = panDrawY.CreateGraphics();
                Pen p = new Pen(new SolidBrush(Color.LawnGreen), 2);
                Rectangle r = new Rectangle(x, y, 1, 1);

                // actually draws the dot
                g.DrawEllipse(p, r);

                // be gone!
                g.Dispose();
                p.Dispose();

                //draws a line between the points if necessary
                if (points.Count > 1)
                {
                    drawLine(points[points.Count - 2], points[points.Count - 1], drag, true);
                }
            }

        }

        // DRAW LINE
        // draws a line between two points so you don't just see a bunch of dots on the preview
        public void drawLine(Point a, Point b, Boolean drag, Boolean custom)
        {

            //only draws lines between points if the mouse is being held down and didn't just click
            if (drag == true)
            {
                // draws a series of dots that you're drawing on the oscilloscope
                Graphics g = panDrawY.CreateGraphics();
                Pen p = new Pen(new SolidBrush(Color.LawnGreen), 2);

                //only positions the line if the user is drawing
                if (custom == true)
                {
                    // positioning offset
                    Point newPointA = new Point(a.X + 244, -1 * (a.Y - 175));
                    Point newPointB = new Point(b.X + 244, -1 * (b.Y - 175));

                    // actually draws the dots
                    g.DrawLine(p, newPointA, newPointB);
                }
                else g.DrawLine(p, a, b);

                // be gone!
                g.Dispose();
                p.Dispose();
            }
        }

        // UPDATE TEXT
        // takes in the radio button that's being clicked and a Boolean
        // Boolean tells it whether it's a "free-drawn" wave or not
        // sets fields equal to that button's color property
        public void updateText(RadioButton r)
        {
            if (r.Checked)
            {
                btnCust.ForeColor = r.ForeColor;
                lblStringErr.Text = "";
                clearCanvas();
                if (r.Equals(radFree1D) || r.Equals(radFree2D)) lblRecord.Visible = true;
                else lblRecord.Visible = false;
            }
        }

        // UPDATE DISPLAY
        public void updateDisplay()
        {
            if (wave.IsBusy)
            {
                playWave.Stop();
                playing = false;
            }
            wave.CancelAsync();
            if(radString.Checked) stringInput(txtString.Text);
            try {
                playing = true;
                wave.RunWorkerAsync();
            }
            catch (InvalidOperationException e)
            {
                wave.CancelAsync();
            }
        }

        // STRING INPUT MONITOR
        public Boolean stringInput(String s)
        {
            Boolean error = false;

            if (radString.Checked)
            {
                error = true;
                if (!txtString.Text.Equals(""))
                {
                    // clears error text and canvas before beginning
                    lblStringErr.Text = "";
                    clearCanvas();

                    // converts the string to points and then stores them
                    points.AddRange(ascii.getString(txtString.Text));

                    // checks if there are any points out of bounds
                    if (Math.Abs(ascii.getRange((int)nudSize.Value)) > 32767) lblStringErr.Text = "Error: String too long, or font size too large";
                    else error = false;
                }
                else
                {
                    points.Clear();
                    points.Add(new Point(0, 0));
                    error = false;
                }
            }

            return error;
        }

        //
        // --Background Worker Tasks--
        //

        // CALCULATIONS
        void wave_DoWork(object sender, DoWorkEventArgs e)
        {

            // if the user didn't enter a frequency, automatically sets it to 1
            if (nudFreq.Text.Equals("")) nudFreq.Text = "1";

            // SINE
            if (radSine.Checked) genWave((UInt16)nudFreq.Value, "sin");

            // SQUARE
            else if (radSquare.Checked) genWave((UInt16)nudFreq.Value, "square");

            // TRIANGLE
            else if (radTriangle.Checked) genWave((UInt16)nudFreq.Value, "tri");

            // SAWTOOTH
            else if (radSawtooth.Checked) genWave((UInt16)nudFreq.Value, "saw");

            // FREE DRAW 1D
            else if (radFree1D.Checked) genWave((UInt16)nudFreq.Value, "Y");

            // FREE DRAW 2D
            else if (radFree2D.Checked) genWave((UInt16)nudFreq.Value, "XY");

            // STRING
            else if (radString.Checked) genWave((UInt16)0, "text", (int)nudSize.Value);
        }
    }
}
