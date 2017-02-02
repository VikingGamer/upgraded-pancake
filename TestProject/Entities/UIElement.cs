using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject
{
    public class UIElement : GameObject
    {
        public Texture2D texture;
        public Point position;
        public UIElement(Point position, bool isVisible, Texture2D texture) : base(position, isVisible)
        {
            this.texture = texture;
            this.position = position;
        }
        public void Update(GameTime gameTime)
        {
            if (Clicked() == true)
                texture.Dispose();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position.ToVector2(), Color.White);
        }
        bool Clicked()
        {
            if (texture.Bounds.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                return true;
            else
                return false;
        }
    }
}
