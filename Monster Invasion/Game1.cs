using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Monster_Invasion
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public static int SCREEN_WIDTH = 640;
        public static int SCREEN_HEIGHT = 480;
        public static Texture2D playerTexture;
        public static Texture2D basicEnemyTexture;
        public static Texture2D projectileTexture;
        
        GraphicsDeviceManager graphics;
        ContentManager content;
        SpriteBatch spriteBatch;

        Player player;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            content = new ContentManager(Services);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
            player = new Player(Vector2(SCREEN_WIDTH / 2, SCREEN_HEIGHT / 2));

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadGraphicsContent(bool loadAllContent)
        {
            if (loadAllContent)
            {
                playerTexture = content.Load<Texture2D>(@"Textures\player");
                player.texture = playerTexture;
                basicEnemyTexture = content.Load<Texture2D>(@"Textures\basic_enemy");
                projectileTexture = content.Load<Texture2D>(@"Textures\projectile");
            }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent(bool unloadAllContent)
        {
            content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Main game loop
            player.Update();

            foreach (Enemy enemy in Enemy.enemyList)
            {
                enemy.Update();
                if (HaveCollided(player, enemy))
                {
                    // TODO: Handle enemy - player collision consequences
                }
            }

            foreach (Projectile projectile in Projectile.projectileList)
            {
                projectile.Update();
                if (HaveCollided(player, projectile))
                {
                    // TODO: Handle projectile - player collision consequences
                }
            }

            Level.Update();


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public static bool HaveCollided(GameItem gameItem1, GameItem gameItem2)
        {
            // TODO: Implement collision detection :)
        }
    }
}
