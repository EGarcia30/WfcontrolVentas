﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WfControlVentas.wcfReporte {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TopVentas", Namespace="http://schemas.datacontract.org/2004/07/wcfReporte")]
    [System.SerializableAttribute()]
    public partial class TopVentas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantVentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
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
        public int cantVenta {
            get {
                return this.cantVentaField;
            }
            set {
                if ((this.cantVentaField.Equals(value) != true)) {
                    this.cantVentaField = value;
                    this.RaisePropertyChanged("cantVenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TopPago", Namespace="http://schemas.datacontract.org/2004/07/wcfReporte")]
    [System.SerializableAttribute()]
    public partial class TopPago : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float totalPagoField;
        
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
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float totalPago {
            get {
                return this.totalPagoField;
            }
            set {
                if ((this.totalPagoField.Equals(value) != true)) {
                    this.totalPagoField = value;
                    this.RaisePropertyChanged("totalPago");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="topMarca", Namespace="http://schemas.datacontract.org/2004/07/wcfReporte")]
    [System.SerializableAttribute()]
    public partial class topMarca : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string marcaField;
        
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
        public int cant {
            get {
                return this.cantField;
            }
            set {
                if ((this.cantField.Equals(value) != true)) {
                    this.cantField = value;
                    this.RaisePropertyChanged("cant");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string marca {
            get {
                return this.marcaField;
            }
            set {
                if ((object.ReferenceEquals(this.marcaField, value) != true)) {
                    this.marcaField = value;
                    this.RaisePropertyChanged("marca");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfReporte.IwcfReporte")]
    public interface IwcfReporte {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopVentas", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopVentasResponse")]
        WfControlVentas.wcfReporte.TopVentas[] mostrarTopVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopVentas", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopVentasResponse")]
        System.Threading.Tasks.Task<WfControlVentas.wcfReporte.TopVentas[]> mostrarTopVentasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopPago", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopPagoResponse")]
        WfControlVentas.wcfReporte.TopPago[] mostrarTopPago();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopPago", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopPagoResponse")]
        System.Threading.Tasks.Task<WfControlVentas.wcfReporte.TopPago[]> mostrarTopPagoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopMarca", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopMarcaResponse")]
        WfControlVentas.wcfReporte.topMarca[] mostrarTopMarca();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfReporte/mostrarTopMarca", ReplyAction="http://tempuri.org/IwcfReporte/mostrarTopMarcaResponse")]
        System.Threading.Tasks.Task<WfControlVentas.wcfReporte.topMarca[]> mostrarTopMarcaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwcfReporteChannel : WfControlVentas.wcfReporte.IwcfReporte, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwcfReporteClient : System.ServiceModel.ClientBase<WfControlVentas.wcfReporte.IwcfReporte>, WfControlVentas.wcfReporte.IwcfReporte {
        
        public IwcfReporteClient() {
        }
        
        public IwcfReporteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwcfReporteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfReporteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfReporteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WfControlVentas.wcfReporte.TopVentas[] mostrarTopVentas() {
            return base.Channel.mostrarTopVentas();
        }
        
        public System.Threading.Tasks.Task<WfControlVentas.wcfReporte.TopVentas[]> mostrarTopVentasAsync() {
            return base.Channel.mostrarTopVentasAsync();
        }
        
        public WfControlVentas.wcfReporte.TopPago[] mostrarTopPago() {
            return base.Channel.mostrarTopPago();
        }
        
        public System.Threading.Tasks.Task<WfControlVentas.wcfReporte.TopPago[]> mostrarTopPagoAsync() {
            return base.Channel.mostrarTopPagoAsync();
        }
        
        public WfControlVentas.wcfReporte.topMarca[] mostrarTopMarca() {
            return base.Channel.mostrarTopMarca();
        }
        
        public System.Threading.Tasks.Task<WfControlVentas.wcfReporte.topMarca[]> mostrarTopMarcaAsync() {
            return base.Channel.mostrarTopMarcaAsync();
        }
    }
}
