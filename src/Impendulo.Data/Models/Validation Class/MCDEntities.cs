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


                ////using (var Dbconnection = new MCDEntities())
                ////{
                ////    string IDNumberToValidate = entityEntry.CurrentValues.GetValue<string>("StudentIDNumber").ToString();
                ////    Student StudentFound = (from a in Dbconnection.Students
                ////                            where a.StudentIDNumber.Contains(IDNumberToValidate)
                ////                            select a).FirstOrDefault<Student>();
                ////    if (StudentFound != null)
                ////    {
                ////        if (entityEntry.Entity is Student)
                ////        {

                ////            var list = new List<System.Data.Entity.Validation.DbValidationError>();
                ////            list.Add(new System.Data.Entity.Validation.DbValidationError("StudentIDNumber", "(ID Number Invalid) - ID Number Already Exists in the System Please Re-Enter ID Number Or Search Again!"));

                ////            return new System.Data.Entity.Validation.DbEntityValidationResult(entityEntry, list);

                ////        }
                ////    }
                ////};



            }

            return base.ValidateEntity(entityEntry, items);
        }
    }
}
