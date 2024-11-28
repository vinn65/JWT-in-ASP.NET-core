﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAVWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", ConfigurationName="NAVWS.PortalIntegration_Port")]
    public interface PortalIntegration_Port
    {
        
        // CODEGEN: Generating message contract since the wrapper name (CreateUser_Result) of message CreateUser_Result does not match the default value (CreateUser)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:CreateUser", ReplyAction="*")]
        NAVWS.CreateUser_Result CreateUser(NAVWS.CreateUser request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:CreateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.CreateUser_Result> CreateUserAsync(NAVWS.CreateUser request);
        
        // CODEGEN: Generating message contract since the wrapper name (InsertSeminarData_Result) of message InsertSeminarData_Result does not match the default value (InsertSeminarData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarData", ReplyAction="*")]
        NAVWS.InsertSeminarData_Result InsertSeminarData(NAVWS.InsertSeminarData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> InsertSeminarDataAsync(NAVWS.InsertSeminarData request);
        
        // CODEGEN: Generating message contract since the wrapper name (InsertSeminarRegData_Result) of message InsertSeminarRegData_Result does not match the default value (InsertSeminarRegData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarRegData", ReplyAction="*")]
        NAVWS.InsertSeminarRegData_Result InsertSeminarRegData(NAVWS.InsertSeminarRegData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:InsertSeminarRegData", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarRegData_Result> InsertSeminarRegDataAsync(NAVWS.InsertSeminarRegData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LoginUser_Result) of message LoginUser_Result does not match the default value (LoginUser)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:LoginUser", ReplyAction="*")]
        NAVWS.LoginUser_Result LoginUser(NAVWS.LoginUser request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:LoginUser", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.LoginUser_Result> LoginUserAsync(NAVWS.LoginUser request);
        
        // CODEGEN: Generating message contract since the wrapper name (RegisterParticipant_Result) of message RegisterParticipant_Result does not match the default value (RegisterParticipant)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:RegisterParticipant", ReplyAction="*")]
        NAVWS.RegisterParticipant_Result RegisterParticipant(NAVWS.RegisterParticipant request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:RegisterParticipant", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.RegisterParticipant_Result> RegisterParticipantAsync(NAVWS.RegisterParticipant request);
        
        // CODEGEN: Generating message contract since the wrapper name (UpdateUser_Result) of message UpdateUser_Result does not match the default value (UpdateUser)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:UpdateUser", ReplyAction="*")]
        NAVWS.UpdateUser_Result UpdateUser(NAVWS.UpdateUser request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration:UpdateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.UpdateUser_Result> UpdateUserAsync(NAVWS.UpdateUser request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUser", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class CreateUser
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public string email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=3)]
        public string name;
        
        public CreateUser()
        {
        }
        
        public CreateUser(string username, string password, string email, string name)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUser_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class CreateUser_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string return_value;
        
        public CreateUser_Result()
        {
        }
        
        public CreateUser_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string docNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public int seminarDuration;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=3)]
        public string searchName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=4)]
        public int minParticipants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=5)]
        public int maxParticipants;
        
        public InsertSeminarData()
        {
        }
        
        public InsertSeminarData(string docNo, string name, int seminarDuration, string searchName, int minParticipants, int maxParticipants)
        {
            this.docNo = docNo;
            this.name = name;
            this.seminarDuration = seminarDuration;
            this.searchName = searchName;
            this.minParticipants = minParticipants;
            this.maxParticipants = maxParticipants;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarData_Result
    {
        
        public InsertSeminarData_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarRegData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarRegData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string seminarNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string personNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public string roomNo;
        
        public InsertSeminarRegData()
        {
        }
        
        public InsertSeminarRegData(string seminarNo, string personNo, string roomNo)
        {
            this.seminarNo = seminarNo;
            this.personNo = personNo;
            this.roomNo = roomNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertSeminarRegData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class InsertSeminarRegData_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public bool return_value;
        
        public InsertSeminarRegData_Result()
        {
        }
        
        public InsertSeminarRegData_Result(bool return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginUser", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class LoginUser
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string password;
        
        public LoginUser()
        {
        }
        
        public LoginUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginUser_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class LoginUser_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string return_value;
        
        public LoginUser_Result()
        {
        }
        
        public LoginUser_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterParticipant", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class RegisterParticipant
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string documentNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string billToCustomerNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=2)]
        public string participantContactNo;
        
        public RegisterParticipant()
        {
        }
        
        public RegisterParticipant(string documentNo, string billToCustomerNo, string participantContactNo)
        {
            this.documentNo = documentNo;
            this.billToCustomerNo = billToCustomerNo;
            this.participantContactNo = participantContactNo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterParticipant_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class RegisterParticipant_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public bool return_value;
        
        public RegisterParticipant_Result()
        {
        }
        
        public RegisterParticipant_Result(bool return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateUser", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class UpdateUser
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=1)]
        public string name;
        
        public UpdateUser()
        {
        }
        
        public UpdateUser(string username, string name)
        {
            this.username = username;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateUser_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", IsWrapped=true)]
    public partial class UpdateUser_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/PortalIntegration", Order=0)]
        public string return_value;
        
        public UpdateUser_Result()
        {
        }
        
        public UpdateUser_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface PortalIntegration_PortChannel : NAVWS.PortalIntegration_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class PortalIntegration_PortClient : System.ServiceModel.ClientBase<NAVWS.PortalIntegration_Port>, NAVWS.PortalIntegration_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PortalIntegration_PortClient() : 
                base(PortalIntegration_PortClient.GetDefaultBinding(), PortalIntegration_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PortalIntegration_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), PortalIntegration_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PortalIntegration_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PortalIntegration_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.CreateUser_Result NAVWS.PortalIntegration_Port.CreateUser(NAVWS.CreateUser request)
        {
            return base.Channel.CreateUser(request);
        }
        
        public string CreateUser(string username, string password, string email, string name)
        {
            NAVWS.CreateUser inValue = new NAVWS.CreateUser();
            inValue.username = username;
            inValue.password = password;
            inValue.email = email;
            inValue.name = name;
            NAVWS.CreateUser_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).CreateUser(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.CreateUser_Result> NAVWS.PortalIntegration_Port.CreateUserAsync(NAVWS.CreateUser request)
        {
            return base.Channel.CreateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.CreateUser_Result> CreateUserAsync(string username, string password, string email, string name)
        {
            NAVWS.CreateUser inValue = new NAVWS.CreateUser();
            inValue.username = username;
            inValue.password = password;
            inValue.email = email;
            inValue.name = name;
            return ((NAVWS.PortalIntegration_Port)(this)).CreateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.InsertSeminarData_Result NAVWS.PortalIntegration_Port.InsertSeminarData(NAVWS.InsertSeminarData request)
        {
            return base.Channel.InsertSeminarData(request);
        }
        
        public void InsertSeminarData(string docNo, string name, int seminarDuration, string searchName, int minParticipants, int maxParticipants)
        {
            NAVWS.InsertSeminarData inValue = new NAVWS.InsertSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminarDuration = seminarDuration;
            inValue.searchName = searchName;
            inValue.minParticipants = minParticipants;
            inValue.maxParticipants = maxParticipants;
            NAVWS.InsertSeminarData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> NAVWS.PortalIntegration_Port.InsertSeminarDataAsync(NAVWS.InsertSeminarData request)
        {
            return base.Channel.InsertSeminarDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.InsertSeminarData_Result> InsertSeminarDataAsync(string docNo, string name, int seminarDuration, string searchName, int minParticipants, int maxParticipants)
        {
            NAVWS.InsertSeminarData inValue = new NAVWS.InsertSeminarData();
            inValue.docNo = docNo;
            inValue.name = name;
            inValue.seminarDuration = seminarDuration;
            inValue.searchName = searchName;
            inValue.minParticipants = minParticipants;
            inValue.maxParticipants = maxParticipants;
            return ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.InsertSeminarRegData_Result NAVWS.PortalIntegration_Port.InsertSeminarRegData(NAVWS.InsertSeminarRegData request)
        {
            return base.Channel.InsertSeminarRegData(request);
        }
        
        public bool InsertSeminarRegData(string seminarNo, string personNo, string roomNo)
        {
            NAVWS.InsertSeminarRegData inValue = new NAVWS.InsertSeminarRegData();
            inValue.seminarNo = seminarNo;
            inValue.personNo = personNo;
            inValue.roomNo = roomNo;
            NAVWS.InsertSeminarRegData_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarRegData(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.InsertSeminarRegData_Result> NAVWS.PortalIntegration_Port.InsertSeminarRegDataAsync(NAVWS.InsertSeminarRegData request)
        {
            return base.Channel.InsertSeminarRegDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.InsertSeminarRegData_Result> InsertSeminarRegDataAsync(string seminarNo, string personNo, string roomNo)
        {
            NAVWS.InsertSeminarRegData inValue = new NAVWS.InsertSeminarRegData();
            inValue.seminarNo = seminarNo;
            inValue.personNo = personNo;
            inValue.roomNo = roomNo;
            return ((NAVWS.PortalIntegration_Port)(this)).InsertSeminarRegDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.LoginUser_Result NAVWS.PortalIntegration_Port.LoginUser(NAVWS.LoginUser request)
        {
            return base.Channel.LoginUser(request);
        }
        
        public string LoginUser(string username, string password)
        {
            NAVWS.LoginUser inValue = new NAVWS.LoginUser();
            inValue.username = username;
            inValue.password = password;
            NAVWS.LoginUser_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).LoginUser(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.LoginUser_Result> NAVWS.PortalIntegration_Port.LoginUserAsync(NAVWS.LoginUser request)
        {
            return base.Channel.LoginUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.LoginUser_Result> LoginUserAsync(string username, string password)
        {
            NAVWS.LoginUser inValue = new NAVWS.LoginUser();
            inValue.username = username;
            inValue.password = password;
            return ((NAVWS.PortalIntegration_Port)(this)).LoginUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.RegisterParticipant_Result NAVWS.PortalIntegration_Port.RegisterParticipant(NAVWS.RegisterParticipant request)
        {
            return base.Channel.RegisterParticipant(request);
        }
        
        public bool RegisterParticipant(string documentNo, string billToCustomerNo, string participantContactNo)
        {
            NAVWS.RegisterParticipant inValue = new NAVWS.RegisterParticipant();
            inValue.documentNo = documentNo;
            inValue.billToCustomerNo = billToCustomerNo;
            inValue.participantContactNo = participantContactNo;
            NAVWS.RegisterParticipant_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).RegisterParticipant(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.RegisterParticipant_Result> NAVWS.PortalIntegration_Port.RegisterParticipantAsync(NAVWS.RegisterParticipant request)
        {
            return base.Channel.RegisterParticipantAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.RegisterParticipant_Result> RegisterParticipantAsync(string documentNo, string billToCustomerNo, string participantContactNo)
        {
            NAVWS.RegisterParticipant inValue = new NAVWS.RegisterParticipant();
            inValue.documentNo = documentNo;
            inValue.billToCustomerNo = billToCustomerNo;
            inValue.participantContactNo = participantContactNo;
            return ((NAVWS.PortalIntegration_Port)(this)).RegisterParticipantAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.UpdateUser_Result NAVWS.PortalIntegration_Port.UpdateUser(NAVWS.UpdateUser request)
        {
            return base.Channel.UpdateUser(request);
        }
        
        public string UpdateUser(string username, string name)
        {
            NAVWS.UpdateUser inValue = new NAVWS.UpdateUser();
            inValue.username = username;
            inValue.name = name;
            NAVWS.UpdateUser_Result retVal = ((NAVWS.PortalIntegration_Port)(this)).UpdateUser(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.UpdateUser_Result> NAVWS.PortalIntegration_Port.UpdateUserAsync(NAVWS.UpdateUser request)
        {
            return base.Channel.UpdateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.UpdateUser_Result> UpdateUserAsync(string username, string name)
        {
            NAVWS.UpdateUser inValue = new NAVWS.UpdateUser();
            inValue.username = username;
            inValue.name = name;
            return ((NAVWS.PortalIntegration_Port)(this)).UpdateUserAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PortalIntegration_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PortalIntegration_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://machine:7047/BC240/WS/CRONUS International Ltd./Codeunit/PortalIntegration" +
                        "");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PortalIntegration_PortClient.GetBindingForEndpoint(EndpointConfiguration.PortalIntegration_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PortalIntegration_PortClient.GetEndpointAddress(EndpointConfiguration.PortalIntegration_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            PortalIntegration_Port,
        }
    }
}