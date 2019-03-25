using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.PrototypePattern
{
    class CourseImageMaker
    {
        public CourseImage CreateImage(CourseImage prototype, string imagePath)
        {
            CourseImage image = (CourseImage)prototype.Clone();
            return image;
        }
    }
}
