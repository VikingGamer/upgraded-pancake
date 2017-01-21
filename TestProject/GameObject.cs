using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject
{
    class GameObject
    {
        Vector2 position;
        bool isVisible;
        public GameObject(Vector2 position, bool isVisible)
        {
            this.position = position;
            this.isVisible = isVisible;
        }

    }
}
