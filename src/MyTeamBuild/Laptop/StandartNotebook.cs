using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamBuild.Laptop
{
    public class StandartNotebook: INotebookBuilder
    {
        public DisplayEnvironment BuildDisplayEnvironment()
        {
            return new DisplayEnvironment()
            {
                GraphicCard = "Standart Graphic Card",
                ScreenResolution = "648 x 760",
                ScreenWide = "12''"
            };
        }

        public OEMEnvironment BuildOEMEnvironment()
        {
            return new OEMEnvironment()
            {
                Processor = "Standart Processor"
            };
        }
    }
}
