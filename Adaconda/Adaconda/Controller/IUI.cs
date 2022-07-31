using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Adaconda.Controller
{
    internal interface IUI
    {
        void CallLoginForm();
        void CallHardWareConfigForm();
        void CloseForm(Window form);

    }
}
