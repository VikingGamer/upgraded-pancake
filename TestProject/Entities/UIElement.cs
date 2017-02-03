using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject.Entities
{
    public class UIElement : GameObject
    {
        public Texture2D Texture;
        public Point Position;
        public UIElement(Point position, bool isVisible, Texture2D texture) : base(position, isVisible)
        {
            Texture = texture;
            Position = position;
        }
        public void Update(GameTime gameTime)
        {
            if (Clicked() == true)
                Core.currentScreen = ScreenStates.Splash;
        }  
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position.ToVector2(), Color.White);
        }
        public bool Clicked()
        {
            if (Texture.Bounds.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                return true;
            else
                return false;
        }
    }
}
