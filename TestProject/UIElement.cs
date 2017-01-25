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
        public UIElement(Point position, bool isVisible, Texture2D texture) : base(position, isVisible)
        {
            currentBorder.Height = texture.Height;
            currentBorder.Width = texture.Width;
            this.currentTexture = texture;
        }
        public void Update(GameTime gameTime)
        {
            if (CheckMouseCollision(currentBorder) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                currentTexture.Dispose();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(currentTexture, currentBorder.Location.ToVector2(), Color.White);
        }
        private bool CheckMouseCollision(Rectangle Rec1)
        {
            if (Rec1.Contains(Mouse.GetState().Position))
                return true;
            else
                return false;
        }
    }
}
