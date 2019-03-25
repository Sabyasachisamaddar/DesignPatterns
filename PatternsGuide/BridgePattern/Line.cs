using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BridgePattern
{
    class Line : Shape
    {
        public Line(DrawApi implentor) : base(implentor) { }
        public override void Draw()
        {
            _implementor.DrawLine(0, 0, 100, 100);
        }
    }
}
