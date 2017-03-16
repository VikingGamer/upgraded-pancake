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
        Texture2D Editor_text;

        UIElement Button1;
        UIElement Editor_btn;

        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            TexButton = Content.Load<Texture2D>("Button");
            Background = Content.Load<Texture2D>("Space");
            Editor_text = Content.Load<Texture2D>("Editor");

            Button1 = new UIElement(new Rectangle(Point.Zero, new Point(32, 32)), true, TexButton);
            Editor_btn = new UIElement(new Rectangle(new Point(80, 380), new Point(32, 32)), true, Editor_text);

        }
        public override void Update(GameTime gameTime)
        {
            Button1.Update(gameTime);
            if (Button1.Clicked())
            {
                Core.currentScreen = ScreenStates.Game;
                Entities.GameObject.GameObjects.RemoveAt(0);
            }

            if (Editor_btn.Clicked())
            {
                Core.currentScreen = ScreenStates.Editor;
            }
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Background, Vector2.Zero, Color.White);
            Button1.Draw(spritebatch);
            Editor_btn.Draw(spritebatch);
        }
    }
}
