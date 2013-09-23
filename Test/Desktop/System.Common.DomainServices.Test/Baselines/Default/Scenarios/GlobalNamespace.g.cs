//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using OpenRiaServices.DomainServices;
using OpenRiaServices.DomainServices.Client;
using OpenRiaServices.DomainServices.Client.ApplicationServices;



public enum GlobalNamespaceTest_Enum_NonShared
{
    
    DefaultValue = 0,
    
    NonDefaultValue = 1,
}
namespace GlobalNamespaceTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Client;
    using OpenRiaServices.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'GlobalNamespaceTest_DomainService' DomainService.
    /// </summary>
    [GlobalNamespaceTest_(EnumProperty=GlobalNamespaceTest_Enum.NonDefaultValue)]
    public sealed partial class GlobalNamespaceTest_DomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class.
        /// </summary>
        public GlobalNamespaceTest_DomainContext() : 
                this(new WebDomainClient<IGlobalNamespaceTest_DomainServiceContract>(new Uri("GlobalNamespaceTest-GlobalNamespaceTest_DomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The GlobalNamespaceTest_DomainService service URI.</param>
        public GlobalNamespaceTest_DomainContext(Uri serviceUri) : 
                this(new WebDomainClient<IGlobalNamespaceTest_DomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_DomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public GlobalNamespaceTest_DomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="GlobalNamespaceTest_Entity"/> entity instances that have been loaded into this <see cref="GlobalNamespaceTest_DomainContext"/> instance.
        /// </summary>
        public EntitySet<GlobalNamespaceTest_Entity> GlobalNamespaceTest_Entities
        {
            get
            {
                return base.EntityContainer.GetEntitySet<GlobalNamespaceTest_Entity>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'GetEntities' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        [GlobalNamespaceTest_()]
        public EntityQuery<GlobalNamespaceTest_Entity> GetEntitiesQuery()
        {
            this.ValidateMethod("GetEntitiesQuery", null);
            return base.CreateQuery<GlobalNamespaceTest_Entity>("GetEntities", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="GlobalNamespaceTest_Entity"/> entity instances using the 'ReadEntities' query.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="GlobalNamespaceTest_Entity"/> entity instances.</returns>
        [GlobalNamespaceTest_()]
        public EntityQuery<GlobalNamespaceTest_Entity> ReadEntitiesQuery([GlobalNamespaceTest_Validation()] GlobalNamespaceTest_Enum enumParameter)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("ReadEntitiesQuery", parameters);
            return base.CreateQuery<GlobalNamespaceTest_Entity>("ReadEntities", parameters, false, true);
        }
        
        /// <summary>
        /// Invokes the 'CustomUpdateEntity' method of the specified <see cref="GlobalNamespaceTest_Entity"/> entity.
        /// </summary>
        /// <param name="entity">The <see cref="GlobalNamespaceTest_Entity"/> entity instance.</param>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter for this action.</param>
        public void CustomUpdateEntity(GlobalNamespaceTest_Entity entity, GlobalNamespaceTest_Enum enumParameter)
        {
            entity.CustomUpdateEntity(enumParameter);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [GlobalNamespaceTest_()]
        public InvokeOperation<GlobalNamespaceTest_Enum> InvokeReturn([GlobalNamespaceTest_Validation()] GlobalNamespaceTest_Enum enumParameter, Action<InvokeOperation<GlobalNamespaceTest_Enum>> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeReturn", parameters);
            return ((InvokeOperation<GlobalNamespaceTest_Enum>)(this.InvokeOperation("InvokeReturn", typeof(GlobalNamespaceTest_Enum), parameters, true, callback, userState)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeReturn' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [GlobalNamespaceTest_()]
        public InvokeOperation<GlobalNamespaceTest_Enum> InvokeReturn([GlobalNamespaceTest_Validation()] GlobalNamespaceTest_Enum enumParameter)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeReturn", parameters);
            return ((InvokeOperation<GlobalNamespaceTest_Enum>)(this.InvokeOperation("InvokeReturn", typeof(GlobalNamespaceTest_Enum), parameters, true, null, null)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [GlobalNamespaceTest_()]
        public InvokeOperation InvokeVoid([GlobalNamespaceTest_Validation()] GlobalNamespaceTest_Enum enumParameter, Action<InvokeOperation> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeVoid", parameters);
            return this.InvokeOperation("InvokeVoid", typeof(void), parameters, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'InvokeVoid' method of the DomainService.
        /// </summary>
        /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        [GlobalNamespaceTest_()]
        public InvokeOperation InvokeVoid([GlobalNamespaceTest_Validation()] GlobalNamespaceTest_Enum enumParameter)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("enumParameter", enumParameter);
            this.ValidateMethod("InvokeVoid", parameters);
            return this.InvokeOperation("InvokeVoid", typeof(void), parameters, true, null, null);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new GlobalNamespaceTest_DomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'GlobalNamespaceTest_DomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        [ServiceKnownType(typeof(GlobalNamespaceTest_Enum))]
        public interface IGlobalNamespaceTest_DomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetEntities' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/GlobalNamespaceTest_DomainService/GetEntitiesDomainServiceFaul" +
                "t", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/GlobalNamespaceTest_DomainService/GetEntities", ReplyAction="http://tempuri.org/GlobalNamespaceTest_DomainService/GetEntitiesResponse")]
            [WebGet()]
            IAsyncResult BeginGetEntities(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetEntities' operation.</returns>
            QueryResult<GlobalNamespaceTest_Entity> EndGetEntities(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'InvokeReturn' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeReturnDomainServiceFau" +
                "lt", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeReturn", ReplyAction="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeReturnResponse")]
            IAsyncResult BeginInvokeReturn(GlobalNamespaceTest_Enum enumParameter, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginInvokeReturn'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginInvokeReturn'.</param>
            /// <returns>The 'GlobalNamespaceTest_Enum' returned from the 'InvokeReturn' operation.</returns>
            GlobalNamespaceTest_Enum EndInvokeReturn(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'InvokeVoid' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeVoidDomainServiceFault" +
                "", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeVoid", ReplyAction="http://tempuri.org/GlobalNamespaceTest_DomainService/InvokeVoidResponse")]
            IAsyncResult BeginInvokeVoid(GlobalNamespaceTest_Enum enumParameter, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginInvokeVoid'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginInvokeVoid'.</param>
            void EndInvokeVoid(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'ReadEntities' operation.
            /// </summary>
            /// <param name="enumParameter">The value for the 'enumParameter' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/GlobalNamespaceTest_DomainService/ReadEntitiesDomainServiceFau" +
                "lt", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/GlobalNamespaceTest_DomainService/ReadEntities", ReplyAction="http://tempuri.org/GlobalNamespaceTest_DomainService/ReadEntitiesResponse")]
            [WebGet()]
            IAsyncResult BeginReadEntities(GlobalNamespaceTest_Enum enumParameter, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginReadEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginReadEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'ReadEntities' operation.</returns>
            QueryResult<GlobalNamespaceTest_Entity> EndReadEntities(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/GlobalNamespaceTest_DomainService/SubmitChangesDomainServiceFa" +
                "ult", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/GlobalNamespaceTest_DomainService/SubmitChanges", ReplyAction="http://tempuri.org/GlobalNamespaceTest_DomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class GlobalNamespaceTest_DomainContextEntityContainer : EntityContainer
        {
            
            public GlobalNamespaceTest_DomainContextEntityContainer()
            {
                this.CreateEntitySet<GlobalNamespaceTest_Entity>(EntitySetOperations.All);
            }
        }
    }
    
    /// <summary>
    /// The 'GlobalNamespaceTest_Entity' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/GlobalNamespaceTest")]
    [GlobalNamespaceTest_()]
    [GlobalNamespaceTest_Validation()]
    public sealed partial class GlobalNamespaceTest_Entity : Entity
    {
        
        private GlobalNamespaceTest_Enum _enumProperty;
        
        private GlobalNamespaceTest_Enum_NonShared _enumProperty_NonShared;
        
        private int _key;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnEnumPropertyChanging(GlobalNamespaceTest_Enum value);
        partial void OnEnumPropertyChanged();
        partial void OnEnumProperty_NonSharedChanging(GlobalNamespaceTest_Enum_NonShared value);
        partial void OnEnumProperty_NonSharedChanged();
        partial void OnKeyChanging(int value);
        partial void OnKeyChanged();
        partial void OnCustomUpdateEntityInvoking(GlobalNamespaceTest_Enum enumParameter);
        partial void OnCustomUpdateEntityInvoked();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNamespaceTest_Entity"/> class.
        /// </summary>
        public GlobalNamespaceTest_Entity()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'EnumProperty' value.
        /// </summary>
        [DataMember()]
        [GlobalNamespaceTest_Validation()]
        public GlobalNamespaceTest_Enum EnumProperty
        {
            get
            {
                return this._enumProperty;
            }
            set
            {
                if ((this._enumProperty != value))
                {
                    this.OnEnumPropertyChanging(value);
                    this.RaiseDataMemberChanging("EnumProperty");
                    this.ValidateProperty("EnumProperty", value);
                    this._enumProperty = value;
                    this.RaiseDataMemberChanged("EnumProperty");
                    this.OnEnumPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'EnumProperty_NonShared' value.
        /// </summary>
        [DataMember()]
        [GlobalNamespaceTest_Validation()]
        public GlobalNamespaceTest_Enum_NonShared EnumProperty_NonShared
        {
            get
            {
                return this._enumProperty_NonShared;
            }
            set
            {
                if ((this._enumProperty_NonShared != value))
                {
                    this.OnEnumProperty_NonSharedChanging(value);
                    this.RaiseDataMemberChanging("EnumProperty_NonShared");
                    this.ValidateProperty("EnumProperty_NonShared", value);
                    this._enumProperty_NonShared = value;
                    this.RaiseDataMemberChanged("EnumProperty_NonShared");
                    this.OnEnumProperty_NonSharedChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Key' value.
        /// </summary>
        [CustomValidation(typeof(GlobalNamespaceTest_Validation), "Validate")]
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [GlobalNamespaceTest_Validation()]
        [Key()]
        [RoundtripOriginal()]
        public int Key
        {
            get
            {
                return this._key;
            }
            set
            {
                if ((this._key != value))
                {
                    this.OnKeyChanging(value);
                    this.ValidateProperty("Key", value);
                    this._key = value;
                    this.RaisePropertyChanged("Key");
                    this.OnKeyChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'CustomUpdateEntity' action has been invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool IsCustomUpdateEntityInvoked
        {
            get
            {
                return base.IsActionInvoked("CustomUpdateEntity");
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the 'CustomUpdateEntity' method can be invoked on this entity.
        /// </summary>
        [Display(AutoGenerateField=false)]
        public bool CanCustomUpdateEntity
        {
            get
            {
                return base.CanInvokeAction("CustomUpdateEntity");
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._key;
        }
        
        /// <summary>
        /// Invokes the 'CustomUpdateEntity' action on this entity.
        /// </summary>
        /// <param name="enumParameter">The value to pass to the server method's 'enumParameter' parameter.</param>
        [GlobalNamespaceTest_()]
        public void CustomUpdateEntity(GlobalNamespaceTest_Enum enumParameter)
        {
            this.OnCustomUpdateEntityInvoking(enumParameter);
            base.InvokeAction("CustomUpdateEntity", enumParameter);
            this.OnCustomUpdateEntityInvoked();
        }
        
        protected override void OnActionStateChanged()
        {
            base.UpdateActionState("CustomUpdateEntity", "CanCustomUpdateEntity", "IsCustomUpdateEntityInvoked");
        }
    }
}
