using System;

namespace Teaching.Common
{
    //Dont Comment like this BUT: This is a simple Class.
    public class Turtle
    {

        private readonly string _name;

        /// <summary>
        /// Bad Practice to Comment this kind of thing: But this is a constructor. We use it to INSTANTIATE an object. 
        /// Learning MOMENT - https://stackoverflow.com/questions/32290879/meanings-of-declaring-instantiating-initializing-and-assigning-an-object
        /// </summary>
        public Turtle()
        {
            _name = "Mr. Turtle";
            Age = 4;
            Weight = 15.2;
        }

        public Turtle(string turtleName)
        {
            _name = turtleName;
            Age = 17;
        }

        public string Name { get { return _name; } }

        public int Age { get; set; }

        private double Weight { get; set; }


    }
}
