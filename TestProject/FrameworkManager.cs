using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace TestProject
{
    class FrameworkManager
    {
        public enum ScreenStates
        {
            Splash,
            Menu,
            Game,
            Pause,
            Highscore
        }

        public static Vector2 resolution { private set; get; }

        /// <summary>
        /// Construct the framework.
        /// </summary>
        /// <param name="res"></param>
        public FrameworkManager(Vector2 res)
        {
            resolution = new Vector2(res.X, res.Y);
        }

        /// <summary>
        /// Refresh and apply framework settings.
        /// </summary>
        /// <param name="graphics"></param>
        public void Refresh(GraphicsDeviceManager graphics)
        {
            graphics.PreferredBackBufferWidth = (int)resolution.X;
            graphics.PreferredBackBufferHeight = (int)resolution.Y;
            graphics.ApplyChanges();
        }

    }
}
