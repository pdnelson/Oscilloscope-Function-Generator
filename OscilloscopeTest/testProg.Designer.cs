namespace OscilloscopeTest
{
    partial class testProg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testProg));
            this.trkFrequency = new System.Windows.Forms.TrackBar();
            this.lblFreq = new System.Windows.Forms.Label();
            this.panDrawY = new System.Windows.Forms.Panel();
            this.lblCustY = new System.Windows.Forms.Label();
            this.btnCust = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblStringErr = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.radString = new System.Windows.Forms.RadioButton();
            this.radFree2D = new System.Windows.Forms.RadioButton();
            this.radFree1D = new System.Windows.Forms.RadioButton();
            this.radSawtooth = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.lblGo = new System.Windows.Forms.Label();
            this.radSine = new System.Windows.Forms.RadioButton();
            this.nudFreq = new System.Windows.Forms.NumericUpDown();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.chkLive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).BeginInit();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // trkFrequency
            // 
            this.trkFrequency.Location = new System.Drawing.Point(8, 282);
            this.trkFrequency.Maximum = 3000;
            this.trkFrequency.Minimum = 1;
            this.trkFrequency.Name = "trkFrequency";
            this.trkFrequency.Size = new System.Drawing.Size(438, 42);
            this.trkFrequency.TabIndex = 4;
            this.trkFrequency.Value = 100;
            this.trkFrequency.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trkFrequency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trkFrequency_KeyDown);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.ForeColor = System.Drawing.Color.White;
            this.lblFreq.Location = new System.Drawing.Point(8, 264);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(184, 13);
            this.lblFreq.TabIndex = 6;
            this.lblFreq.Text = "Frequency:                                     Hz";
            // 
            // panDrawY
            // 
            this.panDrawY.BackColor = System.Drawing.Color.Transparent;
            this.panDrawY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panDrawY.BackgroundImage")));
            this.panDrawY.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panDrawY.Location = new System.Drawing.Point(454, 24);
            this.panDrawY.Name = "panDrawY";
            this.panDrawY.Size = new System.Drawing.Size(450, 450);
            this.panDrawY.TabIndex = 13;
            this.panDrawY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDrawY_MouseDown);
            this.panDrawY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panDrawY_MouseMove);
            this.panDrawY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panDrawY_MouseUp);
            // 
            // lblCustY
            // 
            this.lblCustY.AutoSize = true;
            this.lblCustY.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustY.ForeColor = System.Drawing.Color.White;
            this.lblCustY.Location = new System.Drawing.Point(452, 8);
            this.lblCustY.Name = "lblCustY";
            this.lblCustY.Size = new System.Drawing.Size(75, 11);
            this.lblCustY.TabIndex = 16;
            this.lblCustY.Text = "X: 0; Y: 0";
            // 
            // btnCust
            // 
            this.btnCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCust.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnCust.Location = new System.Drawing.Point(6, 26);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(126, 23);
            this.btnCust.TabIndex = 1;
            this.btnCust.Text = "&Play Wave";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(782, 6);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(103, 11);
            this.lblRecord.TabIndex = 18;
            this.lblRecord.Text = "Points: 0/2000";
            this.lblRecord.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(6, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear Preview";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.chkLive);
            this.grpType.Controls.Add(this.nudSize);
            this.grpType.Controls.Add(this.lblStringErr);
            this.grpType.Controls.Add(this.txtString);
            this.grpType.Controls.Add(this.radString);
            this.grpType.Controls.Add(this.radFree2D);
            this.grpType.Controls.Add(this.radFree1D);
            this.grpType.Controls.Add(this.radSawtooth);
            this.grpType.Controls.Add(this.radTriangle);
            this.grpType.Controls.Add(this.radSquare);
            this.grpType.Controls.Add(this.lblGo);
            this.grpType.Controls.Add(this.radSine);
            this.grpType.ForeColor = System.Drawing.Color.White;
            this.grpType.Location = new System.Drawing.Point(136, 20);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(312, 232);
            this.grpType.TabIndex = 6;
            this.grpType.TabStop = false;
            this.grpType.Text = "Wave Manipulation";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(64, 206);
            this.nudSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(38, 20);
            this.nudSize.TabIndex = 9;
            this.nudSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            this.nudSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudSize_KeyDown);
            // 
            // lblStringErr
            // 
            this.lblStringErr.AutoSize = true;
            this.lblStringErr.ForeColor = System.Drawing.Color.Red;
            this.lblStringErr.Location = new System.Drawing.Point(104, 210);
            this.lblStringErr.Name = "lblStringErr";
            this.lblStringErr.Size = new System.Drawing.Size(0, 13);
            this.lblStringErr.TabIndex = 33;
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(64, 138);
            this.txtString.MaxLength = 100;
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(194, 64);
            this.txtString.TabIndex = 8;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // radString
            // 
            this.radString.AutoSize = true;
            this.radString.ForeColor = System.Drawing.Color.DarkViolet;
            this.radString.Location = new System.Drawing.Point(12, 134);
            this.radString.Name = "radString";
            this.radString.Size = new System.Drawing.Size(55, 17);
            this.radString.TabIndex = 7;
            this.radString.TabStop = true;
            this.radString.Text = "St&ring:";
            this.radString.UseVisualStyleBackColor = true;
            this.radString.CheckedChanged += new System.EventHandler(this.radString_CheckedChanged);
            // 
            // radFree2D
            // 
            this.radFree2D.AutoSize = true;
            this.radFree2D.ForeColor = System.Drawing.Color.Magenta;
            this.radFree2D.Location = new System.Drawing.Point(12, 116);
            this.radFree2D.Name = "radFree2D";
            this.radFree2D.Size = new System.Drawing.Size(138, 17);
            this.radFree2D.TabIndex = 5;
            this.radFree2D.Text = "&X-Y Mode Free Drawing";
            this.radFree2D.UseVisualStyleBackColor = true;
            this.radFree2D.CheckedChanged += new System.EventHandler(this.radFree2D_CheckedChanged);
            // 
            // radFree1D
            // 
            this.radFree1D.AutoSize = true;
            this.radFree1D.ForeColor = System.Drawing.Color.Yellow;
            this.radFree1D.Location = new System.Drawing.Point(12, 96);
            this.radFree1D.Name = "radFree1D";
            this.radFree1D.Size = new System.Drawing.Size(120, 17);
            this.radFree1D.TabIndex = 4;
            this.radFree1D.Text = "&Y-Axis Free Drawing";
            this.radFree1D.UseVisualStyleBackColor = true;
            this.radFree1D.CheckedChanged += new System.EventHandler(this.radFree1D_CheckedChanged);
            // 
            // radSawtooth
            // 
            this.radSawtooth.AutoSize = true;
            this.radSawtooth.ForeColor = System.Drawing.Color.Aqua;
            this.radSawtooth.Location = new System.Drawing.Point(12, 76);
            this.radSawtooth.Name = "radSawtooth";
            this.radSawtooth.Size = new System.Drawing.Size(102, 17);
            this.radSawtooth.TabIndex = 3;
            this.radSawtooth.Text = "S&awtooth Wave";
            this.radSawtooth.UseVisualStyleBackColor = true;
            this.radSawtooth.CheckedChanged += new System.EventHandler(this.radSawtooth_CheckedChanged);
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.ForeColor = System.Drawing.Color.Orange;
            this.radTriangle.Location = new System.Drawing.Point(12, 56);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(95, 17);
            this.radTriangle.TabIndex = 2;
            this.radTriangle.Text = "&Triangle Wave";
            this.radTriangle.UseVisualStyleBackColor = true;
            this.radTriangle.CheckedChanged += new System.EventHandler(this.radTriangle_CheckedChanged);
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.ForeColor = System.Drawing.Color.Red;
            this.radSquare.Location = new System.Drawing.Point(12, 36);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(91, 17);
            this.radSquare.TabIndex = 1;
            this.radSquare.Text = "S&quare Wave";
            this.radSquare.UseVisualStyleBackColor = true;
            this.radSquare.CheckedChanged += new System.EventHandler(this.radSquare_CheckedChanged);
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.ForeColor = System.Drawing.Color.White;
            this.lblGo.Location = new System.Drawing.Point(10, 210);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(52, 13);
            this.lblGo.TabIndex = 28;
            this.lblGo.Text = "Text size:";
            // 
            // radSine
            // 
            this.radSine.AutoSize = true;
            this.radSine.Checked = true;
            this.radSine.ForeColor = System.Drawing.Color.LawnGreen;
            this.radSine.Location = new System.Drawing.Point(12, 16);
            this.radSine.Name = "radSine";
            this.radSine.Size = new System.Drawing.Size(78, 17);
            this.radSine.TabIndex = 0;
            this.radSine.TabStop = true;
            this.radSine.Text = "&Sine Wave";
            this.radSine.UseVisualStyleBackColor = true;
            this.radSine.CheckedChanged += new System.EventHandler(this.radSine_CheckedChanged);
            // 
            // nudFreq
            // 
            this.nudFreq.Location = new System.Drawing.Point(68, 262);
            this.nudFreq.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFreq.Name = "nudFreq";
            this.nudFreq.Size = new System.Drawing.Size(98, 20);
            this.nudFreq.TabIndex = 3;
            this.nudFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudFreq.ValueChanged += new System.EventHandler(this.nudFreq_ValueChanged);
            this.nudFreq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudFreq_KeyDown);
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.ForeColor = System.Drawing.Color.White;
            this.lblPlaying.Location = new System.Drawing.Point(32, 94);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(75, 13);
            this.lblPlaying.TabIndex = 19;
            this.lblPlaying.Text = "Wave playing!";
            this.lblPlaying.Visible = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(6, 118);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(126, 23);
            this.btnSwitch.TabIndex = 20;
            this.btnSwitch.Text = "&Update Wave";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Visible = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // chkLive
            // 
            this.chkLive.AutoSize = true;
            this.chkLive.Enabled = false;
            this.chkLive.Location = new System.Drawing.Point(150, 118);
            this.chkLive.Name = "chkLive";
            this.chkLive.Size = new System.Drawing.Size(84, 17);
            this.chkLive.TabIndex = 21;
            this.chkLive.Text = "Live Update";
            this.chkLive.UseVisualStyleBackColor = true;
            this.chkLive.Visible = false;
            this.chkLive.CheckedChanged += new System.EventHandler(this.chkLive_CheckedChanged);
            // 
            // testProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(927, 495);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.nudFreq);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnCust);
            this.Controls.Add(this.lblCustY);
            this.Controls.Add(this.panDrawY);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.trkFrequency);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "testProg";
            this.Text = "Oscilloscope Function Generator";
            this.Load += new System.EventHandler(this.testProg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).EndInit();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkFrequency;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Panel panDrawY;
        private System.Windows.Forms.Label lblCustY;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radFree2D;
        private System.Windows.Forms.RadioButton radFree1D;
        private System.Windows.Forms.RadioButton radSawtooth;
        private System.Windows.Forms.RadioButton radTriangle;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.RadioButton radSine;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.RadioButton radString;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.NumericUpDown nudFreq;
        private System.Windows.Forms.Label lblStringErr;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.CheckBox chkLive;
    }
}

