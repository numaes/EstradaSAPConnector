﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary1.Comprobantes_ABC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", ConfigurationName="Comprobantes_ABC.ZWS_COMPROBANTES_ABC")]
    public interface ZWS_COMPROBANTES_ABC {
        
        // CODEGEN: Generating message contract since the operation ZFI_RFC_COMPROBANTES_ABC is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_ABC:ZFI_RFC_COMPROBANTES_" +
            "ABCRequest", ReplyAction="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_ABC:ZFI_RFC_COMPROBANTES_" +
            "ABCResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1 ZFI_RFC_COMPROBANTES_ABC(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_ABC:ZFI_RFC_COMPROBANTES_" +
            "ABCRequest", ReplyAction="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_ABC:ZFI_RFC_COMPROBANTES_" +
            "ABCResponse")]
        System.Threading.Tasks.Task<WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1> ZFI_RFC_COMPROBANTES_ABCAsync(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZFI_RFC_COMPROBANTES_ABC1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string aCREEDORField;
        
        private string cAEField;
        
        private System.DateTime cAE_VTOField;
        
        private string cALLEField;
        
        private string cLASE_DOCField;
        
        private string cPOSTALField;
        
        private string cUITField;
        
        private System.DateTime fECHACONTField;
        
        private bool fECHACONTFieldSpecified;
        
        private System.DateTime fECHAFACTURAField;
        
        private decimal iMPORTEField;
        
        private string mONEDAField;
        
        private string nOMBREField;
        
        private string pAISField;
        
        private string pOBLACIONField;
        
        private string rEFERENCIAField;
        
        private string sOCIEDADField;
        
        private string tEXTOField;
        
        private string tIENDAField;
        
        private ZFI_RFC_COMPROBANTES_ABC[] t_DETALLEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ACREEDOR {
            get {
                return this.aCREEDORField;
            }
            set {
                this.aCREEDORField = value;
                this.RaisePropertyChanged("ACREEDOR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CAE {
            get {
                return this.cAEField;
            }
            set {
                this.cAEField = value;
                this.RaisePropertyChanged("CAE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime CAE_VTO {
            get {
                return this.cAE_VTOField;
            }
            set {
                this.cAE_VTOField = value;
                this.RaisePropertyChanged("CAE_VTO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string CALLE {
            get {
                return this.cALLEField;
            }
            set {
                this.cALLEField = value;
                this.RaisePropertyChanged("CALLE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CLASE_DOC {
            get {
                return this.cLASE_DOCField;
            }
            set {
                this.cLASE_DOCField = value;
                this.RaisePropertyChanged("CLASE_DOC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string CPOSTAL {
            get {
                return this.cPOSTALField;
            }
            set {
                this.cPOSTALField = value;
                this.RaisePropertyChanged("CPOSTAL");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string CUIT {
            get {
                return this.cUITField;
            }
            set {
                this.cUITField = value;
                this.RaisePropertyChanged("CUIT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=7)]
        public System.DateTime FECHACONT {
            get {
                return this.fECHACONTField;
            }
            set {
                this.fECHACONTField = value;
                this.RaisePropertyChanged("FECHACONT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FECHACONTSpecified {
            get {
                return this.fECHACONTFieldSpecified;
            }
            set {
                this.fECHACONTFieldSpecified = value;
                this.RaisePropertyChanged("FECHACONTSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=8)]
        public System.DateTime FECHAFACTURA {
            get {
                return this.fECHAFACTURAField;
            }
            set {
                this.fECHAFACTURAField = value;
                this.RaisePropertyChanged("FECHAFACTURA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public decimal IMPORTE {
            get {
                return this.iMPORTEField;
            }
            set {
                this.iMPORTEField = value;
                this.RaisePropertyChanged("IMPORTE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string MONEDA {
            get {
                return this.mONEDAField;
            }
            set {
                this.mONEDAField = value;
                this.RaisePropertyChanged("MONEDA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string NOMBRE {
            get {
                return this.nOMBREField;
            }
            set {
                this.nOMBREField = value;
                this.RaisePropertyChanged("NOMBRE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string PAIS {
            get {
                return this.pAISField;
            }
            set {
                this.pAISField = value;
                this.RaisePropertyChanged("PAIS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string POBLACION {
            get {
                return this.pOBLACIONField;
            }
            set {
                this.pOBLACIONField = value;
                this.RaisePropertyChanged("POBLACION");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string REFERENCIA {
            get {
                return this.rEFERENCIAField;
            }
            set {
                this.rEFERENCIAField = value;
                this.RaisePropertyChanged("REFERENCIA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string SOCIEDAD {
            get {
                return this.sOCIEDADField;
            }
            set {
                this.sOCIEDADField = value;
                this.RaisePropertyChanged("SOCIEDAD");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string TEXTO {
            get {
                return this.tEXTOField;
            }
            set {
                this.tEXTOField = value;
                this.RaisePropertyChanged("TEXTO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string TIENDA {
            get {
                return this.tIENDAField;
            }
            set {
                this.tIENDAField = value;
                this.RaisePropertyChanged("TIENDA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZFI_RFC_COMPROBANTES_ABC[] T_DETALLE {
            get {
                return this.t_DETALLEField;
            }
            set {
                this.t_DETALLEField = value;
                this.RaisePropertyChanged("T_DETALLE");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZFI_RFC_COMPROBANTES_ABC : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cTA_CONTABLEField;
        
        private string iND_IMPField;
        
        private string cECOField;
        
        private decimal iMPORTEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CTA_CONTABLE {
            get {
                return this.cTA_CONTABLEField;
            }
            set {
                this.cTA_CONTABLEField = value;
                this.RaisePropertyChanged("CTA_CONTABLE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string IND_IMP {
            get {
                return this.iND_IMPField;
            }
            set {
                this.iND_IMPField = value;
                this.RaisePropertyChanged("IND_IMP");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CECO {
            get {
                return this.cECOField;
            }
            set {
                this.cECOField = value;
                this.RaisePropertyChanged("CECO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal IMPORTE {
            get {
                return this.iMPORTEField;
            }
            set {
                this.iMPORTEField = value;
                this.RaisePropertyChanged("IMPORTE");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZFI_RFC_COMPROBANTES_ABCResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string mENSAJEField;
        
        private string nRO_DOCField;
        
        private string rESULTADOField;
        
        private ZFI_RFC_COMPROBANTES_ABC[] t_DETALLEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MENSAJE {
            get {
                return this.mENSAJEField;
            }
            set {
                this.mENSAJEField = value;
                this.RaisePropertyChanged("MENSAJE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NRO_DOC {
            get {
                return this.nRO_DOCField;
            }
            set {
                this.nRO_DOCField = value;
                this.RaisePropertyChanged("NRO_DOC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string RESULTADO {
            get {
                return this.rESULTADOField;
            }
            set {
                this.rESULTADOField = value;
                this.RaisePropertyChanged("RESULTADO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZFI_RFC_COMPROBANTES_ABC[] T_DETALLE {
            get {
                return this.t_DETALLEField;
            }
            set {
                this.t_DETALLEField = value;
                this.RaisePropertyChanged("T_DETALLE");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZFI_RFC_COMPROBANTES_ABCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABC1 ZFI_RFC_COMPROBANTES_ABC;
        
        public ZFI_RFC_COMPROBANTES_ABCRequest() {
        }
        
        public ZFI_RFC_COMPROBANTES_ABCRequest(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABC1 ZFI_RFC_COMPROBANTES_ABC) {
            this.ZFI_RFC_COMPROBANTES_ABC = ZFI_RFC_COMPROBANTES_ABC;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZFI_RFC_COMPROBANTES_ABCResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse ZFI_RFC_COMPROBANTES_ABCResponse;
        
        public ZFI_RFC_COMPROBANTES_ABCResponse1() {
        }
        
        public ZFI_RFC_COMPROBANTES_ABCResponse1(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse ZFI_RFC_COMPROBANTES_ABCResponse) {
            this.ZFI_RFC_COMPROBANTES_ABCResponse = ZFI_RFC_COMPROBANTES_ABCResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZWS_COMPROBANTES_ABCChannel : WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZWS_COMPROBANTES_ABCClient : System.ServiceModel.ClientBase<WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC>, WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC {
        
        public ZWS_COMPROBANTES_ABCClient() {
        }
        
        public ZWS_COMPROBANTES_ABCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZWS_COMPROBANTES_ABCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_COMPROBANTES_ABCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_COMPROBANTES_ABCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1 WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC.ZFI_RFC_COMPROBANTES_ABC(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest request) {
            return base.Channel.ZFI_RFC_COMPROBANTES_ABC(request);
        }
        
        public WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse ZFI_RFC_COMPROBANTES_ABC(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABC1 ZFI_RFC_COMPROBANTES_ABC1) {
            WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest inValue = new WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest();
            inValue.ZFI_RFC_COMPROBANTES_ABC = ZFI_RFC_COMPROBANTES_ABC1;
            WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1 retVal = ((WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC)(this)).ZFI_RFC_COMPROBANTES_ABC(inValue);
            return retVal.ZFI_RFC_COMPROBANTES_ABCResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1> WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC.ZFI_RFC_COMPROBANTES_ABCAsync(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest request) {
            return base.Channel.ZFI_RFC_COMPROBANTES_ABCAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCResponse1> ZFI_RFC_COMPROBANTES_ABCAsync(WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABC1 ZFI_RFC_COMPROBANTES_ABC) {
            WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest inValue = new WcfServiceLibrary1.Comprobantes_ABC.ZFI_RFC_COMPROBANTES_ABCRequest();
            inValue.ZFI_RFC_COMPROBANTES_ABC = ZFI_RFC_COMPROBANTES_ABC;
            return ((WcfServiceLibrary1.Comprobantes_ABC.ZWS_COMPROBANTES_ABC)(this)).ZFI_RFC_COMPROBANTES_ABCAsync(inValue);
        }
    }
}
