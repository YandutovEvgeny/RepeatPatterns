using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsePatterns
{
    class EnemyPicture
    {
        public List<Enemy> Enemies { get; set; }
        public List<PictureBox> PictureBoxes { get; set; }

        public EnemyPicture()
        {
            PictureBoxes = new List<PictureBox>();
            Enemies = new List<Enemy>();
        }
    }
}
