﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumirsistemadetickets.wsusuarioc {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsusuarioc.wsusuarioSoap")]
    public interface wsusuarioSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_de_usuarios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listado_de_usuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listado_de_usuarios", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listado_de_usuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet usuario(string idUsuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> usuarioAsync(string idUsuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_un_usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertar_un_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_un_usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertar_un_usuarioAsync(string idUsuario, string carne, int idEmpleado, string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizacion_de_usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int actualizacion_de_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizacion_de_usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<int> actualizacion_de_usuarioAsync(string idUsuario, string carne, int idEmpleado, string correo, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_un_usuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int eliminar_un_usuario(string idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_un_usuario", ReplyAction="*")]
        System.Threading.Tasks.Task<int> eliminar_un_usuarioAsync(string idUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsusuarioSoapChannel : consumirsistemadetickets.wsusuarioc.wsusuarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsusuarioSoapClient : System.ServiceModel.ClientBase<consumirsistemadetickets.wsusuarioc.wsusuarioSoap>, consumirsistemadetickets.wsusuarioc.wsusuarioSoap {
        
        public wsusuarioSoapClient() {
        }
        
        public wsusuarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsusuarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsusuarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsusuarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listado_de_usuarios() {
            return base.Channel.listado_de_usuarios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listado_de_usuariosAsync() {
            return base.Channel.listado_de_usuariosAsync();
        }
        
        public System.Data.DataSet usuario(string idUsuario, string password) {
            return base.Channel.usuario(idUsuario, password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> usuarioAsync(string idUsuario, string password) {
            return base.Channel.usuarioAsync(idUsuario, password);
        }
        
        public int insertar_un_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password) {
            return base.Channel.insertar_un_usuario(idUsuario, carne, idEmpleado, correo, password);
        }
        
        public System.Threading.Tasks.Task<int> insertar_un_usuarioAsync(string idUsuario, string carne, int idEmpleado, string correo, string password) {
            return base.Channel.insertar_un_usuarioAsync(idUsuario, carne, idEmpleado, correo, password);
        }
        
        public int actualizacion_de_usuario(string idUsuario, string carne, int idEmpleado, string correo, string password) {
            return base.Channel.actualizacion_de_usuario(idUsuario, carne, idEmpleado, correo, password);
        }
        
        public System.Threading.Tasks.Task<int> actualizacion_de_usuarioAsync(string idUsuario, string carne, int idEmpleado, string correo, string password) {
            return base.Channel.actualizacion_de_usuarioAsync(idUsuario, carne, idEmpleado, correo, password);
        }
        
        public int eliminar_un_usuario(string idUsuario) {
            return base.Channel.eliminar_un_usuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task<int> eliminar_un_usuarioAsync(string idUsuario) {
            return base.Channel.eliminar_un_usuarioAsync(idUsuario);
        }
    }
}