using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePatterns
{
    class Player
    {
        public int Ammo { get; set; }
        public string Picture { get; private set; }
        static Player _player;

        private Player(string path)
        {
            Ammo = 15;
            Picture = "C:\\Users\\Admin\\Figures\\bird.png";
        }

        static public Player GetPlayer(string path)
        {
            if (_player == null)
                _player = new Player(path);
            return _player;
        }
    }
}
