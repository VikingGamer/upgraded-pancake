using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestProject.GameScreens;

namespace TestProject
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Core : Microsoft.Xna.Framework.Game
    {
        public static ScreenStates currentScreen { get; set; }
        
        #region Engine components
        GraphicsDeviceManager Graphics;
        SpriteBatch SpriteBatch;
        FrameworkManager Framework;
        #endregion

        #region Screens
        GameScreens.Splash ScreenSplash;
        GameScreens.Menu ScreenMenu;
        GameScreens.Game ScreenGame;
        #endregion

        public Core()
        {
            Framework = new FrameworkManager(1280, 720);
            Graphics = new GraphicsDeviceManager(this);

            ScreenSplash = new GameScreens.Splash();
            ScreenMenu = new GameScreens.Menu();
            ScreenGame = new GameScreens.Game();

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
            
            IsMouseVisible = true;
            Window.Title = "Nanosoft";
            IsFixedTimeStep = true;
            
            if (Framework != null)
            {
                currentScreen = ScreenStates.Splash;
            }
            ScreenMenu.Initialize(Framework);
            
            Framework.Refresh(Graphics);
            ScreenSplash.Initialize(Framework);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenMenu.LoadContent(Content);
            ScreenSplash.LoadContent(Content);     
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
                currentScreen = ScreenStates.Menu;

            switch (currentScreen)
            {
                case ScreenStates.Splash:
                    ScreenSplash.Update(gameTime);
                    break;
                case ScreenStates.Menu:
                    ScreenMenu.Update(gameTime);
                    break;
                case ScreenStates.Game:
                    ScreenGame.Update(gameTime);
                    break;
                case ScreenStates.Pause:
                    break;
                case ScreenStates.Highscore:
                    break;
                default:
                    break;
            }
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            SpriteBatch.Begin();

            switch (currentScreen)
            {
                case ScreenStates.Splash:
                    ScreenSplash.Draw(SpriteBatch, gameTime);
                    break;
                case ScreenStates.Menu:
                    ScreenMenu.Draw(SpriteBatch, gameTime);
                    break;
                case ScreenStates.Game:
                    ScreenGame.Draw(SpriteBatch, gameTime);
                    break;
                case ScreenStates.Pause:
                    break;
                case ScreenStates.Highscore:
                    break;
                default:
                    break;
            }
            SpriteBatch.End();

            
            base.Draw(gameTime);
        }
    }
}
