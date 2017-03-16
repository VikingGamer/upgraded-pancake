using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestProject.Entities
{
    public class Particle : GameObject
    {
        /// <summary>
        /// Particle lifespan length in sec.
        /// </summary>
        ushort lifespan;

        public Particle(Texture2D texture, Rectangle hitBox, bool isVisible, Vector2 velocity) : base(texture, hitBox, isVisible, 1f, velocity)
        {
            lifespan = 50;
            this.velocity = velocity;
        }
        
        public ushort Lifespan { get { return lifespan; } }

    }
}
