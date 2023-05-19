using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    public interface IUIElementFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}
