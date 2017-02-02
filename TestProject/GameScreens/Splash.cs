using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestProject.GameScreens
{
    public class Splash : Screen
    {
        const int m_duration = 5;
        double time;

        public override void Update(GameTime gameTime)
        {
            #region Time handling
            time += gameTime.ElapsedGameTime.TotalSeconds;
            if (time >= m_duration)
            {
                Core.currentScreen = ScreenStates.Menu;
            }
            #endregion


        }

        public override void Draw(SpriteBatch spritebatch)
        {
            //base.Draw(spritebatch);
        }
    }
}