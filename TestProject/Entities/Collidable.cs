using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestProject.Entities
{
    abstract class Collidable : GameObject
    {
        public static List<Collidable> Collidables = new List<Collidable>();

        public Collidable(Texture2D texture, Rectangle hitBox, bool isVisible) : base(texture, hitBox, isVisible)
        {
            this.texture = texture;
            this.hitBox = hitBox;
        }

        public override void Destroy(GameObject gObj)
        {
            base.Destroy(gObj);
            Collidables.Remove(this);
        }

        public abstract void OnCollition(Collidable c);
    }
}
