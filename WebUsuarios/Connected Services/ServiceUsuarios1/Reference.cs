﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUsuarios.ServiceUsuarios1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuarios", Namespace="http://schemas.datacontract.org/2004/07/DataUsuarios")]
    [System.SerializableAttribute()]
    public partial class Usuarios : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public System.Nullable<System.DateTime> FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceUsuarios1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarUsuario", ReplyAction="http://tempuri.org/IService1/AgregarUsuarioResponse")]
        void AgregarUsuario(string name, System.DateTime fechaNacimiento, string sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarUsuario", ReplyAction="http://tempuri.org/IService1/AgregarUsuarioResponse")]
        System.Threading.Tasks.Task AgregarUsuarioAsync(string name, System.DateTime fechaNacimiento, string sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsuarios", ReplyAction="http://tempuri.org/IService1/GetUsuariosResponse")]
        WebUsuarios.ServiceUsuarios1.Usuarios[] GetUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsuarios", ReplyAction="http://tempuri.org/IService1/GetUsuariosResponse")]
        System.Threading.Tasks.Task<WebUsuarios.ServiceUsuarios1.Usuarios[]> GetUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebUsuarios.ServiceUsuarios1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebUsuarios.ServiceUsuarios1.IService1>, WebUsuarios.ServiceUsuarios1.IService1 {
        
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
        
        public void AgregarUsuario(string name, System.DateTime fechaNacimiento, string sexo) {
            base.Channel.AgregarUsuario(name, fechaNacimiento, sexo);
        }
        
        public System.Threading.Tasks.Task AgregarUsuarioAsync(string name, System.DateTime fechaNacimiento, string sexo) {
            return base.Channel.AgregarUsuarioAsync(name, fechaNacimiento, sexo);
        }
        
        public WebUsuarios.ServiceUsuarios1.Usuarios[] GetUsuarios() {
            return base.Channel.GetUsuarios();
        }
        
        public System.Threading.Tasks.Task<WebUsuarios.ServiceUsuarios1.Usuarios[]> GetUsuariosAsync() {
            return base.Channel.GetUsuariosAsync();
        }
    }
}
