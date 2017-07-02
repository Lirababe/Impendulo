//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impendulo.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.CourseSchedules = new ObservableListSource<CourseSchedule>();
            this.StudentAssociatedCompanies = new ObservableListSource<StudentAssociatedCompany>();
            this.StudentDisabilities = new ObservableListSource<StudentDisability>();
            this.NextOfKins = new ObservableListSource<NextOfKin>();
            this.Enrollments = new ObservableListSource<Enrollment>();
        }
    
        public int StudentID { get; set; }
        public int QualificationLevelID { get; set; }
        public int MartialStatusID { get; set; }
        public int GenderID { get; set; }
        public int EthnicityID { get; set; }
        public string StudentIDNumber { get; set; }
        public string StudentCurrentPosition { get; set; }
        public System.DateTime StudentlInitialDate { get; set; }
        public byte[] RowVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CourseSchedule> CourseSchedules { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual LookupEthnicity LookupEthnicity { get; set; }
        public virtual LookupGender LookupGender { get; set; }
        public virtual LookupMartialStatus LookupMartialStatus { get; set; }
        public virtual LookupQualificationLevel LookupQualificationLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<StudentAssociatedCompany> StudentAssociatedCompanies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<StudentDisability> StudentDisabilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<NextOfKin> NextOfKins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Enrollment> Enrollments { get; set; }
    }
}
