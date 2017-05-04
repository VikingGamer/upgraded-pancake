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
        Texture2D TexButton_a;
        UIElement Button1;

        double m_time;
        float transparency = 0;
        float ntransparency = 1.0f;

        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            TexButton = Content.Load<Texture2D>("Button_1");
            TexButton_a = Content.Load<Texture2D>("Button_2");
            Background = Content.Load<Texture2D>("Space");
            Button1 = new UIElement(new Rectangle(Point.Zero, new Point(32, 32)), true, TexButton, TexButton_a);
        }
        public override void Update(GameTime gameTime)
        {
            if (Button1.ButtonState == UIElement.Buttonstate.Hover)
                Button1.Animation_start = true;

            m_time += Variables.DeltaTime(gameTime);

            if (m_time >= 0.15 && Button1.Animation_start)
            {
                transparency += 0.2f;
                ntransparency -= 0.2f;
                m_time = 0;

                if (transparency >= 1.0f)
                {
                    Button1.Animation_done = true;
                    if (Button1.ButtonState == UIElement.Buttonstate.Unhover)
                    {
                        Button1.Animation_start = false;
                        transparency = 0f;
                        ntransparency = 1.0f;
                    }
                }
            }

            Button1.Update(gameTime);
            if (Button1.ButtonState == UIElement.Buttonstate.Clicked)
            {
                Core.currentScreen = ScreenStates.Game;
                GameObject.GameObjects.RemoveAt(0);
            }
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Background, Vector2.Zero, Color.White);
      

            if (Button1.Animation_start)
            {
                spritebatch.Draw(Button1.Texture, Button1.HitBox.Location.ToVector2(), Color.White * ntransparency);
                spritebatch.Draw(TexButton_a, Button1.HitBox.Location.ToVector2(), Color.White * transparency);
            }
            else
            {
               spritebatch.Draw(Button1.Texture, Button1.HitBox.Location.ToVector2(), Color.White);
            }
                

            //Button1.Draw(spritebatch);
        }
    }
}
