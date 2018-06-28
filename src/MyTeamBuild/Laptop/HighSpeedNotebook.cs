using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamBuild.Laptop
{
    public class HighSpeedNotebook:INotebookBuilder
    {
        public DisplayEnvironment BuildDisplayEnvironment()
        {
            return new DisplayEnvironment()
            {
                GraphicCard = "High Speed Graphic Card",
                ScreenResolution = "1248 x 1200",
                ScreenWide = "17''"
            };
        }

        public OEMEnvironment BuildOEMEnvironment()
        {
            return new OEMEnvironment()
            {
                Processor = "High Speed Processor"
            
            };
        }
    }
}
