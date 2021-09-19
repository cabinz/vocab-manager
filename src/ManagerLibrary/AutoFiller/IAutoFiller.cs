using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLibrary.AutoFiller
{
    public interface IAutoFiller
    {
        string Spelling();

        string DefinitionText();

        string ContextText();

        string SourceText();
    }
}
