﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACS.TouristTicket.WinApp.TicketAdminService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketAdminService.ITicketAdminService")]
    public interface ITicketAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketAdminService/DoWork", ReplyAction="http://tempuri.org/ITicketAdminService/DoWorkResponse")]
        void DoWork();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketAdminServiceChannel : ACS.TouristTicket.WinApp.TicketAdminService.ITicketAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketAdminServiceClient : System.ServiceModel.ClientBase<ACS.TouristTicket.WinApp.TicketAdminService.ITicketAdminService>, ACS.TouristTicket.WinApp.TicketAdminService.ITicketAdminService {
        
        public TicketAdminServiceClient() {
        }
        
        public TicketAdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketAdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketAdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketAdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
    }
}
