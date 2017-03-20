using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace TestProject
{
    public class Variables
    {
        public static float Gravity { get { return -20f; } }
        public static float DeltaTime(GameTime time)
        {
            return (float)time.ElapsedGameTime.TotalSeconds;
        }
    }
}
