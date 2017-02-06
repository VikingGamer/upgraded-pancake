using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TestProject
{
    public abstract class Screen
    {
        public virtual void LoadContent(ContentManager Content) { }
        public virtual void Initialize(FrameworkManager framework) { }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spritebatch) { }
    }
}
