using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TestProject.GameScreens
{
    public class Editor : Screen
    {
        char[] resolution;
        
        public void setResolution(int width, int height)
        {
            resolution = new char[(width*height)];
        }

        public override void Initialize(FrameworkManager framework)
        {
            setResolution((int)framework.Resolution.X, (int)framework.Resolution.Y);
        }
        public override void LoadContent(ContentManager Content)
        {

        }
        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spritebatch)
        {

        }
    }
}
