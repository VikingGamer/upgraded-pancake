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
        public Vector2 resolution;
        public enum ScreenStates
        {
            Splash,
            Menu,
            Game,
            Pause,
            Highscore
        }

        /// <summary>
        /// Construct the framework.
        /// </summary>
        /// <param name="res"></param>
        public FrameworkManager(float x, float y)
        {
            resolution.X = x;
            resolution.Y = y;
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
        
        public Vector2 Resolution { get { return resolution; } set { resolution = value; } }
    }
}
