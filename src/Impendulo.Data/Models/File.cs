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
    
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            this.EnrollmentDocuments = new ObservableListSource<EnrollmentDocument>();
            this.EmailMessageRepositories = new ObservableListSource<EmailMessageRepository>();
            this.MessageTemplates = new ObservableListSource<MessageTemplate>();
            this.StudentIDDocuments = new ObservableListSource<StudentIDDocument>();
            this.StudentPhotos = new ObservableListSource<StudentPhoto>();
        }
    
        public int FileID { get; set; }
        public string ContentType { get; set; }
        public byte[] FileImage { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<EnrollmentDocument> EnrollmentDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<EmailMessageRepository> EmailMessageRepositories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<MessageTemplate> MessageTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<StudentIDDocument> StudentIDDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<StudentPhoto> StudentPhotos { get; set; }
    }
}
