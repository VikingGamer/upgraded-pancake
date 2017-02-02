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
    public class GameObject
    {
        Point position;
        bool isVisible;
        public GameObject(Point position, bool isVisible)
        {
            this.position = position;
            this.isVisible = isVisible;
        }

        #region Properties
        public bool IsVisible { get; set; }
        #endregion

    }
}
