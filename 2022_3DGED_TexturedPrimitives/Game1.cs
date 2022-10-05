using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2022_3DGED_TexturedPrimitives
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Matrix world, view, projection;
        private BasicEffect effect;
        private VertexPositionNormalTexture[] verts;
        private Vector3 cameraPosition;
        private Vector3 cameraTarget;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //world
            world = Matrix.Identity;
            //view
            view = Matrix.CreateLookAt(cameraPosition, cameraTarget, Vector3.UnitY);
            //projection
            projection = Matrix.CreatePerspectiveFieldOfView(
                MathHelper.PiOver2 / 2, 16 / 10.0f, 0.1f, 1000);

            //effect
            effect = new BasicEffect(_graphics.GraphicsDevice);

            //vertices
            verts = new VertexPositionNormalTexture[6];

            //TOP LEFT TRIANGLE
            verts[0] = new VertexPositionNormalTexture(
                new Vector3(-1, 1, 0), Vector3.UnitZ, new Vector2(0, 0));

            verts[1] = new VertexPositionNormalTexture(
               new Vector3(1, 1, 0), Vector3.UnitZ, new Vector2(1, 0));

            verts[2] = new VertexPositionNormalTexture(
              new Vector3(-1, -1, 0), Vector3.UnitZ, new Vector2(0, 1));

            //BOTTOM RIGHT TRIANGLE
            verts[3] = new VertexPositionNormalTexture(
             new Vector3(1, 1, 0), Vector3.UnitZ, new Vector2(1, 0));

            verts[4] = new VertexPositionNormalTexture(
               new Vector3(1, -1, 0), Vector3.UnitZ, new Vector2(1, 1));

            verts[5] = new VertexPositionNormalTexture(
              new Vector3(-1, -1, 0), Vector3.UnitZ, new Vector2(0, 1));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}