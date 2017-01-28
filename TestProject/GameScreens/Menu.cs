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
        Texture2D background;
        Texture2D TexButton;
        UIElement button1;

        public bool InGame { get; set; }

        public override void Initialize()
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            TexButton = Content.Load<Texture2D>("Button");
            background = Content.Load<Texture2D>("Space");
            button1 = new UIElement(Point.Zero, true, TexButton);
        }
        public override void Update(GameTime gameTime)
        {
            button1.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(background, Vector2.Zero, Color.White);
            spritebatch.Draw(button1.texture, button1.position.ToVector2(), Color.White);
            button1.Draw(spritebatch);

        }
    }
}
