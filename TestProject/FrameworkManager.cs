using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace TestProject
{

    /// <summary>
    /// Available screen states.
    /// Every screen class inherit from the general Screen class.
    /// </summary>
    public enum ScreenStates
    {
        Splash,
        Menu,
        Game,
        Pause,
        Highscore
    }

    public class FrameworkManager
    {
        Vector2 resolution;

        /// <summary>
        /// Construct the framework.
        /// </summary>
        /// <param name="res"></param>
        public FrameworkManager(float x, float y)
        {
            Resolution = new Vector2(x, y);
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
        
        #region Properties
        public Vector2 Resolution { get { return resolution; } set { resolution = value; } }             ///> Window resolution
        #endregion
    }
}
