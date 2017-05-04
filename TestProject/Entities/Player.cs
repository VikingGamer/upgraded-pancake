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
        public enum States { GROUNDED, IN_AIR }
        public enum Animation { IDLE, WALK }

        Player_utilities.Controls input;

        const int maxJumpHeight = 300;

        public States state;
        public Animation animation;

        Texture2D IDLE;

        public Player(Texture2D texture, Rectangle hitBox, bool isVisible, Texture2D idle) : base(texture, hitBox, isVisible, 1f, new Vector2(0, 0))
        {
            Health = 20;
            Armor = 0;

            state = States.GROUNDED;
            animation = Animation.IDLE;

            this.texture = texture;
            this.hitBox = hitBox;
            this.isVisible = isVisible;
            this.input = new Player_utilities.Controls(this);

            this.IDLE = idle;
        }

        /// <summary>
        /// Check whether player is alive or not
        /// </summary>
        /// <returns> Alive: true/false </returns>
        bool isAlive() { return Health <= 0 ? false : true; }

        /// <summary>
        /// Force player to walk
        /// </summary>
        /// <param name="velocity"> Walking speed </param>
        /// <param name="axis"> Walking direction </param>
        public void Walk(int velocity, Variables.World_Axis direction)
        {
            hitBox.X += velocity * (int)direction;
        }

        /// <summary>
        /// Force player to jump
        /// </summary>
        /// <param name="velocity"> Jumping force </param>
        public void Jump(int velocity)
        {
            if (hitBox.Y <= maxJumpHeight && state == States.GROUNDED)
            {
                    hitBox.Y -= velocity;
            }
        }

        #region Variable properties
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Armor { get { return armor; } set { armor = value; } }
        public Player_utilities.Controls Input { get { return input; } }

        public Texture2D Idle { get { return IDLE; } }
        #endregion
    }
}
