using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace PatternsGuide.PrototypePattern
{
   class CourseImage : Cloneable
    {
        
        public Color  Color { get; set; }

        public void Initialize()
        {
            Color = Color.AliceBlue;
        }
        public override Cloneable Clone()
        {
            CourseImage clone = (CourseImage)this.MemberwiseClone();
            clone.Color = (Color)Color.Aquamarine;
            return clone as Cloneable;
        }
    }
}
