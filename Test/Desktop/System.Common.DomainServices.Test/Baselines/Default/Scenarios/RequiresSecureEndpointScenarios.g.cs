//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using OpenRiaServices;
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Client;
    using OpenRiaServices.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    
    /// <summary>
    /// The 'TestEntity_RequiresSecureEndpoint' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices")]
    public sealed partial class TestEntity_RequiresSecureEndpoint : Entity
    {
        
        private int _key;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnKeyChanging(int value);
        partial void OnKeyChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity_RequiresSecureEndpoint"/> class.
        /// </summary>
        public TestEntity_RequiresSecureEndpoint()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Key' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
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
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._key;
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'TestService_RequiresSecureEndpoint' DomainService.
    /// </summary>
    public sealed partial class TestService_RequiresSecureEndpoint : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TestService_RequiresSecureEndpoint"/> class.
        /// </summary>
        public TestService_RequiresSecureEndpoint() : 
                this(new WebDomainClient<ITestService_RequiresSecureEndpointContract>(new Uri("TestDomainServices-TestService_RequiresSecureEndpoint.svc", UriKind.Relative), true))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TestService_RequiresSecureEndpoint"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The TestService_RequiresSecureEndpoint service URI.</param>
        public TestService_RequiresSecureEndpoint(Uri serviceUri) : 
                this(new WebDomainClient<ITestService_RequiresSecureEndpointContract>(serviceUri, true))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TestService_RequiresSecureEndpoint"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public TestService_RequiresSecureEndpoint(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="TestEntity_RequiresSecureEndpoint"/> entity instances that have been loaded into this <see cref="TestService_RequiresSecureEndpoint"/> instance.
        /// </summary>
        public EntitySet<TestEntity_RequiresSecureEndpoint> TestEntity_RequiresSecureEndpoints
        {
            get
            {
                return base.EntityContainer.GetEntitySet<TestEntity_RequiresSecureEndpoint>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="TestEntity_RequiresSecureEndpoint"/> entity instances using the 'GetTestEntities' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="TestEntity_RequiresSecureEndpoint"/> entity instances.</returns>
        public EntityQuery<TestEntity_RequiresSecureEndpoint> GetTestEntitiesQuery()
        {
            this.ValidateMethod("GetTestEntitiesQuery", null);
            return base.CreateQuery<TestEntity_RequiresSecureEndpoint>("GetTestEntities", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new TestService_RequiresSecureEndpointEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'TestService_RequiresSecureEndpoint' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface ITestService_RequiresSecureEndpointContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetTestEntities' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TestService_RequiresSecureEndpoint/GetTestEntitiesDomainServic" +
                "eFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TestService_RequiresSecureEndpoint/GetTestEntities", ReplyAction="http://tempuri.org/TestService_RequiresSecureEndpoint/GetTestEntitiesResponse")]
            [WebGet()]
            IAsyncResult BeginGetTestEntities(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTestEntities'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTestEntities'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetTestEntities' operation.</returns>
            QueryResult<TestEntity_RequiresSecureEndpoint> EndGetTestEntities(IAsyncResult result);
        }
        
        internal sealed class TestService_RequiresSecureEndpointEntityContainer : EntityContainer
        {
            
            public TestService_RequiresSecureEndpointEntityContainer()
            {
                this.CreateEntitySet<TestEntity_RequiresSecureEndpoint>(EntitySetOperations.None);
            }
        }
    }
}
