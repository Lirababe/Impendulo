using Impendulo.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Data.Models.Interfaces
{
    interface IEntityObjectState
    {
        EntityObjectState ObjectState { get; set; }
    }
}
