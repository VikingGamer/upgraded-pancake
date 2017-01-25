using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestProject
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Core : Game
    {
        ScreenStates currentScreen;
        
        #region ?
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D background;
        Texture2D button;
        FrameworkManager Framework;
        List<Screen> Screens = new List<Screen>();
        #endregion

        UIElement button1;

        public Core()
        {
            Framework = new FrameworkManager(1280, 720);
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
            
        }
        
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            GameScreens.Splash SSplash = new GameScreens.Splash();
            Screens.Add(SSplash);

                Framework.Refresh(graphics);
                IsMouseVisible = true;
                Window.Title = "Nanosoft";

            if (Framework != null)
            {
                currentScreen = ScreenStates.Splash;
            }
            button1 = new UIElement(new Point(20), true, button);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("Space");
            button = Content.Load<Texture2D>("Button");
            
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            #region Splash Screen
            if (currentScreen == ScreenStates.Splash)
            {
                Screens[0].Update(gameTime);
            }
            #endregion

            button1.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            button1.Draw(spriteBatch);
            spriteBatch.End();

            if (currentScreen == ScreenStates.Splash)
            {
                Screens[(int)ScreenStates.Splash].Draw(spriteBatch);
            }

            base.Draw(gameTime);
        }
    }
}
