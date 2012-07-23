using System;

namespace GOL
{
    public class Location
    {
        private readonly string _key;

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }


        public Location(Location adjustment, int x, int y) : this(adjustment.X + x, adjustment.Y + y)
        {
        }


        public Location(int x, int y)
        {
            X = x;
            Y = y;
            _key = String.Format("{0},{1}", X, Y);
        }

        public Location() : this(0, 0)
        {
        }

        public override bool Equals(object obj)
        {
            return ((Location)obj)._key == _key;
        }

        public override string ToString()
        {
            return _key;
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }
    }
}