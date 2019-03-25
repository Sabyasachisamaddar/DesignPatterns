using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.PrototypePattern
{
    class PrototypePattern
    {
        public void ImplementPattern()
        {
            CourseImage prototype = new CourseImage();
            prototype.Initialize();

            CourseImageMaker maker = new CourseImageMaker();
            CourseImage blueprint = maker.CreateImage(prototype, "blueprint1");
            Console.WriteLine("Blueprint printed");

            CourseImage thread = maker.CreateImage(prototype, "thread");
            Console.WriteLine("Thread printed");
        }
    }
}
