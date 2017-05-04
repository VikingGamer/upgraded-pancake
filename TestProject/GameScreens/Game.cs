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

        double m_time;

        int walking_state = 0;
        int idle_state = 0;

        public override void Initialize(FrameworkManager framework)
        {

        }
        public override void LoadContent(ContentManager Content)
        {
            Character = new Entities.Player(Content.Load<Texture2D>("Sprite_sheet_walkingmp"), new Rectangle(Point.Zero, new Point(32, 32)), true, Content.Load<Texture2D>("Sprite_sheet_idling"));
            font = Content.Load<SpriteFont>("Code");

            Particle = new Entities.Particle(Content.Load<Texture2D>("Particle"), new Rectangle(Point.Zero, new Point(32, 32)), true, Vector2.Zero);
        }
        public override void Update(GameTime gameTime)
        {
            Character.Input.Movement(gameTime);

            m_time += Variables.DeltaTime(gameTime);

            if (m_time >= 0.2)
            {
                walking_state += 360;
                idle_state += 350;
                m_time = 0;
            }
            // Apply gravity : GameContext ?

            if (Character.HitBoxLocationY <= 68f)
                Modules.Physics.ApplyGravity(gameTime, Character);
            
            if (Character.HitBoxLocationY >= 68f)
                Character.VelocityY = 0;
        }
        public override void Draw(SpriteBatch spritebatch)
        { 

            if (walking_state >= 2100)
                walking_state = 0;

            if (idle_state >= 1050)
                idle_state = 0;

            if (Character.animation == Entities.Player.Animation.IDLE)
                spritebatch.Draw(Character.Idle, Character.HitBox.Location.ToVector2(), new Rectangle(idle_state, 0, 360, 650), Color.White);
            if (Character.animation == Entities.Player.Animation.WALK)
                spritebatch.Draw(Character.Texture, Character.HitBox.Location.ToVector2(), new Rectangle(walking_state, 0, 360, 650), Color.White);

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
