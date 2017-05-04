using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using TestProject.Entities;

namespace TestProject.GameScreens
{
    public class Menu : Screen
    {
        Texture2D Background;
        Texture2D TexButton;
        UIElement Button1;

        double m_time;
        float transparancy = 0.2f;

        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            TexButton = Content.Load<Texture2D>("Button");
            Background = Content.Load<Texture2D>("Space");
            Button1 = new UIElement(new Rectangle(Point.Zero, new Point(32, 32)), true, TexButton);
        }
        public override void Update(GameTime gameTime)
        {
            m_time += Variables.DeltaTime(gameTime);
            if (m_time >= 0.2)
            {
                transparancy += 0.15f;
                m_time = 0;
            }

            if (transparancy >= 1.0f)
                transparancy = 0.0f;

            Button1.Update(gameTime);
            if (Button1.ButtonState == UIElement.Buttonstate.Clicked)
            {
                Core.currentScreen = ScreenStates.Game;
                GameObject.GameObjects.RemoveAt(0);
            }
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Background, Vector2.Zero, Color.White * transparancy);
            Button1.Draw(spritebatch);
        }
    }
}
