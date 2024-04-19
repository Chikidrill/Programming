using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;
        private int _y;

        public int coord_X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(coord_X));
                _x = value;
            }

        }

        public int coord_Y
        {
            get
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(coord_Y));
                _y = value;
            }
        }
        public Point2D(int x, int y)
        {
            coord_X = x;
            coord_Y = y;
        }
    }
}
