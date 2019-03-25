using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BridgePattern
{
    class Square : Shape
    {
        public Square (DrawApi implentor) : base(implentor) { }
        public override void Draw()
        {
            _implementor.DrawLine(0, 0, 100, 0);
            _implementor.DrawLine(100, 0, 100, 0);
            _implementor.DrawLine(100, 100, 0, 100);
            _implementor.DrawLine(0, 100, 0, 0);

        }
    }
}
