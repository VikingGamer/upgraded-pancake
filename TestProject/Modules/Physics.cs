using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace TestProject.Modules
{
    class Physics
    {
        static Vector2 Force(Entities.GameObject entitiy)
        {
            return new Vector2(0, Math.Abs(entitiy.Mass * Variables.Gravity));
        }
        
        /// <summary>
        /// Apply gravity to an object.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="entitiy"></param>
        public static float ApplyGravity(GameTime time, Entities.GameObject entitiy)
        {
                Vector2 force = Force(entitiy);
            
                Vector2 acceleration = new Vector2(force.X / entitiy.Mass, force.Y / entitiy.Mass);

                entitiy.VelocityX += acceleration.X * Variables.DeltaTime(time);
                entitiy.VelocityY += acceleration.Y * Variables.DeltaTime(time);

                entitiy.HitBoxLocationX += entitiy.VelocityX;
                entitiy.HitBoxLocationY += entitiy.VelocityY;
            return acceleration.Y;
        }
    }

}
