using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    class Enemy : ICloneable
    {
        public string Path { get; set; }
        public int Speed { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Enemy(string path, int speed, int height, int x, int y)
        {
            Path = path;
            Speed = speed;
            Height = height;
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return new Enemy(Path, Speed, Height, X, Y);
        }
    }
}
