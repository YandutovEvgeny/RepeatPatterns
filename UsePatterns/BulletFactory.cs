using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    class BulletFactory
    {
        public IBullet GetBullet(int num, int x, int y)
        {
            switch(num)
            {
                case 1: return new RedBullet(x, y); 
                case 2: return new BlueBullet(x, y);
                default: return null;
            }
        }
    }
}
