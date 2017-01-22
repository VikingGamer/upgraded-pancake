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

        /// <summary>
        /// Construct the framework.
        /// </summary>
        /// <param name="res"></param>
        public FrameworkManager(float x, float y)
        {
            x = Resolution.X;
            y = Resolution.Y;
        }

        /// <summary>
        /// Refresh and apply framework settings.
        /// </summary>
        /// <param name="graphics"></param>
        public void Refresh(GraphicsDeviceManager graphics)
        {
            graphics.PreferredBackBufferWidth = (int)Resolution.X;
            graphics.PreferredBackBufferHeight = (int)Resolution.Y;
            graphics.ApplyChanges();
        }

        #region Properties
        public Vector2 Resolution { get; set; }
        #endregion
    }
}
