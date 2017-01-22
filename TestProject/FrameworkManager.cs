﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace TestProject
{
    class FrameworkManager
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
            graphics.PreferredBackBufferWidth = (int)Resolution.X;
            graphics.PreferredBackBufferHeight = (int)Resolution.Y;
            graphics.ApplyChanges();
            
        }
        
        #region Properties
        public Vector2 Resolution { get; set; }             ///> Window resolution
        public static ContentManager Content { get; set; }  ///> Asset provider
        #endregion
    }
}
