using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Lab2
{
    class View
    {
        public static void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        public static void DrawQuads(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for (int x = 0; x < Bin.X-1; x++)
            {
                for (int y = 0; y < Bin.Y-1; y++)
                {
                    short value;

                    // 1st vertex
                    value = Bin.array[x + y * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x, y);

                    // 2nd vertex
                    value = Bin.array[x + (y + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x, y+1);

                    // 3rd vertex
                    value = Bin.array[(x + 1) + (y + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x+1, y+1);

                    // 4th vertex
                    value = Bin.array[(x + 1) + y * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x+1, y);
                }
            }
            GL.End();
        }

        static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        static Color TransferFunction(short value)
        {
            int min = 0, max = 255;
            int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);
        }
    }
}
