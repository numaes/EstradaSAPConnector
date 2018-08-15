
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
    
public partial class SAPC_Facturas
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SAPC_Facturas()
    {

        this.SAPC_HistFacturas = new HashSet<SAPC_HistFacturas>();

    }


    public int FacturaID { get; set; }

    public Nullable<int> InstanceID { get; set; }

    public int TipoFacturaID { get; set; }

    public string Referencia { get; set; }

    public System.DateTime Fecha { get; set; }

    public int ProveedorID { get; set; }

    public string Concepto { get; set; }

    public Nullable<decimal> NetoGravado { get; set; }

    public Nullable<decimal> IVA27 { get; set; }

    public Nullable<decimal> IVA21 { get; set; }

    public Nullable<decimal> IVA105 { get; set; }

    public Nullable<decimal> IVA5 { get; set; }

    public Nullable<decimal> IVA25 { get; set; }

    public Nullable<decimal> IVA0 { get; set; }

    public Nullable<decimal> PerDeIVA { get; set; }

    public Nullable<decimal> PerIngresosBrutos { get; set; }

    public Nullable<decimal> NoGravados { get; set; }

    public decimal Total { get; set; }

    public int CuentaID { get; set; }

    public System.DateTime FechaContabilizacion { get; set; }

    public int CeCoID { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<int> ModificadoPor { get; set; }

    public Nullable<System.DateTime> FechaModificacion { get; set; }

    public Nullable<int> StateCode { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SAPC_HistFacturas> SAPC_HistFacturas { get; set; }

}

}