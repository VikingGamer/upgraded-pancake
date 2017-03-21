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
        public enum Buttonstate
        {
            Active,
            Deative,
            Hover,
            Unhover,
            Clicked,
            Released
        }
        public UIElement(Rectangle hitBox, bool isVisible, Texture2D texture) : base(hitBox, isVisible)
        {
            this.texture = texture;
            this.hitBox = hitBox;
        }
        public void Update(GameTime gameTime)
        {
            if (texture.Bounds.Contains(Mouse.GetState().Position))
                ButtonState = Buttonstate.Hover;
            if (texture.Bounds.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                ButtonState = Buttonstate.Clicked;
            
        }  
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, hitBox.Location.ToVector2(), Color.White);
        }

        public Buttonstate ButtonState { get; set; }

    }
}
