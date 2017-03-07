using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject.Entities
{
    public class GameObject
    {
        #region Variables
        protected Texture2D texture;
        protected Rectangle hitBox;
        protected bool isVisible;

        protected float mass;
        protected Vector2 velocity;
        #endregion

        public GameObject(Texture2D texture, Rectangle hitBox, bool isVisible)
        {
            this.texture = texture;
            this.hitBox = hitBox;
            this.isVisible = isVisible;
        }

        public GameObject(Texture2D texture, Rectangle hitBox, bool isVisible, float mass, Vector2 velocity)
        {
            this.texture = texture;
            this.hitBox = hitBox;
            this.isVisible = isVisible;
            this.mass = mass;
            this.velocity = velocity;
        }

        public GameObject(Rectangle hitBox, bool isVisible)
        {
            this.hitBox = hitBox;
            this.isVisible = isVisible;
        }

        #region Properties
        public Texture2D Texture { get { return texture; } set { texture = value; } }
        public Rectangle HitBox { get { return hitBox; } set { hitBox = value; } }
        public bool IsVisible { get { return isVisible; } set { isVisible = value; } }

        public float Mass { get { return mass; } set { mass = value; } }
        public Vector2 Velocity { get { return velocity; } set { velocity = value; } }

        public float VelocityX { get { return velocity.X; } set { velocity.X = value; } }
        public float VelocityY { get { return velocity.Y; } set { velocity.Y = value; } }

        public float HitBoxLocationX { get { return hitBox.X; } set { hitBox.X = (int)value; } }
        public float HitBoxLocationY { get { return hitBox.Y; } set { hitBox.Y = (int)value; } }
        #endregion
    }
}
