using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
        Texture2D texture;

        public Player(Point position, bool isVisible) : base(position, isVisible)
        {
            Health = 20;
            Armor = 0;
            Position = position;
        }

        bool isAlive() { return Health <= 0 ? false : true; } 

        public void Walk(int velocity) { position.X += velocity; }

        #region Variable properties
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Armor { get { return armor; } set { armor = value; } }

        public Vector2 Size { get { return size; } set { size = value; } }
        public Point Position { get { return position; } set { position = value; } }
        public Texture2D Texture { get { return texture; } set { texture = value; } }
        #endregion
    }
}
