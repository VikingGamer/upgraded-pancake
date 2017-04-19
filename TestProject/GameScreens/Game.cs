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
        Entities.Particle Particle;
        SpriteFont font;

        


        public override void Initialize(FrameworkManager framework)
        {
            
        }
        public override void LoadContent(ContentManager Content)
        {
            Character = new Entities.Player(Content.Load<Texture2D>("Fighter"), new Rectangle(Point.Zero, new Point(32, 32)), true);
            font = Content.Load<SpriteFont>("Code");

            Particle = new Entities.Particle(Content.Load<Texture2D>("Particle"), new Rectangle(Point.Zero, new Point(32, 32)), true, Vector2.Zero);
            
        }
        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { Character.Walk(1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) { Character.Walk(-1, 1); }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                switch (Character.state)
                {
                    case Entities.Player.States.GROUNDED:
                        Character.Jump(8, gameTime);
                        break;
                    case Entities.Player.States.IN_AIR:
                        if (Character.HitBoxLocationY > 225f) Character.state = Entities.Player.States.GROUNDED;
                        break;
                    default:
                        break;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down)) { Character.Walk(-20, 0); }
            
            if (Character.HitBoxLocationY <= 225f)
               Modules.Physics.ApplyGravity(gameTime, Character);

            if (Character.HitBoxLocationY >= 225)
                Character.VelocityY = 0;
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Character.Texture, Character.HitBox.Location.ToVector2(), Color.White);
            spritebatch.Draw(Particle.Texture, Particle.HitBox.Location.ToVector2(), Color.White);

            spritebatch.DrawString(font, "Character properties:", new Vector2(100, 50), Color.White);
            spritebatch.DrawString(font, "mass: "+Character.Mass.ToString(), new Vector2(100, 70), Color.White);

            spritebatch.DrawString(font, "pos Y: "+Character.HitBoxLocationY.ToString(), new Vector2(100, 90), Color.White);
            spritebatch.DrawString(font, "velocity Y: "+Character.VelocityY.ToString(), new Vector2(100, 105), Color.White);
            spritebatch.DrawString(font, "acceleration Y: " + Variables.Gravity, new Vector2(100, 125), Color.White);
            
            spritebatch.DrawString(font, "GameObjects Active: " + Entities.GameObject.GameObjects.Count, new Vector2(100, 145), Color.White);
            

        }
    }
}
