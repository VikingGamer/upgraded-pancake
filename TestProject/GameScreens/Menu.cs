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
        Texture2D Background;
        Texture2D TexButton;
        UIElement Button1;

        public bool InGame { get; set; }

        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            TexButton = Content.Load<Texture2D>("Button");
            Background = Content.Load<Texture2D>("Space");
            Button1 = new UIElement(Point.Zero, true, TexButton);
        }
        public override void Update(GameTime gameTime)
        {
            Button1.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Background, Vector2.Zero, Color.White);
            spritebatch.Draw(Button1.Texture, Button1.Position.ToVector2(), Color.White);
            Button1.Draw(spritebatch);

        }
    }
}
