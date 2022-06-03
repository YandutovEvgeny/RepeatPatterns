using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    abstract class IBullet
    {
        public int Speed { get; protected set; }
        public Color BulletColor { get; protected set; }
        public int X, Y; 
        public IBullet(int x, int y, int speed, Color color)
        {
            X = x;
            Y = y;
            Speed = speed;
            BulletColor = color;
        }
    }
}
