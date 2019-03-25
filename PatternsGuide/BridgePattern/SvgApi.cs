using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BridgePattern
{
    class SvgApi : DrawApi
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine(@"<line xl=""{0}"" y1=""{1}"" x2=""{2}"" y2=""{3}"" />", x1, y1, x2, y2);
        }
    }
}
