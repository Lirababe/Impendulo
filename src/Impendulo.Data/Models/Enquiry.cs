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
    
    public partial class Enquiry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enquiry()
        {
            this.CurriculumEnquiries = new ObservableListSource<CurriculumEnquiry>();
            this.EquiryHistories = new ObservableListSource<EquiryHistory>();
            this.Companies = new ObservableListSource<Company>();
            this.EmailMessageRepositories = new ObservableListSource<EmailMessageRepository>();
            this.Individuals = new ObservableListSource<Individual>();
            this.LookupEquiryOrigions = new ObservableListSource<LookupEquiryOrigion>();
        }
    
        public int EnquiryID { get; set; }
        public System.DateTime EnquiryDate { get; set; }
        public bool InitialConsultationComplete { get; set; }
        public int EnquiryStatusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<CurriculumEnquiry> CurriculumEnquiries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<EquiryHistory> EquiryHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Company> Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<EmailMessageRepository> EmailMessageRepositories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Individual> Individuals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<LookupEquiryOrigion> LookupEquiryOrigions { get; set; }
        public virtual LookupEnquiryStatus LookupEnquiryStatus { get; set; }
    }
}
