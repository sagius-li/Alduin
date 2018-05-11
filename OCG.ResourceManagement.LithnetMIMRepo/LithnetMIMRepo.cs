using OCG.ResourceManagement.DSModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCG.ResourceManagement.LithnetMIMRepo
{
    [Export("LithnetMIM", typeof(IOCGDSRepository))]
    [ExportMetadata("Name", "LithnetMIM")]
    public class LithnetMIMRepo : IOCGDSRepository
    {
        public new string GetType()
        {
            return "Lithnet MIM Repository";
        }
    }
}
