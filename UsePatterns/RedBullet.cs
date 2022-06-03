using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    class RedBullet : IBullet
    {
        public RedBullet(int x, int y) :base(x,y,8,Color.Red)
        {

        }
    }
}
