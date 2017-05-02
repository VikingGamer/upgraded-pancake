using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TestProject.Entities.Player_utilities
{

    public class Controls
    {
        public Controls(Entities.Player Character)
        {
            this.Character = Character;
        }

        Entities.Player Character;

        /// <summary>
        /// Player movement actions
        /// </summary>
        /// <param name="gameTime"> Time </param>
        public void Movement(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { Character.Walk(1, Variables.World_Axis.RIGHT); }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) { Character.Walk(1, Variables.World_Axis.LEFT); }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                switch (Character.state)
                {
                    case Entities.Player.States.GROUNDED:
                        Character.Jump(8);
                        break;
                    case Entities.Player.States.IN_AIR:
                        if (Character.HitBoxLocationY > 225f) Character.state = Entities.Player.States.GROUNDED;
                        break;
                    default:
                        break;
                }
            }

            // if (Keyboard.GetState().IsKeyDown(Keys.Down)) { Character.Walk(-20, ); }

        }

    }
}
