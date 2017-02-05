using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

using System.Diagnostics;

namespace TestProject.Entities
{
    public class Player : GameObject
    {

        public Player(Point position, bool isVisible) : base(position, isVisible)
        {
            Debug.WriteLine(Health.ToString());
            Health = 20;
            Armor = 0;
            Position = position;
        }

        bool isAlive() { return Health <= 0 ? true : false; } 

        #region Properties
        int Health { get; set; }
        int Armor { get; set; }
        Vector2 Size { get; } = new Vector2(32, 32);
        Point Position { get; set; }
        #endregion
    }
}
