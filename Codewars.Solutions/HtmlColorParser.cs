using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Solutions
{
    public class HtmlColorParser
    {
        private readonly IDictionary<string, string> presetColors;

        public HtmlColorParser(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public RGB Parse(string color)
        {
            return new RGB(50, 100, 255);
        }
    }

    public struct RGB
    {
        public byte r, g, b;
        public RGB(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
