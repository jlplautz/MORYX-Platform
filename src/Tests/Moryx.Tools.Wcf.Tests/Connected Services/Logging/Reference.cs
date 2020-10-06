﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moryx.Tools.Wcf.Tests.Logging
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoggerModel", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins.Logging" +
        "")]
    public partial class LoggerModel : object
    {
        
        private Moryx.Tools.Wcf.Tests.Logging.LogLevel ActiveLevelField;
        
        private Moryx.Tools.Wcf.Tests.Logging.LoggerModel[] ChildLoggerField;
        
        private string NameField;
        
        private Moryx.Tools.Wcf.Tests.Logging.LoggerModel ParentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LogLevel ActiveLevel
        {
            get
            {
                return this.ActiveLevelField;
            }
            set
            {
                this.ActiveLevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LoggerModel[] ChildLogger
        {
            get
            {
                return this.ChildLoggerField;
            }
            set
            {
                this.ChildLoggerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LoggerModel Parent
        {
            get
            {
                return this.ParentField;
            }
            set
            {
                this.ParentField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogLevel", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Logging")]
    public enum LogLevel : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Trace = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Debug = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fatal = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetLogLevelRequest", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins.Logging" +
        "")]
    public partial class SetLogLevelRequest : object
    {
        
        private Moryx.Tools.Wcf.Tests.Logging.LogLevel LevelField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LogLevel Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvocationResponse", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins")]
    public partial class InvocationResponse : object
    {
        
        private string ErrorMessageField;
        
        private string ExceptionTypeField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionType
        {
            get
            {
                return this.ExceptionTypeField;
            }
            set
            {
                this.ExceptionTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                this.SuccessField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddAppenderRequest", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins.Logging" +
        "")]
    public partial class AddAppenderRequest : object
    {
        
        private Moryx.Tools.Wcf.Tests.Logging.LogLevel MinLevelField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LogLevel MinLevel
        {
            get
            {
                return this.MinLevelField;
            }
            set
            {
                this.MinLevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddAppenderResponse", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins.Logging" +
        "")]
    public partial class AddAppenderResponse : object
    {
        
        private int AppenderIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AppenderId
        {
            get
            {
                return this.AppenderIdField;
            }
            set
            {
                this.AppenderIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogMessageModel", Namespace="http://schemas.datacontract.org/2004/07/Moryx.Runtime.Maintenance.Plugins.Logging" +
        "")]
    public partial class LogMessageModel : object
    {
        
        private string ClassNameField;
        
        private Moryx.Tools.Wcf.Tests.Logging.LogLevel LogLevelField;
        
        private Moryx.Tools.Wcf.Tests.Logging.LoggerModel LoggerField;
        
        private string MessageField;
        
        private System.DateTime TimestampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassName
        {
            get
            {
                return this.ClassNameField;
            }
            set
            {
                this.ClassNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LogLevel LogLevel
        {
            get
            {
                return this.LogLevelField;
            }
            set
            {
                this.LogLevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Moryx.Tools.Wcf.Tests.Logging.LoggerModel Logger
        {
            get
            {
                return this.LoggerField;
            }
            set
            {
                this.LoggerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Moryx.Tools.Wcf.Tests.Logging.ILogMaintenance")]
    public interface ILogMaintenance
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogMaintenance/GetAllLoggers", ReplyAction="http://tempuri.org/ILogMaintenance/GetAllLoggersResponse")]
        System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.LoggerModel[]> GetAllLoggersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogMaintenance/SetLogLevel", ReplyAction="http://tempuri.org/ILogMaintenance/SetLogLevelResponse")]
        System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.InvocationResponse> SetLogLevelAsync(string loggerName, Moryx.Tools.Wcf.Tests.Logging.SetLogLevelRequest setLogLevelRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogMaintenance/AddAppender", ReplyAction="http://tempuri.org/ILogMaintenance/AddAppenderResponse")]
        System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.AddAppenderResponse> AddAppenderAsync(Moryx.Tools.Wcf.Tests.Logging.AddAppenderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogMaintenance/RemoveAppender", ReplyAction="http://tempuri.org/ILogMaintenance/RemoveAppenderResponse")]
        System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.InvocationResponse> RemoveAppenderAsync(string appenderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogMaintenance/GetMessages", ReplyAction="http://tempuri.org/ILogMaintenance/GetMessagesResponse")]
        System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.LogMessageModel[]> GetMessagesAsync(string appenderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ILogMaintenanceChannel : Moryx.Tools.Wcf.Tests.Logging.ILogMaintenance, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class LogMaintenanceClient : System.ServiceModel.ClientBase<Moryx.Tools.Wcf.Tests.Logging.ILogMaintenance>, Moryx.Tools.Wcf.Tests.Logging.ILogMaintenance
    {
        
        public LogMaintenanceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.LoggerModel[]> GetAllLoggersAsync()
        {
            return base.Channel.GetAllLoggersAsync();
        }
        
        public System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.InvocationResponse> SetLogLevelAsync(string loggerName, Moryx.Tools.Wcf.Tests.Logging.SetLogLevelRequest setLogLevelRequest)
        {
            return base.Channel.SetLogLevelAsync(loggerName, setLogLevelRequest);
        }
        
        public System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.AddAppenderResponse> AddAppenderAsync(Moryx.Tools.Wcf.Tests.Logging.AddAppenderRequest request)
        {
            return base.Channel.AddAppenderAsync(request);
        }
        
        public System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.InvocationResponse> RemoveAppenderAsync(string appenderId)
        {
            return base.Channel.RemoveAppenderAsync(appenderId);
        }
        
        public System.Threading.Tasks.Task<Moryx.Tools.Wcf.Tests.Logging.LogMessageModel[]> GetMessagesAsync(string appenderId)
        {
            return base.Channel.GetMessagesAsync(appenderId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}