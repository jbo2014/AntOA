using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Entity.BPM
{
    public class ZProcess
    {
        public string title;

        public string author;

        public string codeType;

        public string version;

        public DateTime created;

        public bool release;

        public ZFlow flow;

        public List<ZElement> elements;

        public List<ZPage> pages;

        public List<ZParam> parameters;
    }
}
