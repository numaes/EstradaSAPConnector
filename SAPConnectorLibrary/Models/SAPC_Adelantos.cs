//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAPConnectorLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAPC_Adelantos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAPC_Adelantos()
        {
            this.SAPRPCCall = new HashSet<SAPC_SAPRPCCall>();
        }
    
        public int Id { get; set; }
        public string SAPId { get; set; }
        public System.DateTime PedidoEl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAPC_SAPRPCCall> SAPRPCCall { get; set; }
        public virtual SAPC_FondoFijo FondoFijo { get; set; }
    }
}