using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject.GameScreens
{
    public class Game : Screen
    {
        Entities.Player Character;
        public override void Initialize(FrameworkManager framework)
        {

        }
        public override void LoadContent(ContentManager Content)
        {
            Character = new Entities.Player(Point.Zero, true);
            Character.Texture = Content.Load<Texture2D>("Character");
        }
        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { Character.Walk(1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) { Character.Walk(-1); }
        }
        public override void Draw(SpriteBatch spritebatch, GameTime gameTime)
        {
            spritebatch.Draw(Character.Texture, Character.Position.ToVector2(), Color.White);
        }
    }
}
