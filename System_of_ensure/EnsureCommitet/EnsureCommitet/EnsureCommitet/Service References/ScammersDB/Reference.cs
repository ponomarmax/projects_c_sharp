﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnsureCommitet.ScammersDB {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ScammersDB.IScammersDB")]
    public interface IScammersDB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScammersDB/CheckUser", ReplyAction="http://tempuri.org/IScammersDB/CheckUserResponse")]
        bool CheckUser(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScammersDB/CheckUser", ReplyAction="http://tempuri.org/IScammersDB/CheckUserResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAsync(string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScammersDBChannel : EnsureCommitet.ScammersDB.IScammersDB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScammersDBClient : System.ServiceModel.ClientBase<EnsureCommitet.ScammersDB.IScammersDB>, EnsureCommitet.ScammersDB.IScammersDB {
        
        public ScammersDBClient() {
        }
        
        public ScammersDBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScammersDBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScammersDBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScammersDBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckUser(string user) {
            return base.Channel.CheckUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAsync(string user) {
            return base.Channel.CheckUserAsync(user);
        }
    }
}
