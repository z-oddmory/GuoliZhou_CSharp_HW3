using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes7
{
    public class Color
    {
        private int red;
        public int Red 
        { 
            get 
            {
                return red;
            }
            set
            {  
                red = value; 
            } 
        }
        private int green;
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
        private int blue;
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }
        private int alpha;
        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }

        public int CalGrey()
        {
            int grey = (red + green + blue)/3;
            return grey;
        }

        //Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
        public int GetRedColor()
        {
            return red; 
        }
        public int ChangeRedColor(int a)
        {
            red = a;
            return red;
        }
        public int GetGreenColor()
        {
            return green;
        }
        public int ChangeGreenColor(int b)
        {
            green = b;
            return green;
        }
        public int GetBlueColor()
        {
            return blue;
        }
        public int ChangeBlueColor(int c)
        {
            blue = c;
            return blue;
        }
        public int GetAlphaColor()
        {
            return alpha;
        }
        public int ChangeAlphaColor(int d)
        {
            alpha = d;
            return blue;
        }


        public Color(int r, int g, int b, int al)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = al;
        }

        public Color(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
            alpha = 255;
        }



    }

    
}
