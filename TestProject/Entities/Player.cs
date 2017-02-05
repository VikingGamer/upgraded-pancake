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
        string name;
        int health;
        int armor;
        Vector2 size;
        Point position;

        public Player(Point position, bool isVisible) : base(position, isVisible)
        {
            Debug.WriteLine(Health.ToString());
            Health = 20;
            Armor = 0;
            Position = position;
        }

        bool isAlive() { return Health <= 0 ? false : true; } 

        #region Variable properties
        string Name { get { return name; } set { name = value; } }
        int Health { get { return health; } set { health = value; } }
        int Armor { get { return armor; } set { armor = value; } }
        Vector2 Size { get { return size; } set { size = value; } }
        Point Position { get { return position; } set { position = value; } }
        #endregion
    }
}
