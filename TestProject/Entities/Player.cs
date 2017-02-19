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

        Texture2D texture;
        Rectangle hitBox;
        bool isVisible;

        public Player(Texture2D texture, Rectangle hitBox, bool isVisible) : base(texture, hitBox, isVisible)
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
        
        #region Variable properties
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Armor { get { return armor; } set { armor = value; } }

        public Texture2D Texture { get { return texture; } set { texture = value; } }
        public Rectangle HitBox { get { return hitBox; } set { hitBox = value; } }
        public bool IsVisible { get { return isVisible; } set { isVisible = value; } }
        #endregion
    }
}
