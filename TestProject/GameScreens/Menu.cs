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
        SpriteFont Font;
        double TotalFrames;
        double FramesPerSecond;
        public bool InGame { get; set; }

        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            Font = Content.Load<SpriteFont>("Main");
            TexButton = Content.Load<Texture2D>("Button");
            Background = Content.Load<Texture2D>("Space");
            Button1 = new UIElement(Point.Zero, true, TexButton);
        }
        public override void Update(GameTime gameTime)
        {
            Button1.Update(gameTime);
            if (Button1.Clicked()) { Core.currentScreen = ScreenStates.Game; }
            if (gameTime.ElapsedGameTime.TotalSeconds > 0)
                FramesPerSecond = gameTime.ElapsedGameTime.Seconds;
        }

        public override void Draw(SpriteBatch spritebatch, GameTime gameTime)
        {
            TotalFrames++;
            

            spritebatch.Draw(Background, Vector2.Zero, Color.White);
            spritebatch.DrawString(Font, FramesPerSecond.ToString(), new Vector2(500), Color.White);
            //spritebatch.Draw(Button1.Texture, Button1.Position.ToVector2(), Color.White);

            //Button1.Draw(spritebatch);

        }
    }
}
