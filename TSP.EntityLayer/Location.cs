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
    public partial class Location
    {
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Capacity { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Festival Festival { get; set; }
    }
}
