using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BridgePattern
{
    class BridgePattern
    {
        public void ImplementPattern()
        {
            Console.WriteLine("Line drawn using OpenGL commands:");
            Shape line = new Line(new OpenGLApi());
            line.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle drawn using SVG commands:");
            Shape rectangle = new Rectangle(new SvgApi());
            rectangle.Draw();
            Console.WriteLine();
        }
    }
}
