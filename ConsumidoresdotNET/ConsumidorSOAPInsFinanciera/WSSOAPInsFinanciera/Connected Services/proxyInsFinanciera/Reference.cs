﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSSOAPInsFinanciera.proxyInsFinanciera {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoPago", Namespace="http://schemas.datacontract.org/2004/07/WcfInsFinanciera")]
    [System.SerializableAttribute()]
    public partial class InfoPago : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoDocumentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.contraseñaField, value) != true)) {
                    this.contraseñaField = value;
                    this.RaisePropertyChanged("contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numDocumento {
            get {
                return this.numDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.numDocumentoField, value) != true)) {
                    this.numDocumentoField = value;
                    this.RaisePropertyChanged("numDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipoDocumento {
            get {
                return this.tipoDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoDocumentoField, value) != true)) {
                    this.tipoDocumentoField = value;
                    this.RaisePropertyChanged("tipoDocumento");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comprobante", Namespace="http://schemas.datacontract.org/2004/07/InstitucionFinanciera.Models")]
    [System.SerializableAttribute()]
    public partial class Comprobante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aprobacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numAprobacionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aprobacion {
            get {
                return this.aprobacionField;
            }
            set {
                if ((object.ReferenceEquals(this.aprobacionField, value) != true)) {
                    this.aprobacionField = value;
                    this.RaisePropertyChanged("aprobacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numAprobacion {
            get {
                return this.numAprobacionField;
            }
            set {
                if ((object.ReferenceEquals(this.numAprobacionField, value) != true)) {
                    this.numAprobacionField = value;
                    this.RaisePropertyChanged("numAprobacion");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="proxyInsFinanciera.ISOAPInsFinanciera")]
    public interface ISOAPInsFinanciera {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOAPInsFinanciera/DoWork", ReplyAction="http://tempuri.org/ISOAPInsFinanciera/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOAPInsFinanciera/DoWork", ReplyAction="http://tempuri.org/ISOAPInsFinanciera/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOAPInsFinanciera/validar", ReplyAction="http://tempuri.org/ISOAPInsFinanciera/validarResponse")]
        WSSOAPInsFinanciera.proxyInsFinanciera.Comprobante validar(WSSOAPInsFinanciera.proxyInsFinanciera.InfoPago infoPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISOAPInsFinanciera/validar", ReplyAction="http://tempuri.org/ISOAPInsFinanciera/validarResponse")]
        System.Threading.Tasks.Task<WSSOAPInsFinanciera.proxyInsFinanciera.Comprobante> validarAsync(WSSOAPInsFinanciera.proxyInsFinanciera.InfoPago infoPago);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISOAPInsFinancieraChannel : WSSOAPInsFinanciera.proxyInsFinanciera.ISOAPInsFinanciera, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SOAPInsFinancieraClient : System.ServiceModel.ClientBase<WSSOAPInsFinanciera.proxyInsFinanciera.ISOAPInsFinanciera>, WSSOAPInsFinanciera.proxyInsFinanciera.ISOAPInsFinanciera {
        
        public SOAPInsFinancieraClient() {
        }
        
        public SOAPInsFinancieraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SOAPInsFinancieraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPInsFinancieraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPInsFinancieraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public WSSOAPInsFinanciera.proxyInsFinanciera.Comprobante validar(WSSOAPInsFinanciera.proxyInsFinanciera.InfoPago infoPago) {
            return base.Channel.validar(infoPago);
        }
        
        public System.Threading.Tasks.Task<WSSOAPInsFinanciera.proxyInsFinanciera.Comprobante> validarAsync(WSSOAPInsFinanciera.proxyInsFinanciera.InfoPago infoPago) {
            return base.Channel.validarAsync(infoPago);
        }
    }
}
