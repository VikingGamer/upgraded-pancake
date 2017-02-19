using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//  x = 1
//  y = 0

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
            Character = new Entities.Player(Content.Load<Texture2D>("pump"), new Rectangle(Point.Zero, new Point(32, 32)), true);
            Character.Texture = Content.Load<Texture2D>("pump");
        }
        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { Character.Walk(1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) { Character.Walk(-1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) { Character.Walk(1, 0); }
            if (Keyboard.GetState().IsKeyDown(Keys.Down)) { Character.Walk(-1, 0); }
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Character.Texture, Character.HitBox.Location.ToVector2(), Color.White);
        }
    }
}
