﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteServicioV2._0.circleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RingDTO", Namespace="http://schemas.datacontract.org/2004/07/WebServiceApp.DTO")]
    [System.SerializableAttribute()]
    public partial class RingDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PerimeterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> RadiusField;
        
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
        public System.Nullable<double> Area {
            get {
                return this.AreaField;
            }
            set {
                if ((this.AreaField.Equals(value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Perimeter {
            get {
                return this.PerimeterField;
            }
            set {
                if ((this.PerimeterField.Equals(value) != true)) {
                    this.PerimeterField = value;
                    this.RaisePropertyChanged("Perimeter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Radius {
            get {
                return this.RadiusField;
            }
            set {
                if ((this.RadiusField.Equals(value) != true)) {
                    this.RadiusField = value;
                    this.RaisePropertyChanged("Radius");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ring", Namespace="http://schemas.datacontract.org/2004/07/WebServiceApp.Models")]
    [System.SerializableAttribute()]
    public partial class Ring : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PerimeterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> RadiusField;
        
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
        public System.Nullable<double> Area {
            get {
                return this.AreaField;
            }
            set {
                if ((this.AreaField.Equals(value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Perimeter {
            get {
                return this.PerimeterField;
            }
            set {
                if ((this.PerimeterField.Equals(value) != true)) {
                    this.PerimeterField = value;
                    this.RaisePropertyChanged("Perimeter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Radius {
            get {
                return this.RadiusField;
            }
            set {
                if ((this.RadiusField.Equals(value) != true)) {
                    this.RadiusField = value;
                    this.RaisePropertyChanged("Radius");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="circleService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListRings", ReplyAction="http://tempuri.org/IService1/ListRingsResponse")]
        ClienteServicioV2._0.circleService.RingDTO[] ListRings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListRings", ReplyAction="http://tempuri.org/IService1/ListRingsResponse")]
        System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.RingDTO[]> ListRingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateRing", ReplyAction="http://tempuri.org/IService1/CreateRingResponse")]
        ClienteServicioV2._0.circleService.Ring CreateRing(ClienteServicioV2._0.circleService.RingDTO Ring);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateRing", ReplyAction="http://tempuri.org/IService1/CreateRingResponse")]
        System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.Ring> CreateRingAsync(ClienteServicioV2._0.circleService.RingDTO Ring);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRingById", ReplyAction="http://tempuri.org/IService1/GetRingByIdResponse")]
        ClienteServicioV2._0.circleService.RingDTO GetRingById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRingById", ReplyAction="http://tempuri.org/IService1/GetRingByIdResponse")]
        System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.RingDTO> GetRingByIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClienteServicioV2._0.circleService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClienteServicioV2._0.circleService.IService1>, ClienteServicioV2._0.circleService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteServicioV2._0.circleService.RingDTO[] ListRings() {
            return base.Channel.ListRings();
        }
        
        public System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.RingDTO[]> ListRingsAsync() {
            return base.Channel.ListRingsAsync();
        }
        
        public ClienteServicioV2._0.circleService.Ring CreateRing(ClienteServicioV2._0.circleService.RingDTO Ring) {
            return base.Channel.CreateRing(Ring);
        }
        
        public System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.Ring> CreateRingAsync(ClienteServicioV2._0.circleService.RingDTO Ring) {
            return base.Channel.CreateRingAsync(Ring);
        }
        
        public ClienteServicioV2._0.circleService.RingDTO GetRingById(int Id) {
            return base.Channel.GetRingById(Id);
        }
        
        public System.Threading.Tasks.Task<ClienteServicioV2._0.circleService.RingDTO> GetRingByIdAsync(int Id) {
            return base.Channel.GetRingByIdAsync(Id);
        }
    }
}
