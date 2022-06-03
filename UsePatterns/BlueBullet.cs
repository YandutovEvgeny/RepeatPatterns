using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    class BlueBullet : IBullet
    {
        public BlueBullet(int x, int y) :base(x, y, 4, Color.Blue)
        {

        }
    }
}
