using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace HW4Project.Models
{
    public class ColorInterpolation
    {
        [Required]
        public string FirstColor {get; set;}
        [Required]
        public string SecondColor {get; set;}
        [Required]
        public int NumberOfColors {get; set;}
        public IList<string> ListOfColors {get; set;} = new List<string>();
        
        // From Greg's answer: https://stackoverflow.com/questions/359612/how-to-change-rgb-color-to-hsv/1626175
        // And Wikipedia: https://en.wikipedia.org/wiki/HSL_and_HSV
        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);

            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0:
                    return Color.FromArgb(255, v, t, p);

                case 1:
                    return Color.FromArgb(255, q, v, p);

                case 2:
                    return Color.FromArgb(255, p, v, t);

                case 3:
                    return Color.FromArgb(255, p, q, v);

                case 4:
                    return Color.FromArgb(255, t, p, v);

                default:
                    return Color.FromArgb(255, v, p, q);
            }
        }
        public static IList<string> CreateListOfColors(Color firstColor, Color secondColor, int steps)
        {
            double hueStart;
            double saturationStart;
            double valueStart;

            double hueEnd;
            double saturationEnd;
            double valueEnd;

            ColorToHSV(firstColor, out hueStart, out saturationStart, out valueStart);
            ColorToHSV(secondColor, out hueEnd, out saturationEnd, out valueEnd);

            double hueStep = (hueEnd - hueStart) / steps;
            double saturationStep = (saturationEnd - saturationStart) / steps;
            double valueStep = (valueEnd - valueStart) / steps;

            IList<string> listOfColors = new List<string>();
            
            for (int i = 0; i < steps; i++)
            {
                listOfColors.Add(ColorTranslator.ToHtml(ColorFromHSV(hueStart, saturationStart, valueStart)));
                hueStart += hueStep;
                saturationStart += saturationStep;
                valueStart += valueStep;
            }

            return listOfColors;
        }
    }
}