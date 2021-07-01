using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OscilloscopeTest
{
    // This class contains badly-drawn characters that are returned based on ASCII input
    // Don't worry, I will think of a way to only load them as needed, not all at once
    // This is mostly a "proof of concept," and will be intended to operate on its own thread
    class ASCII
    {
        private List<Point>[] ascii;
        private int range;

        // INITIALIZATION
        public ASCII()
        {
            // initialize all the point lists
            ascii = new List<Point>[128];

            for (int i = 0; i < 128; i++)
            {
                ascii[i] = new List<Point>();
            }

            // fill in all the points with their initial values
            setZero();
            setOne();
            setTwo();
            setThree();
            setFour();
            setFive();
            setSix();
            setSeven();
            setEight();
            setNine();
            setColon();
            setP();
        }

        // SET NUMBERS

        // 0
        private void setZero()
        {
            for (int i = -10; i < 0; i++) ascii[48].Add(new Point(i, 0));
            for (int i = 0; i < 20; i++) ascii[48].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[48].Add(new Point(i, 20));
            for (int i = 20; i > 0; i--) ascii[48].Add(new Point(-10, i));
            for (int i = -20; i < 2; i+= 2) ascii[48].Add(new Point((i/2), i + 20));
            trace(ascii[48]);
        }

        // 1
        private void setOne()
        {
            for (int i = -10; i < 0; i++) ascii[49].Add(new Point(i, 0));
            for (int i = 0; i > -4; i -= 2) ascii[49].Add(new Point(i, 0));
            for (int i = 0; i < 20; i++) ascii[49].Add(new Point(-4, i));
            for (int i = -4; i > -8; i--) ascii[49].Add(new Point(i, 20));
            trace(ascii[49]);
        }

        // 2
        private void setTwo()
        {
            for (int i = 0; i > -10; i--) ascii[50].Add(new Point(i, 0));
            for (int i = 0; i < 10; i++) ascii[50].Add(new Point(-10, i));
            for (int i = -10; i < 0; i++) ascii[50].Add(new Point(i, 10));
            for (int i = 10; i < 20; i++) ascii[50].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[50].Add(new Point(i, 20));
            trace(ascii[50]);
        }

        // 3
        private void setThree()
        {
            for (int i = -10; i < 0; i++) ascii[51].Add(new Point(i, 0));
            for (int i = 0; i < 10; i++) ascii[51].Add(new Point(0, i));
            for (int i = 0; i > -8; i--) ascii[51].Add(new Point(i, 10));
            for (int i = -8; i < 0; i += 2) ascii[51].Add(new Point(i, 10));
            for (int i = 10; i < 20; i++) ascii[51].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[51].Add(new Point(i, 20));
            trace(ascii[51]);
        }

        // 4
        private void setFour()
        {
            ascii[52].Add(new Point(0, 0));
            ascii[52].Add(new Point(0, 0));
            ascii[52].Add(new Point(0, 0));
            ascii[52].Add(new Point(0, 0));
            for (int i = 0; i < 20; i++) ascii[52].Add(new Point(0, i));
            for (int i = 20; i > 10; i -= 2) ascii[52].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[52].Add(new Point(i, 10));
            for (int i = 10; i < 20; i++) ascii[52].Add(new Point(-10, i));
            trace(ascii[52]);
        }

        // 5
        private void setFive()
        {
            for (int i = -10; i < 0; i++) ascii[53].Add(new Point(i, 0));
            for (int i = 0; i < 10; i++) ascii[53].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[53].Add(new Point(i, 10));
            for (int i = 10; i < 20; i++) ascii[53].Add(new Point(-10, i));
            for (int i = -10; i < 0; i++) ascii[53].Add(new Point(i, 20));
            trace(ascii[53]);
        }

        // 6
        private void setSix()
        {
            for (int i = -10; i < 0; i++) ascii[54].Add(new Point(i, 0));
            for (int i = 0; i < 10; i++) ascii[54].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[54].Add(new Point(i, 10));
            for (int i = 10; i > 0; i--) ascii[54].Add(new Point(-10, i));
            for (int i = 10; i < 20; i++) ascii[54].Add(new Point(-10, i));
            for (int i = -10; i < 0; i++) ascii[54].Add(new Point(i, 20));
            trace(ascii[54]);
        }

        // 7
        private void setSeven()
        {
            ascii[55].Add(new Point(0, 0));
            ascii[55].Add(new Point(0, 0));
            ascii[55].Add(new Point(0, 0));
            ascii[55].Add(new Point(0, 0));
            for (int i = 0; i < 20; i++) ascii[55].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[55].Add(new Point(i, 20));
            trace(ascii[55]);
        }
        
        // 8
        private void setEight()
        {
            for (int i = -10; i < 0; i++) ascii[56].Add(new Point(i, 0));
            for (int i = 0; i < 20; i++) ascii[56].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[56].Add(new Point(i, 20));
            for (int i = 20; i > 10; i--) ascii[56].Add(new Point(-10, i));
            for (int i = -10; i < 0; i++) ascii[56].Add(new Point(i, 10));
            for (int i = 0; i > -10; i--) ascii[56].Add(new Point(i, 10));
            for (int i = 10; i > 0; i--) ascii[56].Add(new Point(-10, i));
            trace(ascii[56]);
        }

        // 9
        private void setNine()
        {
            for (int i = -10; i < 0; i++) ascii[57].Add(new Point(i, 0));
            for (int i = 0; i < 20; i++) ascii[57].Add(new Point(0, i));
            for (int i = 0; i > -10; i--) ascii[57].Add(new Point(i, 20));
            for (int i = 20; i > 10; i--) ascii[57].Add(new Point(-10, i));
            for (int i = -10; i < 0; i++) ascii[57].Add(new Point(i, 10));
            trace(ascii[57]);
        }

        // :
        private void setColon()
        {
            for (int i = 0; i < 20; i++) ascii[58].Add(new Point((int)(2 * Math.Cos(i) - 5), (int)(2 * Math.Sin(i)) + 3));
            for (int i = 0; i < 20; i++) ascii[58].Add(new Point((int)(2 * Math.Cos(i) - 5), (int)(2 * Math.Sin(i)) + 17));
            trace(ascii[58]);
        }

        // P
        private void setP()
        {
            ascii[80].Add(new Point(0, 0));
            ascii[80].Add(new Point(0, 0));

            ascii[80].Add(new Point(0, 2));

            ascii[80].Add(new Point(0, 4));
            ascii[80].Add(new Point(0, 4));

            ascii[80].Add(new Point(0, 6));

            ascii[80].Add(new Point(0, 8));
            ascii[80].Add(new Point(0, 8));

            ascii[80].Add(new Point(3, 8));
            ascii[80].Add(new Point(3, 8));

            ascii[80].Add(new Point(4, 7));
            ascii[80].Add(new Point(4, 7));

            ascii[80].Add(new Point(4, 5));
            ascii[80].Add(new Point(4, 5));

            ascii[80].Add(new Point(3, 4));
            ascii[80].Add(new Point(3, 4));

            ascii[80].Add(new Point(0, 4));
            trace(ascii[80]);
        }

        // TRACE
        // traces the character back to origin
        private void trace(List<Point> p)
        {
            for (int i = p.Count - 1; i > -1; i--)
            {
                p.Add(new Point(p[i].X, p[i].Y));
            }
        }

        // RETURN CHAR
        // returns points that correspond to an ASCII character
        public List<Point> getSingleChar(Char c)
        {
            return ascii[(int)c];
        }

        // RETURN STRING
        // returns points that correspond to a string of ASCII characters
        public List<Point> getString(String s)
        {
            List<Point> sPoints = new List<Point>();
            List<Point> nextChar = new List<Point>();
            range = 0;

            // X and Y offset values for character placement
            int xMove = 0;
            int yMove = 0;
            foreach (char c in s)
            {
                if((int)c != 13) {
                    // loads the next character into nextChar
                    nextChar.AddRange(getSingleChar(c));

                    for (int i = 0; i < (nextChar.Count); i++)
                    {
                        // pushes all the coordinates of nextChar according to the offset
                        nextChar[i] = new Point((nextChar[i].X + xMove), (nextChar[i].Y + yMove));

                        // determines what the largest coordinate is
                        if (Math.Abs(nextChar[i].X) > range) range = nextChar[i].X;
                        if (Math.Abs(nextChar[i].Y) > range) range = nextChar[i].Y;
                    }

                    // adds nextChar to the output list if it is within the range
                    sPoints.AddRange(nextChar);
                    nextChar.Clear();

                    // add to offset to position next character
                    xMove += 12;
                }

                // if the character is enter, updates X and Y offset
                else
                {
                    xMove = -12;
                    yMove -= 24;
                }
            }

            return sPoints;
        }

        // RETURN COORDINATE RANGE
        // returns the largest X or Y coordinate
        public int getRange(int size)
        {
            return range * size * 100;
        }
    }
}
