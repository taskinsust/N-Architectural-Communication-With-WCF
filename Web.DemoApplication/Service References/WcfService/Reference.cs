﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.DemoApplication.WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MemberEntity", Namespace="http://schemas.datacontract.org/2004/07/WcfApi.DemoApplication.Entity")]
    [System.SerializableAttribute()]
    public partial class MemberEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNoField, value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfService.IMemberServices")]
    public interface IMemberServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/DoWork", ReplyAction="http://tempuri.org/IMemberServices/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/DoWork", ReplyAction="http://tempuri.org/IMemberServices/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Insert", ReplyAction="http://tempuri.org/IMemberServices/InsertResponse")]
        void Insert();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Insert", ReplyAction="http://tempuri.org/IMemberServices/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Update", ReplyAction="http://tempuri.org/IMemberServices/UpdateResponse")]
        void Update();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Update", ReplyAction="http://tempuri.org/IMemberServices/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Delete", ReplyAction="http://tempuri.org/IMemberServices/DeleteResponse")]
        void Delete();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/Delete", ReplyAction="http://tempuri.org/IMemberServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/GetAllMember", ReplyAction="http://tempuri.org/IMemberServices/GetAllMemberResponse")]
        Web.DemoApplication.WcfService.MemberEntity[] GetAllMember();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMemberServices/GetAllMember", ReplyAction="http://tempuri.org/IMemberServices/GetAllMemberResponse")]
        System.Threading.Tasks.Task<Web.DemoApplication.WcfService.MemberEntity[]> GetAllMemberAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMemberServicesChannel : Web.DemoApplication.WcfService.IMemberServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MemberServicesClient : System.ServiceModel.ClientBase<Web.DemoApplication.WcfService.IMemberServices>, Web.DemoApplication.WcfService.IMemberServices {
        
        public MemberServicesClient() {
        }
        
        public MemberServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MemberServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MemberServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MemberServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public void Insert() {
            base.Channel.Insert();
        }
        
        public System.Threading.Tasks.Task InsertAsync() {
            return base.Channel.InsertAsync();
        }
        
        public void Update() {
            base.Channel.Update();
        }
        
        public System.Threading.Tasks.Task UpdateAsync() {
            return base.Channel.UpdateAsync();
        }
        
        public void Delete() {
            base.Channel.Delete();
        }
        
        public System.Threading.Tasks.Task DeleteAsync() {
            return base.Channel.DeleteAsync();
        }
        
        public Web.DemoApplication.WcfService.MemberEntity[] GetAllMember() {
            return base.Channel.GetAllMember();
        }
        
        public System.Threading.Tasks.Task<Web.DemoApplication.WcfService.MemberEntity[]> GetAllMemberAsync() {
            return base.Channel.GetAllMemberAsync();
        }
    }
}
