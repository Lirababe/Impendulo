using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Data.Models
{
    using Enum;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CurriculumCourseDayCanBeScheduled : IEntityObjectState
    {

        [NotMapped]
        public EntityObjectState ObjectState
        {
            get;
            set;
        }
    }
}
