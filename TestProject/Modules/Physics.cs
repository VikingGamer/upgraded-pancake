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
        /// <param name="entity"></param>
        public static void ApplyGravity(GameTime time, Entities.GameObject entity)
        {
                Vector2 force = Force(entity);
            
                Vector2 acceleration = new Vector2(force.X / entity.Mass, force.Y / entity.Mass);

                entity.VelocityX += acceleration.X * Variables.DeltaTime(time);
                entity.VelocityY += acceleration.Y * Variables.DeltaTime(time);

                entity.HitBoxLocationX += entity.VelocityX;
                entity.HitBoxLocationY += entity.VelocityY;
        }

    }

}
