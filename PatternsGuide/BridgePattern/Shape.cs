using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BridgePattern
{
    abstract class Shape
    {
        protected DrawApi _implementor;

        public Shape(DrawApi implementor)
        {
            _implementor = implementor;
        }
        public abstract void Draw();
    }
}
