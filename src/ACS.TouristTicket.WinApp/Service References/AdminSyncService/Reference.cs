﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACS.TouristTicket.WinApp.AdminSyncService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminSyncService.ISyncService")]
    public interface ISyncService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/GetUpSyncData", ReplyAction="http://tempuri.org/ISyncService/GetUpSyncDataResponse")]
        ACS.TouristTicket.Model.ACSSyncData GetUpSyncData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/UpdateLastUpSyncDate", ReplyAction="http://tempuri.org/ISyncService/UpdateLastUpSyncDateResponse")]
        void UpdateLastUpSyncDate(ACS.TouristTicket.Model.ACSSyncData syncData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/GetDownSyncData", ReplyAction="http://tempuri.org/ISyncService/GetDownSyncDataResponse")]
        ACS.TouristTicket.Model.ACSSyncData GetDownSyncData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/UpdateLastDownSyncDate", ReplyAction="http://tempuri.org/ISyncService/UpdateLastDownSyncDateResponse")]
        void UpdateLastDownSyncDate(ACS.TouristTicket.Model.ACSSyncData syncData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/SyncData", ReplyAction="http://tempuri.org/ISyncService/SyncDataResponse")]
        ACS.TouristTicket.Model.ACSSyncData SyncData([System.ServiceModel.MessageParameterAttribute(Name="syncData")] ACS.TouristTicket.Model.ACSSyncData syncData1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISyncServiceChannel : ACS.TouristTicket.WinApp.AdminSyncService.ISyncService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SyncServiceClient : System.ServiceModel.ClientBase<ACS.TouristTicket.WinApp.AdminSyncService.ISyncService>, ACS.TouristTicket.WinApp.AdminSyncService.ISyncService {
        
        public SyncServiceClient() {
        }
        
        public SyncServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SyncServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ACS.TouristTicket.Model.ACSSyncData GetUpSyncData() {
            return base.Channel.GetUpSyncData();
        }
        
        public void UpdateLastUpSyncDate(ACS.TouristTicket.Model.ACSSyncData syncData) {
            base.Channel.UpdateLastUpSyncDate(syncData);
        }
        
        public ACS.TouristTicket.Model.ACSSyncData GetDownSyncData() {
            return base.Channel.GetDownSyncData();
        }
        
        public void UpdateLastDownSyncDate(ACS.TouristTicket.Model.ACSSyncData syncData) {
            base.Channel.UpdateLastDownSyncDate(syncData);
        }
        
        public ACS.TouristTicket.Model.ACSSyncData SyncData(ACS.TouristTicket.Model.ACSSyncData syncData1) {
            return base.Channel.SyncData(syncData1);
        }
    }
}
