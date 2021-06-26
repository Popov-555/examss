using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEX.Model
{
    interface IDataProvider
    {
        IEnumerable<Med> GetMeds();
        IEnumerable<MedDiagnoz> GetMedDiagnoz();
    }
}

