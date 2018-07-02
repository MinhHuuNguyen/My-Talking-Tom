using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTalkingTom
{
    class FileManager
    {
        public static String OpenReadFile(String filePath)
        {
            String mediateString;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            fileStream.Close();
            StreamReader streamReader = new StreamReader(filePath);
            mediateString = streamReader.ReadLine();
            streamReader.Close();
            return mediateString;
        }

        //append = true la viet vao cuoi file
        public static void OpenWriteFile(String filePath, String inputString, bool append)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            fileStream.Close();
            StreamWriter streamWriter = new StreamWriter(filePath, append);
            streamWriter.Write(inputString + "\t");
            streamWriter.Close();
        }

        public static bool CheckFileExist(String filePath)
        {
            return true;
        }

        public static void CreateFile(String filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
            fileStream.Close();
        }
    }
}
