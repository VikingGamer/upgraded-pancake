using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TestProject.GameScreens
{
    public class Menu : Screen
    {
        SpriteFont räkna;
        int hej;
        public override void LoadContent()
        {
             räkna = Core.cntManager.Load<SpriteFont>("Main");
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            int hej = 6;
            hej++;
        }

        public override void Draw(SpriteBatch spritebatch)
        {

            spritebatch.DrawString(räkna, hej.ToString(), Vector2.One, Color.White);
        }
    }
}
