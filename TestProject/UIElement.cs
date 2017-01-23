﻿using System;
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
        Rectangle currentBorder;
        Texture2D currentTexture;
        public UIElement(Vector2 position, bool isVisible, Rectangle border, Texture2D texture) : base(position, isVisible)
        {
            this.currentBorder = border;
            this.currentTexture = texture;
        }
        public void Update(GameTime gameTime)
        {
            if (Checkcollision(currentBorder) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                currentTexture.Dispose();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(currentTexture, currentBorder.Location.ToVector2(), Color.White);
        }
        private bool Checkcollision(Rectangle Rec1)
        {
            if (Rec1.Contains(Mouse.GetState().Position))
                return true;
            else
                return false;
        }
    }
}
