//Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. 
//You are not allowed to use the File class or similar helper classes.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            FileStream readImg = new FileStream("SoftUni.jpg", FileMode.Open);
            FileStream copyImg = new FileStream("CopySoftUni.jpg", FileMode.Create);

            using (readImg)
            {
                using (copyImg)
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = readImg.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        copyImg.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
