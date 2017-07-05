using Impendulo.Data.Models.Enum;
using Impendulo.Data.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Impendulo.Data.Models
{

    public partial class StudentPhoto : IEntityObjectState
    {
        [NotMapped]
        public EntityObjectState ObjectState
        {
            get;
            set;
        }
    }
}
