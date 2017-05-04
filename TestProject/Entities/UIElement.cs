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

        Texture2D Animation_texture;

        bool m_Animation_done = false;
        bool m_Animation_start = false;

        public enum Buttonstate
        {
            Active,
            Deative,
            Hover,
            Unhover,
            Clicked,
            Released
        }
        public UIElement(Rectangle hitBox, bool isVisible, Texture2D texture, Texture2D anim) : base(hitBox, isVisible)
        {
            this.texture = texture;
            this.hitBox = hitBox;
            Animation_texture = anim;
        }
        public void Update(GameTime gameTime)
        {
            if (texture.Bounds.Contains(Mouse.GetState().Position))
                ButtonState = Buttonstate.Hover;
            if (!texture.Bounds.Contains(Mouse.GetState().Position))
                ButtonState = Buttonstate.Unhover;
            if (texture.Bounds.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                ButtonState = Buttonstate.Clicked;
            
        }  
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, hitBox.Location.ToVector2(), Color.White);
        }

        public Buttonstate ButtonState { get; set; }
        public Texture2D TexAnim { get { return Animation_texture; } }

        public bool Animation_start { get { return m_Animation_start; } set { m_Animation_start = value; } }
        public bool Animation_done { get { return m_Animation_done; } set { m_Animation_done = value; } }

    }
}
