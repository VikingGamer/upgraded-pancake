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
        SpriteFont font;

        float acc; // temp debug  tool

        public override void Initialize(FrameworkManager framework)
        {

        }
        public override void LoadContent(ContentManager Content)
        {
            Character = new Entities.Player(Content.Load<Texture2D>("pump"), new Rectangle(Point.Zero, new Point(32, 32)), true);
            Character.Texture = Content.Load<Texture2D>("pump");
            font = Content.Load<SpriteFont>("Code");
        }
        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { Character.Walk(1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) { Character.Walk(-1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) { Character.Jump(20, gameTime); }
            if (Keyboard.GetState().IsKeyDown(Keys.Down)) { Character.Walk(-20, 0); }
            
            if (Character.HitBoxLocationY <= 225f)
               acc = Modules.Physics.ApplyGravity(gameTime, Character);

            if (Character.HitBoxLocationY >= 225)
                Character.VelocityY = 0;
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Character.Texture, Character.HitBox.Location.ToVector2(), Color.White);
            spritebatch.DrawString(font, "Character properties:", new Vector2(100, 50), Color.White);
            spritebatch.DrawString(font, "mass: "+Character.Mass.ToString(), new Vector2(100, 70), Color.White);

            spritebatch.DrawString(font, "pos Y: "+Character.HitBoxLocationY.ToString(), new Vector2(100, 90), Color.White);
            spritebatch.DrawString(font, "velocity Y: "+Character.VelocityY.ToString(), new Vector2(100, 105), Color.White);
            spritebatch.DrawString(font, "acceleration Y: " + acc.ToString(), new Vector2(100, 125), Color.White);
        }
    }
}
