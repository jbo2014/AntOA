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
        /// 字符串转流
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Stream StreamFromString(string str)
        {
            MemoryStream stream = null;
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                byte[] array = Encoding.ASCII.GetBytes(str);
                stream = new MemoryStream(array);
            }
            return stream;
        }

        /// <summary>
        /// 流转字符串
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string StringFromStream(Stream stream)
        {
            string content = string.Empty;
            if (stream==null)
            {
                return null;
            }
            else
            {
                StreamReader reader = new StreamReader(stream);
                content = reader.ReadToEnd();
            }
            return content;
        }

        /// <summary>
        /// 流转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Stream Restore(ref Stream stream)
        {
            if (stream != null)
                stream.Position = 0;
            else
                return null;
            return stream;
        }
    }
}
