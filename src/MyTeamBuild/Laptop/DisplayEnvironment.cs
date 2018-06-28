using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamBuild.Laptop
{
    //http://safakunel.blogspot.com.tr/2013/10/c-builder-pattern-kullanimi-oop-design.html
    public class DisplayEnvironment
    {
        public string GraphicCard { get; set; }
        public string ScreenWide { get; set; }
        public string ScreenResolution { get; set; }
    }

    public class OEMEnvironment
    {
        public string Processor { get; set; }
    }

    public class NotebookProduct
    {
        public DisplayEnvironment ProductDisplayEnvironment { get; set; }
        public OEMEnvironment ProductOEMEnvironment  { get; set; }
    }
}
