﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumirsistemadetickets.wsreportes {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsreportes.reportesSoap")]
    public interface reportesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscartickets", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscartickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscartickets", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarticketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarescritorio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscarescritorio(int fecha1i, int fecha2f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarescritorio", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarescritorioAsync(int fecha1i, int fecha2f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface reportesSoapChannel : consumirsistemadetickets.wsreportes.reportesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class reportesSoapClient : System.ServiceModel.ClientBase<consumirsistemadetickets.wsreportes.reportesSoap>, consumirsistemadetickets.wsreportes.reportesSoap {
        
        public reportesSoapClient() {
        }
        
        public reportesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public reportesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public reportesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public reportesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet buscartickets() {
            return base.Channel.buscartickets();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarticketsAsync() {
            return base.Channel.buscarticketsAsync();
        }
        
        public System.Data.DataSet buscarescritorio(int fecha1i, int fecha2f) {
            return base.Channel.buscarescritorio(fecha1i, fecha2f);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarescritorioAsync(int fecha1i, int fecha2f) {
            return base.Channel.buscarescritorioAsync(fecha1i, fecha2f);
        }
    }
}