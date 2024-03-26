using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;

namespace Lab2
{
    static class View
    {
        static public int minimum = 0;
        static public int maximum = 255;

        public static void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        public static void DrawTexture(int layerNumber)
        {
            GenerateTextureImage(layerNumber);
            Load2DTexture();
            DrawTexture();
            System.GC.Collect(1, System.GCCollectionMode.Forced, false);
        }

        public static void DrawQuads(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for (int x = 0; x < Bin.X - 1; x++)
            {
                short value;
                for (int y = 0; y < Bin.Y - 1; y++)
                {
                    // 1st vertex
                    value = Bin.array[x + y * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x, y);

                    // 2nd vertex
                    value = Bin.array[x + (y + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x, y + 1);

                    // 3rd vertex
                    value = Bin.array[(x + 1) + (y + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x + 1, y + 1);

                    // 4th vertex
                    value = Bin.array[(x + 1) + y * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x + 1, y);
                }
            }
            GL.End();
        }

        public static void DrawQuadStrip(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            for (int x = 0; x < Bin.X - 1; x++)
            {
                GL.Begin(BeginMode.QuadStrip);
                short value;
                value = Bin.array[x + 0 * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(Color.Magenta);
                GL.Vertex2(x, 0);

                value = Bin.array[x + (0 + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(Color.Magenta);
                GL.Vertex2(x, 0 + 1);
                for (int y = 1; y < Bin.Y - 1; y++)
                {
                    value = Bin.array[(x + 1) + (y + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(Color.Magenta);
                    GL.Vertex2(x + 1, y + 1);

                    value = Bin.array[(x + 1) + y * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x + 1, y);
                }
                GL.End();
            }
            
        }

        static Bitmap textureImage;
        static int VBOtexture;
        public static void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            BitmapData data = textureImage.LockBits(
                new Rectangle(0, 0, textureImage.Width, textureImage.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            textureImage.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            //ErrorCode err = GL.GetError();
            //string str = err.ToString();
        }

        public static void GenerateTextureImage(int layerNumber)
        {
            textureImage = new Bitmap(Bin.X, Bin.Y);
            for (int x = 0; x < Bin.X; x++)
            {
                for (int y = 0; y < Bin.Y; y++)
                {
                    int pixelnumber = x + y * Bin.X + layerNumber * Bin.X * Bin.Y;
                    textureImage.SetPixel(x, y, TransferFunction(Bin.array[pixelnumber]));
                }
            }
        }

        public static void DrawTexture()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);

            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);

            GL.TexCoord2(0f, 0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0);

            GL.End();

            GL.Disable(EnableCap.Texture2D);
        }

        static public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        static Color TransferFunction(short value)
        {
            int newVal = Clamp((value - minimum) * 255 / (maximum - minimum), 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);
        }
    }
}
