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
        Texture2D texture;
        Rectangle hitBox;
        bool isVisible;

        public GameObject(Texture2D texture, Rectangle hitBox, bool isVisible)
        {
            this.texture = texture;
            this.hitBox = hitBox;
            this.isVisible = isVisible;
        }

        public GameObject(Rectangle hitBox, bool isVisible)
        {
            this.hitBox = hitBox;
            this.isVisible = isVisible;
        }
    }
}
