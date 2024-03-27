using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    class Bin
    {
        public static int X, Y, Z;
        public static short[] array;
        public Bin() { }

        public bool readBIN(string path)
        {
            if (File.Exists(path))
            {
                BinaryReader reader;
                try
                {
                    reader =
                        new BinaryReader(File.Open(path, FileMode.Open));
                    X = reader.ReadInt32();
                    Y = reader.ReadInt32();
                    Z = reader.ReadInt32();

                    int arraySize = X * Y * Z;
                    array = new short[arraySize];
                    for (int i = 0; i < arraySize; i++)
                    {
                        array[i] = reader.ReadInt16();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", 0);
                    return false;
                }
            }
            return true;
        }
    }
}
