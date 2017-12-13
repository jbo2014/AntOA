using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Entity.BPM
{
    public class ZStep
    {
        public string id;

        public string title;

        public string type;

        /// <summary>
        /// Elements中的某个Element的ID
        /// </summary>
        public string? element;
    }
}
