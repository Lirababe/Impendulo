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
    
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            this.Companies = new ObservableListSource<Company>();
            this.Individuals = new ObservableListSource<Individual>();
        }
    
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public int CountryID { get; set; }
        public int ProvinceID { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressTown { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressAreaCode { get; set; }
        public bool AddressIsDefault { get; set; }
        public System.DateTime AddressModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual LookupAddressType LookupAddressType { get; set; }
        public virtual LookupCountry LookupCountry { get; set; }
        public virtual LookupProvince LookupProvince { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Company> Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Individual> Individuals { get; set; }
    }
}
