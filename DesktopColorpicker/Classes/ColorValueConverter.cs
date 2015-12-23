using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DesktopColorpicker.Classes
{
    class ColorValueConverter
    {
        public static string RGBToHex(Color c, Boolean isHTML=true)
        {
            int R = c.R;
            int G = c.G;
            int B = c.B;
            return (isHTML ? "#" : "") + R.ToString("x2") + G.ToString("x2") + B.ToString("x2");
        }

        public static string toRGBA(Color c)
        {
            int R = c.R;
            int G = c.G;
            int B = c.B;
            return "rgba(" + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ", " + 1 + ")";
        }

        public static string toRGB(Color c)
        {
            int R = c.R;
            int G = c.G;
            int B = c.B;
            return "rgb(" + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
        }

        public static string RGBToHSL(Color rgb, Boolean includeAlpha=false, Boolean returnAsArray=false)
        {
            double h = 0, s = 0, l = 0;
            double r, g, b;
            // Convert the RGB values to the range 0-1,
            // this can be done by dividing the value by 255 
            // for 8-bit color depth
            r = rgb.R / 255.0;
            g = rgb.G / 255.0;
            b = rgb.B / 255.0;
            // Round
            r = Math.Round(r, 2);
            g = Math.Round(g, 2);
            b = Math.Round(b, 2);

            double[] rgbArray = { r, g, b };
            double max, min;
            max = rgbArray.Max();
            min = rgbArray.Min();
            
            // Calculate Luminace
            l = (max + min) / 2.0;

            // check for All-Gray
            // That is, if all rgb values are equal
            // bool isRGBGray = (r == g && g == b) ? true : false;

            // check for Saturation
            // if max and min are same, no saturation
            // If isNotSaturated, then Hue is 0deg;
            if (max == min)
            {
                h = s = 0; // achromatic
            }
            else
            {
                // there is saturation here.
                // Now we know that there is Saturation,
                // we need to check the level of the Luminance
                // in order to select the correct formula.
                var d = max - min;
                s = l > 0.5 ? d / (2.0 - max - min) : d / (max + min);               

                // The Hue formula is depending on what RGB color channel is the max value.
                // The three different formulas are:
                // If Red is max, then Hue = (G-B)/(max-min)
                // If Green is max, then Hue = 2.0 + (B-R)/(max-min)
                // If Blue is max, then Hue = 4.0 + (R-G)/(max-min)
                if (max == r)
                {
                    h = (g - b) / d;
                }
                else if (max == g)
                {
                    h = 2.0 + (b - r) / d;
                }
                else
                {
                    h = 4.0 + (r - g) / d;
                }

                // The Hue value you get needs to be multiplied by 60
                // to convert it to degrees on the color circle
                // If Hue becomes negative you need to add 360 to,
                // because a circle has 360 degrees.
                h *= 60;
                h += (h < 0) ? 360 : 0;

            }            
            
            // Convert to Percentage
            s *= 100;
            l *= 100;

            if (returnAsArray)
            {
                string[] hslarray = { Math.Round(h).ToString(), Math.Round(s).ToString() + "%", Math.Round(l).ToString() + "%" };
                return String.Join("|", hslarray);
            }

            return "hsl" + (includeAlpha ? "a" : "") + "(" + Math.Round(h) + ", " + Math.Round(s) + "%, " + Math.Round(l) + "%" + (includeAlpha ? ", " + 1 : "") + ")";

        }

    }
}
