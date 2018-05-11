using OCG.ResourceManagement.DSModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCG.ResourceManagement.OCGAzureRepo
{
    [Export("OCGAzure", typeof(IOCGDSRepository))]
    [ExportMetadata("Name", "OCGAzure")]
    public class OCGAzureRepo : IOCGDSRepository
    {
        public new string GetType()
        {
            return "OCG Azure Repository";
        }
    }
}
