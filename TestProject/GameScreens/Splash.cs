using System;
using System.Collections.Generic;
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
        double m_time;
        Vector2 CenterVec2;
        SpriteFont Font;

        
        public override void LoadContent(ContentManager Content)
        {
            Font = Content.Load<SpriteFont>("Code");
        }
        public override void Initialize(FrameworkManager framework)
        {
            CenterVec2 = new Vector2(((framework.Resolution.X / 2) - (Font.MeasureString("nanogear").X / 2)), ((framework.Resolution.Y / 2) - (Font.MeasureString("nanogear").Y / 2)));
        }
        public override void Update(GameTime gameTime)
        {
            #region Time handling
            m_time += gameTime.ElapsedGameTime.TotalSeconds;
            if (m_time >= m_duration)
            {
                Core.currentScreen = ScreenStates.Menu;
            }
            #endregion
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font, "nanogear", CenterVec2, Color.White);
        }
    }
}