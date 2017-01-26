using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestProject.GameScreens;

namespace TestProject
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Core : Game
    {
        public static ScreenStates currentScreen;

        #region Core variables
        public ContentManager cntManager { get; set; }
        GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        FrameworkManager Framework;
        #endregion

        Texture2D background;
        Texture2D button;

        #region Game Screens
        Splash SplashScreen = new Splash();
        Menu MenuScreen = new Menu();
        #endregion

        UIElement button1;

        public Core()
        {
            Framework = new FrameworkManager(1280, 720);
            graphics = new GraphicsDeviceManager(this);

            //Content.RootDirectory = "Content";
            cntManager.RootDirectory = "Content";
            
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
            background = cntManager.Load<Texture2D>("Space");
            button = cntManager.Load<Texture2D>("Button");
            
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

            switch (currentScreen)
            {
                case ScreenStates.Splash:
                    SplashScreen.Update(gameTime);
                    break;
                case ScreenStates.Menu:
                    MenuScreen.Update(gameTime);
                    break;
                case ScreenStates.Game:
                    break;
                case ScreenStates.Pause:
                    break;
                case ScreenStates.Highscore:
                    break;
                default:
                    break;
            }

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
            #region Screen states
            switch (currentScreen)
            {
                case ScreenStates.Splash:
                    SplashScreen.Draw(spriteBatch);
                    break;
                case ScreenStates.Menu:
                    MenuScreen.Draw(spriteBatch);
                    break;
                case ScreenStates.Game:
                    break;
                case ScreenStates.Pause:
                    break;
                case ScreenStates.Highscore:
                    break;
                default:
                    break;
            }
            #endregion
            button1.Draw(spriteBatch);
            spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
