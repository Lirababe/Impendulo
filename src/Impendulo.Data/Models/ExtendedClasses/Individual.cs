using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Data.Models
{
    public partial class Individual
    {
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", IndividualFirstName, IndividualLastname);
            }
        }

        public override string ToString()
        {
            return FullName;
        }
        //public string FullName
        //{
        //    get { return string.Format("{0} {1} {2}", IndividualFirstName, IndividualSecondName, IndividualLastname); }
        //}
        //public override string ToString()
        //{
        //    return FullName;
        //}
    }
}


/*/// <summary>
/// Add a field with the employee's full name
/// </summary>
public partial class Employee
{
    public string FullName
    {
      get { return string.Format("{0} {1}", FirstName, LastName); }
    }
    public override string ToString()
    {
      return FullName;
    }
}
*/
