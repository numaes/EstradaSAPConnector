﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAPConnectorLibrary.Comprobantes_NO_ABC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", ConfigurationName="Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC")]
    public interface ZWS_COMPROBANTES_NO_ABC {
        
        // CODEGEN: Generating message contract since the operation ZFI_RFC_COMPROBANTES_NO_ABC is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_NO_ABC:ZFI_RFC_COMPROBANT" +
            "ES_NO_ABCRequest", ReplyAction="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_NO_ABC:ZFI_RFC_COMPROBANT" +
            "ES_NO_ABCResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1 ZFI_RFC_COMPROBANTES_NO_ABC(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_NO_ABC:ZFI_RFC_COMPROBANT" +
            "ES_NO_ABCRequest", ReplyAction="urn:sap-com:document:sap:rfc:functions:ZWS_COMPROBANTES_NO_ABC:ZFI_RFC_COMPROBANT" +
            "ES_NO_ABCResponse")]
        System.Threading.Tasks.Task<SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1> ZFI_RFC_COMPROBANTES_NO_ABCAsync(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZFI_RFC_COMPROBANTES_NO_ABC1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cLASE_DOCField;
        
        private ZFI_RFC_COMPROBANTES_NO_ABC[] cUENTASField;
        
        private string dOC_COMP1Field;
        
        private string dOC_COMP10Field;
        
        private string dOC_COMP11Field;
        
        private string dOC_COMP2Field;
        
        private string dOC_COMP3Field;
        
        private string dOC_COMP4Field;
        
        private string dOC_COMP5Field;
        
        private string dOC_COMP6Field;
        
        private string dOC_COMP7Field;
        
        private string dOC_COMP8Field;
        
        private string dOC_COMP9Field;
        
        private System.DateTime fECHACONTField;
        
        private bool fECHACONTFieldSpecified;
        
        private System.DateTime fECHADOCUMENTOField;
        
        private string mONEDAField;
        
        private string rEFERENCIAField;
        
        private string sOCIEDADField;
        
        private string tIENDAField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZFI_RFC_COMPROBANTES_NO_ABC[] CUENTAS {
            get {
                return this.cUENTASField;
            }
            set {
                this.cUENTASField = value;
                this.RaisePropertyChanged("CUENTAS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string DOC_COMP1 {
            get {
                return this.dOC_COMP1Field;
            }
            set {
                this.dOC_COMP1Field = value;
                this.RaisePropertyChanged("DOC_COMP1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string DOC_COMP10 {
            get {
                return this.dOC_COMP10Field;
            }
            set {
                this.dOC_COMP10Field = value;
                this.RaisePropertyChanged("DOC_COMP10");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string DOC_COMP11 {
            get {
                return this.dOC_COMP11Field;
            }
            set {
                this.dOC_COMP11Field = value;
                this.RaisePropertyChanged("DOC_COMP11");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string DOC_COMP2 {
            get {
                return this.dOC_COMP2Field;
            }
            set {
                this.dOC_COMP2Field = value;
                this.RaisePropertyChanged("DOC_COMP2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string DOC_COMP3 {
            get {
                return this.dOC_COMP3Field;
            }
            set {
                this.dOC_COMP3Field = value;
                this.RaisePropertyChanged("DOC_COMP3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string DOC_COMP4 {
            get {
                return this.dOC_COMP4Field;
            }
            set {
                this.dOC_COMP4Field = value;
                this.RaisePropertyChanged("DOC_COMP4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string DOC_COMP5 {
            get {
                return this.dOC_COMP5Field;
            }
            set {
                this.dOC_COMP5Field = value;
                this.RaisePropertyChanged("DOC_COMP5");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string DOC_COMP6 {
            get {
                return this.dOC_COMP6Field;
            }
            set {
                this.dOC_COMP6Field = value;
                this.RaisePropertyChanged("DOC_COMP6");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string DOC_COMP7 {
            get {
                return this.dOC_COMP7Field;
            }
            set {
                this.dOC_COMP7Field = value;
                this.RaisePropertyChanged("DOC_COMP7");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string DOC_COMP8 {
            get {
                return this.dOC_COMP8Field;
            }
            set {
                this.dOC_COMP8Field = value;
                this.RaisePropertyChanged("DOC_COMP8");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string DOC_COMP9 {
            get {
                return this.dOC_COMP9Field;
            }
            set {
                this.dOC_COMP9Field = value;
                this.RaisePropertyChanged("DOC_COMP9");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=14)]
        public System.DateTime FECHADOCUMENTO {
            get {
                return this.fECHADOCUMENTOField;
            }
            set {
                this.fECHADOCUMENTOField = value;
                this.RaisePropertyChanged("FECHADOCUMENTO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string TIENDA {
            get {
                return this.tIENDAField;
            }
            set {
                this.tIENDAField = value;
                this.RaisePropertyChanged("TIENDA");
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
    public partial class ZFI_RFC_COMPROBANTES_NO_ABC : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cLAVE_CTField;
        
        private string cTA_CONTABLE1Field;
        
        private decimal iMPORTEField;
        
        private string tEXTOSField;
        
        private string iND_IMPField;
        
        private string cECOField;
        
        private string tEXTOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CLAVE_CT {
            get {
                return this.cLAVE_CTField;
            }
            set {
                this.cLAVE_CTField = value;
                this.RaisePropertyChanged("CLAVE_CT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CTA_CONTABLE1 {
            get {
                return this.cTA_CONTABLE1Field;
            }
            set {
                this.cTA_CONTABLE1Field = value;
                this.RaisePropertyChanged("CTA_CONTABLE1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TEXTOS {
            get {
                return this.tEXTOSField;
            }
            set {
                this.tEXTOSField = value;
                this.RaisePropertyChanged("TEXTOS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string TEXTO {
            get {
                return this.tEXTOField;
            }
            set {
                this.tEXTOField = value;
                this.RaisePropertyChanged("TEXTO");
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
    public partial class ZFI_RFC_COMPROBANTES_NO_ABCResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ZFI_RFC_COMPROBANTES_NO_ABC[] cUENTASField;
        
        private string mENSAJEField;
        
        private string nRO_DOCField;
        
        private string rESULTADOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZFI_RFC_COMPROBANTES_NO_ABC[] CUENTAS {
            get {
                return this.cUENTASField;
            }
            set {
                this.cUENTASField = value;
                this.RaisePropertyChanged("CUENTAS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string RESULTADO {
            get {
                return this.rESULTADOField;
            }
            set {
                this.rESULTADOField = value;
                this.RaisePropertyChanged("RESULTADO");
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
    public partial class ZFI_RFC_COMPROBANTES_NO_ABCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABC1 ZFI_RFC_COMPROBANTES_NO_ABC;
        
        public ZFI_RFC_COMPROBANTES_NO_ABCRequest() {
        }
        
        public ZFI_RFC_COMPROBANTES_NO_ABCRequest(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABC1 ZFI_RFC_COMPROBANTES_NO_ABC) {
            this.ZFI_RFC_COMPROBANTES_NO_ABC = ZFI_RFC_COMPROBANTES_NO_ABC;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZFI_RFC_COMPROBANTES_NO_ABCResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse ZFI_RFC_COMPROBANTES_NO_ABCResponse;
        
        public ZFI_RFC_COMPROBANTES_NO_ABCResponse1() {
        }
        
        public ZFI_RFC_COMPROBANTES_NO_ABCResponse1(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse ZFI_RFC_COMPROBANTES_NO_ABCResponse) {
            this.ZFI_RFC_COMPROBANTES_NO_ABCResponse = ZFI_RFC_COMPROBANTES_NO_ABCResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZWS_COMPROBANTES_NO_ABCChannel : SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZWS_COMPROBANTES_NO_ABCClient : System.ServiceModel.ClientBase<SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC>, SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC {
        
        public ZWS_COMPROBANTES_NO_ABCClient() {
        }
        
        public ZWS_COMPROBANTES_NO_ABCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZWS_COMPROBANTES_NO_ABCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_COMPROBANTES_NO_ABCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_COMPROBANTES_NO_ABCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1 SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABC(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest request) {
            return base.Channel.ZFI_RFC_COMPROBANTES_NO_ABC(request);
        }
        
        public SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse ZFI_RFC_COMPROBANTES_NO_ABC(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABC1 ZFI_RFC_COMPROBANTES_NO_ABC1) {
            SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest inValue = new SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest();
            inValue.ZFI_RFC_COMPROBANTES_NO_ABC = ZFI_RFC_COMPROBANTES_NO_ABC1;
            SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1 retVal = ((SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC)(this)).ZFI_RFC_COMPROBANTES_NO_ABC(inValue);
            return retVal.ZFI_RFC_COMPROBANTES_NO_ABCResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1> SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCAsync(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest request) {
            return base.Channel.ZFI_RFC_COMPROBANTES_NO_ABCAsync(request);
        }
        
        public System.Threading.Tasks.Task<SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCResponse1> ZFI_RFC_COMPROBANTES_NO_ABCAsync(SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABC1 ZFI_RFC_COMPROBANTES_NO_ABC) {
            SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest inValue = new SAPConnectorLibrary.Comprobantes_NO_ABC.ZFI_RFC_COMPROBANTES_NO_ABCRequest();
            inValue.ZFI_RFC_COMPROBANTES_NO_ABC = ZFI_RFC_COMPROBANTES_NO_ABC;
            return ((SAPConnectorLibrary.Comprobantes_NO_ABC.ZWS_COMPROBANTES_NO_ABC)(this)).ZFI_RFC_COMPROBANTES_NO_ABCAsync(inValue);
        }
    }
}
