//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace TSP.EntityLayer
{
    using System;
    using System.Collections.Generic;
    [DataContract(IsReference = true)]
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Performers = new HashSet<Performer>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public System.Guid FestivalId { get; set; }
        [DataMember]
        public Festival Festival { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Performer> Performers { get; set; }
    }
}
