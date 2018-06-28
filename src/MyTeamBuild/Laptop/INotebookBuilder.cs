using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamBuild.Laptop
{
    public interface INotebookBuilder
    {
        DisplayEnvironment BuildDisplayEnvironment();
        OEMEnvironment BuildOEMEnvironment();
    }
}
