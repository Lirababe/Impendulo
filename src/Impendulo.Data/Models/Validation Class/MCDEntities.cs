using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace Impendulo.Data.Models
{


    public partial class MCDEntities : DbContext
    {

        protected override bool ShouldValidateEntity(DbEntityEntry entityEntry)
        {
            return base.ShouldValidateEntity(entityEntry);
        }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {

            if (entityEntry.Entity is Student)
            {

                if (entityEntry.CurrentValues.GetValue<string>("StudentIDNumber").Length == 0)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("StudentIDNumber", "(ID Number Invalid) - ID Number Can Not Be Blank."));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }

                if (entityEntry.CurrentValues.GetValue<string>("StudentIDNumber").Length != 13)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("StudentIDNumber", "(ID Number Invalid) - ID Number Length Must Be 13 Charaters In Length"));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }
            }

            if (entityEntry.Entity is Course)
            {
                if (entityEntry.CurrentValues.GetValue<string>("CourseName").Length == 0)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("Course Name", "(Course Name Invalid) - Course Name Can Not Be Blank."));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }
            }

            if (entityEntry.Entity is CurriculumCourse)
            {
                if ((entityEntry.CurrentValues.GetValue<decimal>("Cost").ToString()).Length == 0)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("Course Cost", "(Cost Invalid) - Cost Can Not Be Empty."));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }

                if (entityEntry.CurrentValues.GetValue<decimal>("Cost") == 0)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("Course Cost", "(Cost Invalid) - Cost Can Not Be Zero."));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }
            }

            if (entityEntry.Entity is Venue)
            {
                if ((entityEntry.CurrentValues.GetValue<string>("VenueName").ToString()).Length == 0)
                {
                    var list = new List<System.Data.Entity.Validation.DbValidationError>();
                    list.Add(new System.Data.Entity.Validation.DbValidationError("Venue Name", "(Venue Name Invalid) -  Name Can Not Be Empty."));

                    return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);
                }
            }


            return base.ValidateEntity(entityEntry, items);
        }
    }
}
