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

        const int maxJumpHeight = 300;
        public bool Jumped = false;

        public Player(Texture2D texture, Rectangle hitBox, bool isVisible) : base(texture, hitBox, isVisible, 1f, new Vector2(0,0))
        {
            Health = 20;
            Armor = 0;

            this.texture = texture;
            this.hitBox = hitBox;
            this.isVisible = isVisible;
        }

        bool isAlive() { return Health <= 0 ? false : true; } 
        
        public void Walk(int velocity, int axis) {
            if (axis > 0)
            {
                hitBox.X += velocity;
            }
            else
            {
                hitBox.Y -= velocity;
            }
        }

        public void Jump(int velocity, GameTime time)
        {
            if(hitBox.Location.Y <= maxJumpHeight && Jumped == false)
            {
                hitBox.Y -= velocity;
                Jumped = true;
            }
            else
            {
                Jumped = false;
            }
        }
        
        #region Variable properties
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Armor { get { return armor; } set { armor = value; } }
        #endregion
    }
}
