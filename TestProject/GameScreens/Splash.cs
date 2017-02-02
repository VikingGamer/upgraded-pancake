using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TestProject.GameScreens
{
    public class Splash : Screen
    {
        const int m_duration = 7;
        double time;
        Vector2 center;
        SpriteFont font;

        
        public override void LoadContent(ContentManager Content)
        {
            font = Content.Load<SpriteFont>("Code");
        }
        public override void Initialize(FrameworkManager framework)
        {
            center = new Vector2((framework.Resolution.X / 2) - (font.Texture.Width / 2), (framework.Resolution.Y / 2) - (font.Texture.Height / 2));
        }
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

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "nanogear", center, Color.White);
        }
    }
}