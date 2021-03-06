﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TVCable_manager.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ctvcentral.vipserv.org/soap", ConfigurationName="ServiceReference.CTVBackendPort")]
    public interface CTVBackendPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#getOffers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TVCable_manager.ServiceReference.tvOffer[] getOffers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#getOffers", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<TVCable_manager.ServiceReference.tvOffer[]> getOffersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#addOffer", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool addOffer(TVCable_manager.ServiceReference.tvOffer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#addOffer", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> addOfferAsync(TVCable_manager.ServiceReference.tvOffer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#updateOffer", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool updateOffer(TVCable_manager.ServiceReference.tvOffer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#updateOffer", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> updateOfferAsync(TVCable_manager.ServiceReference.tvOffer offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#removeOffer", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool removeOffer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ctvcentral.vipserv.org/soap#removeOffer", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> removeOfferAsync(int id);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2114.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ctvcentral.vipserv.org/soap")]
    public partial class tvOffer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> idField;
        
        private System.Nullable<double> offerActivationPriceField;
        
        private string offerCurrencyField;
        
        private string offerDescriptionField;
        
        private System.Nullable<int> offerMonthlyLengthField;
        
        private System.Nullable<double> offerMonthlyPriceField;
        
        private string offerNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<double> offerActivationPrice {
            get {
                return this.offerActivationPriceField;
            }
            set {
                this.offerActivationPriceField = value;
                this.RaisePropertyChanged("offerActivationPrice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string offerCurrency {
            get {
                return this.offerCurrencyField;
            }
            set {
                this.offerCurrencyField = value;
                this.RaisePropertyChanged("offerCurrency");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string offerDescription {
            get {
                return this.offerDescriptionField;
            }
            set {
                this.offerDescriptionField = value;
                this.RaisePropertyChanged("offerDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> offerMonthlyLength {
            get {
                return this.offerMonthlyLengthField;
            }
            set {
                this.offerMonthlyLengthField = value;
                this.RaisePropertyChanged("offerMonthlyLength");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<double> offerMonthlyPrice {
            get {
                return this.offerMonthlyPriceField;
            }
            set {
                this.offerMonthlyPriceField = value;
                this.RaisePropertyChanged("offerMonthlyPrice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string offerName {
            get {
                return this.offerNameField;
            }
            set {
                this.offerNameField = value;
                this.RaisePropertyChanged("offerName");
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
    public interface CTVBackendPortChannel : TVCable_manager.ServiceReference.CTVBackendPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CTVBackendPortClient : System.ServiceModel.ClientBase<TVCable_manager.ServiceReference.CTVBackendPort>, TVCable_manager.ServiceReference.CTVBackendPort {
        
        public CTVBackendPortClient() {
        }
        
        public CTVBackendPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CTVBackendPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CTVBackendPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CTVBackendPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TVCable_manager.ServiceReference.tvOffer[] getOffers() {
            return base.Channel.getOffers();
        }
        
        public System.Threading.Tasks.Task<TVCable_manager.ServiceReference.tvOffer[]> getOffersAsync() {
            return base.Channel.getOffersAsync();
        }
        
        public bool addOffer(TVCable_manager.ServiceReference.tvOffer offer) {
            return base.Channel.addOffer(offer);
        }
        
        public System.Threading.Tasks.Task<bool> addOfferAsync(TVCable_manager.ServiceReference.tvOffer offer) {
            return base.Channel.addOfferAsync(offer);
        }
        
        public bool updateOffer(TVCable_manager.ServiceReference.tvOffer offer) {
            return base.Channel.updateOffer(offer);
        }
        
        public System.Threading.Tasks.Task<bool> updateOfferAsync(TVCable_manager.ServiceReference.tvOffer offer) {
            return base.Channel.updateOfferAsync(offer);
        }
        
        public bool removeOffer(int id) {
            return base.Channel.removeOffer(id);
        }
        
        public System.Threading.Tasks.Task<bool> removeOfferAsync(int id) {
            return base.Channel.removeOfferAsync(id);
        }
    }
}
