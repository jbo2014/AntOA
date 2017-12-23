using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ant.Utility
{
    public class StreamUtil
    {
        /// <summary>
        /// 字符串转内存流
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Stream StreamFromString(string str)
        {
            byte[] array = Encoding.ASCII.GetBytes(str);
            MemoryStream stream = new MemoryStream(array);  
            return stream;
        }

        /// <summary>
        /// 流转字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string Stream(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            return content;
        }

        /// <summary>
        /// 流转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Stream Restore(ref Stream stream)
        {
            stream.Position = 0;
            return stream;
        }
    }
}
