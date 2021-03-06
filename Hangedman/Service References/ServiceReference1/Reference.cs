﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangedman.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_Game", ConfigurationName="ServiceReference1.ECCI_GamePort")]
    public interface ECCI_GamePort {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getAnswer", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getAnswer();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getAnswer", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getAnswerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#resetGame", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void resetGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#resetGame", ReplyAction="*")]
        System.Threading.Tasks.Task resetGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getWord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getWord();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getWord", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getWordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getTries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTries();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getTries", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getTriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#generateWord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string generateWord();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#generateWord", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> generateWordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#checkWord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string checkWord(string character);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#checkWord", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> checkWordAsync(string character);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getRecords", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getRecords", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#checkRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void checkRecord(string newPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#checkRecord", ReplyAction="*")]
        System.Threading.Tasks.Task checkRecordAsync(string newPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Game#Game#getTime", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getTimeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_GamePortChannel : Hangedman.ServiceReference1.ECCI_GamePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_GamePortClient : System.ServiceModel.ClientBase<Hangedman.ServiceReference1.ECCI_GamePort>, Hangedman.ServiceReference1.ECCI_GamePort {
        
        public ECCI_GamePortClient() {
        }
        
        public ECCI_GamePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_GamePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_GamePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_GamePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getAnswer() {
            return base.Channel.getAnswer();
        }
        
        public System.Threading.Tasks.Task<string> getAnswerAsync() {
            return base.Channel.getAnswerAsync();
        }
        
        public void resetGame() {
            base.Channel.resetGame();
        }
        
        public System.Threading.Tasks.Task resetGameAsync() {
            return base.Channel.resetGameAsync();
        }
        
        public string getWord() {
            return base.Channel.getWord();
        }
        
        public System.Threading.Tasks.Task<string> getWordAsync() {
            return base.Channel.getWordAsync();
        }
        
        public string getTries() {
            return base.Channel.getTries();
        }
        
        public System.Threading.Tasks.Task<string> getTriesAsync() {
            return base.Channel.getTriesAsync();
        }
        
        public string generateWord() {
            return base.Channel.generateWord();
        }
        
        public System.Threading.Tasks.Task<string> generateWordAsync() {
            return base.Channel.generateWordAsync();
        }
        
        public string checkWord(string character) {
            return base.Channel.checkWord(character);
        }
        
        public System.Threading.Tasks.Task<string> checkWordAsync(string character) {
            return base.Channel.checkWordAsync(character);
        }
        
        public string getRecords() {
            return base.Channel.getRecords();
        }
        
        public System.Threading.Tasks.Task<string> getRecordsAsync() {
            return base.Channel.getRecordsAsync();
        }
        
        public void checkRecord(string newPlayer) {
            base.Channel.checkRecord(newPlayer);
        }
        
        public System.Threading.Tasks.Task checkRecordAsync(string newPlayer) {
            return base.Channel.checkRecordAsync(newPlayer);
        }
        
        public string getTime() {
            return base.Channel.getTime();
        }
        
        public System.Threading.Tasks.Task<string> getTimeAsync() {
            return base.Channel.getTimeAsync();
        }
    }
}
