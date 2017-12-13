using Ant.Enact;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ant.Parse
{
    internal class Parser
    {
        private XElement xmlDoc;

        #region 加载xml
        public void LoadProcessByFile(string filePath)
        {
            this.xmlDoc = XElement.Load(filePath);
        }

        public void LoadProcessByString(string xmlString)
        {
            this.xmlDoc = XElement.Parse(xmlString);
        }

        public void LoadProcessByStream(Stream xmlStream)
        {
            this.xmlDoc = XElement.Load(xmlStream);
        }
        #endregion
    }
}
