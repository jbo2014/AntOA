using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ant.Utility
{
    public class StreamUtil
    {
        public static Stream StreamFromString(string str)
        {
            byte[] array = Encoding.ASCII.GetBytes(str);
            MemoryStream stream = new MemoryStream(array);  
            return stream;
        }
    }
}
