using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamBuild.Laptop
{
    public class BuilderDirector
    {
        private INotebookBuilder Builder;

        public BuilderDirector(INotebookBuilder builder)
        {
            Builder = builder;
        }

        public NotebookProduct BuildNotebook()
        {
            NotebookProduct product = new NotebookProduct();
            product.ProductDisplayEnvironment = Builder.BuildDisplayEnvironment();
            product.ProductOEMEnvironment = Builder.BuildOEMEnvironment();
            return product;
        }

        public NotebookProduct BuildNotebookDisplayEnvironmentOnly()
        {
            NotebookProduct product = new NotebookProduct();
            product.ProductOEMEnvironment = Builder.BuildOEMEnvironment();
            return product;
        }

        public NotebookProduct BuildNotebookOEMEnvironmentOnly()
        {
            NotebookProduct product = new NotebookProduct();
            product.ProductOEMEnvironment = Builder.BuildOEMEnvironment();
            return product;
        }
    }
}
