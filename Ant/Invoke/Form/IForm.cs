using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Invoke.Form
{
    interface IForm
    {
        object GetForm(Guid id);

        bool SaveFormData(Guid masterID, object content, Guid formID=new Guid());

        void SetField(string name, object value);

        object GetField(string name);
    }
}
