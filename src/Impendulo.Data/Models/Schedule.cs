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
    
    public partial class Schedule
    {
        public int ScheduleID { get; set; }
        public int CurriculumCourseEnrollmentID { get; set; }
        public int FacilitatorID { get; set; }
        public System.DateTime ScheduleStartDate { get; set; }
        public System.DateTime ScheduleCompletionDate { get; set; }
        public int ScheduleStatusID { get; set; }
        public int EnrollmentID { get; set; }
        public int ScheduleLocationID { get; set; }
    
        public virtual CurriculumCourseEnrollment CurriculumCourseEnrollment { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public virtual Facilitator Facilitator { get; set; }
        public virtual LookupScheduleLocation LookupScheduleLocation { get; set; }
        public virtual LookupScheduleStatus LookupScheduleStatus { get; set; }
        public virtual OffSiteSchedule OffSiteSchedule { get; set; }
        public virtual OnSiteSchedule OnSiteSchedule { get; set; }
    }
}
