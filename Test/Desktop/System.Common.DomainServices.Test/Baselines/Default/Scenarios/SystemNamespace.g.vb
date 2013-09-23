'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports OpenRiaServices.DomainServices
Imports OpenRiaServices.DomainServices.Client
Imports OpenRiaServices.DomainServices.Client.ApplicationServices
Imports System.ServiceModel.Web
Imports System.Subsystem

Namespace System
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'SystemDomainService' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class SystemDomainContext
        Inherits DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemDomainContext"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of ISystemDomainServiceContract)(New Uri("System-SystemDomainService.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemDomainContext"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The SystemDomainService service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of ISystemDomainServiceContract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemDomainContext"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="SystemEntity"/> entity instances that have been loaded into this <see cref="SystemDomainContext"/> instance.
        ''' </summary>
        Public ReadOnly Property SystemEntities() As EntitySet(Of SystemEntity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of SystemEntity)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="SystemEntity"/> entity instances using the 'GetSystemEntities' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="SystemEntity"/> entity instances.</returns>
        Public Function GetSystemEntitiesQuery() As EntityQuery(Of SystemEntity)
            Me.ValidateMethod("GetSystemEntitiesQuery", Nothing)
            Return MyBase.CreateQuery(Of SystemEntity)("GetSystemEntities", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New SystemDomainContextEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'SystemDomainService' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface ISystemDomainServiceContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetSystemEntities' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/SystemDomainService/GetSystemEntitiesDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/SystemDomainService/GetSystemEntities", ReplyAction:="http://tempuri.org/SystemDomainService/GetSystemEntitiesResponse"),  _
             WebGet()>  _
            Function BeginGetSystemEntities(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetSystemEntities'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetSystemEntities'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetSystemEntities' operation.</returns>
            Function EndGetSystemEntities(ByVal result As IAsyncResult) As QueryResult(Of SystemEntity)
        End Interface
        
        Friend NotInheritable Class SystemDomainContextEntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of SystemEntity)(EntitySetOperations.None)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'SystemEntity' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/System"),  _
     SystemNamespace()>  _
    Partial Public NotInheritable Class SystemEntity
        Inherits Entity
        
        Private _key As Integer
        
        Private _subsystemEnum As SubsystemEnum
        
        Private _systemEnum As SystemEnum
        
        Private _systemGeneratedEnum As SystemGeneratedEnum
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnKeyChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnKeyChanged()
        End Sub
        Private Partial Sub OnSubsystemEnumChanging(ByVal value As SubsystemEnum)
        End Sub
        Private Partial Sub OnSubsystemEnumChanged()
        End Sub
        Private Partial Sub OnSystemEnumChanging(ByVal value As SystemEnum)
        End Sub
        Private Partial Sub OnSystemEnumChanged()
        End Sub
        Private Partial Sub OnSystemGeneratedEnumChanging(ByVal value As SystemGeneratedEnum)
        End Sub
        Private Partial Sub OnSystemGeneratedEnumChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemEntity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Key' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property Key() As Integer
            Get
                Return Me._key
            End Get
            Set
                If ((Me._key = value)  _
                            = false) Then
                    Me.OnKeyChanging(value)
                    Me.ValidateProperty("Key", value)
                    Me._key = value
                    Me.RaisePropertyChanged("Key")
                    Me.OnKeyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SubsystemEnum' value.
        ''' </summary>
        <DataMember(),  _
         SubsystemNamespace()>  _
        Public Property SubsystemEnum() As SubsystemEnum
            Get
                Return Me._subsystemEnum
            End Get
            Set
                If ((Me._subsystemEnum = value)  _
                            = false) Then
                    Me.OnSubsystemEnumChanging(value)
                    Me.RaiseDataMemberChanging("SubsystemEnum")
                    Me.ValidateProperty("SubsystemEnum", value)
                    Me._subsystemEnum = value
                    Me.RaiseDataMemberChanged("SubsystemEnum")
                    Me.OnSubsystemEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SystemEnum' value.
        ''' </summary>
        <DataMember(),  _
         SystemNamespace()>  _
        Public Property SystemEnum() As SystemEnum
            Get
                Return Me._systemEnum
            End Get
            Set
                If ((Me._systemEnum = value)  _
                            = false) Then
                    Me.OnSystemEnumChanging(value)
                    Me.RaiseDataMemberChanging("SystemEnum")
                    Me.ValidateProperty("SystemEnum", value)
                    Me._systemEnum = value
                    Me.RaiseDataMemberChanged("SystemEnum")
                    Me.OnSystemEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SystemGeneratedEnum' value.
        ''' </summary>
        <DataMember()>  _
        Public Property SystemGeneratedEnum() As SystemGeneratedEnum
            Get
                Return Me._systemGeneratedEnum
            End Get
            Set
                If ((Me._systemGeneratedEnum = value)  _
                            = false) Then
                    Me.OnSystemGeneratedEnumChanging(value)
                    Me.RaiseDataMemberChanging("SystemGeneratedEnum")
                    Me.ValidateProperty("SystemGeneratedEnum", value)
                    Me._systemGeneratedEnum = value
                    Me.RaiseDataMemberChanged("SystemGeneratedEnum")
                    Me.OnSystemGeneratedEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
    
    Public Enum SystemGeneratedEnum
        
        SystemGeneratedEnumValue = 0
    End Enum
End Namespace

Namespace System.Subsystem
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'SubsystemDomainService' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class SubsystemDomainContext
        Inherits DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SubsystemDomainContext"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of ISubsystemDomainServiceContract)(New Uri("System-Subsystem-SubsystemDomainService.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SubsystemDomainContext"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The SubsystemDomainService service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of ISubsystemDomainServiceContract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SubsystemDomainContext"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="SubsystemEntity"/> entity instances that have been loaded into this <see cref="SubsystemDomainContext"/> instance.
        ''' </summary>
        Public ReadOnly Property SubsystemEntities() As EntitySet(Of SubsystemEntity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of SubsystemEntity)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="SubsystemEntity"/> entity instances using the 'GetSubsystemEntities' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="SubsystemEntity"/> entity instances.</returns>
        Public Function GetSubsystemEntitiesQuery() As EntityQuery(Of SubsystemEntity)
            Me.ValidateMethod("GetSubsystemEntitiesQuery", Nothing)
            Return MyBase.CreateQuery(Of SubsystemEntity)("GetSubsystemEntities", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New SubsystemDomainContextEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'SubsystemDomainService' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface ISubsystemDomainServiceContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetSubsystemEntities' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/SubsystemDomainService/GetSubsystemEntitiesDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/SubsystemDomainService/GetSubsystemEntities", ReplyAction:="http://tempuri.org/SubsystemDomainService/GetSubsystemEntitiesResponse"),  _
             WebGet()>  _
            Function BeginGetSubsystemEntities(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetSubsystemEntities'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetSubsystemEntities'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetSubsystemEntities' operation.</returns>
            Function EndGetSubsystemEntities(ByVal result As IAsyncResult) As QueryResult(Of SubsystemEntity)
        End Interface
        
        Friend NotInheritable Class SubsystemDomainContextEntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of SubsystemEntity)(EntitySetOperations.None)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'SubsystemEntity' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/System.Subsystem")>  _
    Partial Public NotInheritable Class SubsystemEntity
        Inherits Entity
        
        Private _key As Integer
        
        Private _subsystemEnum As SubsystemEnum
        
        Private _subsystemGeneratedEnum As SubsystemGeneratedEnum
        
        Private _systemEnum As SystemEnum
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnKeyChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnKeyChanged()
        End Sub
        Private Partial Sub OnSubsystemEnumChanging(ByVal value As SubsystemEnum)
        End Sub
        Private Partial Sub OnSubsystemEnumChanged()
        End Sub
        Private Partial Sub OnSubsystemGeneratedEnumChanging(ByVal value As SubsystemGeneratedEnum)
        End Sub
        Private Partial Sub OnSubsystemGeneratedEnumChanged()
        End Sub
        Private Partial Sub OnSystemEnumChanging(ByVal value As SystemEnum)
        End Sub
        Private Partial Sub OnSystemEnumChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SubsystemEntity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Key' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property Key() As Integer
            Get
                Return Me._key
            End Get
            Set
                If ((Me._key = value)  _
                            = false) Then
                    Me.OnKeyChanging(value)
                    Me.ValidateProperty("Key", value)
                    Me._key = value
                    Me.RaisePropertyChanged("Key")
                    Me.OnKeyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SubsystemEnum' value.
        ''' </summary>
        <DataMember(),  _
         SubsystemNamespace()>  _
        Public Property SubsystemEnum() As SubsystemEnum
            Get
                Return Me._subsystemEnum
            End Get
            Set
                If ((Me._subsystemEnum = value)  _
                            = false) Then
                    Me.OnSubsystemEnumChanging(value)
                    Me.RaiseDataMemberChanging("SubsystemEnum")
                    Me.ValidateProperty("SubsystemEnum", value)
                    Me._subsystemEnum = value
                    Me.RaiseDataMemberChanged("SubsystemEnum")
                    Me.OnSubsystemEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SubsystemGeneratedEnum' value.
        ''' </summary>
        <DataMember()>  _
        Public Property SubsystemGeneratedEnum() As SubsystemGeneratedEnum
            Get
                Return Me._subsystemGeneratedEnum
            End Get
            Set
                If ((Me._subsystemGeneratedEnum = value)  _
                            = false) Then
                    Me.OnSubsystemGeneratedEnumChanging(value)
                    Me.RaiseDataMemberChanging("SubsystemGeneratedEnum")
                    Me.ValidateProperty("SubsystemGeneratedEnum", value)
                    Me._subsystemGeneratedEnum = value
                    Me.RaiseDataMemberChanged("SubsystemGeneratedEnum")
                    Me.OnSubsystemGeneratedEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SystemEnum' value.
        ''' </summary>
        <DataMember(),  _
         SystemNamespace()>  _
        Public Property SystemEnum() As SystemEnum
            Get
                Return Me._systemEnum
            End Get
            Set
                If ((Me._systemEnum = value)  _
                            = false) Then
                    Me.OnSystemEnumChanging(value)
                    Me.RaiseDataMemberChanging("SystemEnum")
                    Me.ValidateProperty("SystemEnum", value)
                    Me._systemEnum = value
                    Me.RaiseDataMemberChanged("SystemEnum")
                    Me.OnSystemEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
    
    Public Enum SubsystemGeneratedEnum
        
        SubsystemGeneratedEnumValue = 0
    End Enum
End Namespace

Namespace SystemExtensions
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'SystemExtensionsDomainService' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class SystemExtensionsDomainContext
        Inherits DomainContext
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemExtensionsDomainContext"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of ISystemExtensionsDomainServiceContract)(New Uri("SystemExtensions-SystemExtensionsDomainService.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemExtensionsDomainContext"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The SystemExtensionsDomainService service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of ISystemExtensionsDomainServiceContract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemExtensionsDomainContext"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="SystemExtensionsEntity"/> entity instances that have been loaded into this <see cref="SystemExtensionsDomainContext"/> instance.
        ''' </summary>
        Public ReadOnly Property SystemExtensionsEntities() As EntitySet(Of SystemExtensionsEntity)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of SystemExtensionsEntity)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="SystemExtensionsEntity"/> entity instances using the 'GetSystemExtensionsEntities' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="SystemExtensionsEntity"/> entity instances.</returns>
        Public Function GetSystemExtensionsEntitiesQuery() As EntityQuery(Of SystemExtensionsEntity)
            Me.ValidateMethod("GetSystemExtensionsEntitiesQuery", Nothing)
            Return MyBase.CreateQuery(Of SystemExtensionsEntity)("GetSystemExtensionsEntities", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New SystemExtensionsDomainContextEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'SystemExtensionsDomainService' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface ISystemExtensionsDomainServiceContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'GetSystemExtensionsEntities' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/SystemExtensionsDomainService/GetSystemExtensionsEntitiesDomai"& _ 
                "nServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/SystemExtensionsDomainService/GetSystemExtensionsEntities", ReplyAction:="http://tempuri.org/SystemExtensionsDomainService/GetSystemExtensionsEntitiesRespo"& _ 
                "nse"),  _
             WebGet()>  _
            Function BeginGetSystemExtensionsEntities(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginGetSystemExtensionsEntities'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginGetSystemExtensionsEntities'.</param>
            ''' <returns>The 'QueryResult' returned from the 'GetSystemExtensionsEntities' operation.</returns>
            Function EndGetSystemExtensionsEntities(ByVal result As IAsyncResult) As QueryResult(Of SystemExtensionsEntity)
        End Interface
        
        Friend NotInheritable Class SystemExtensionsDomainContextEntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of SystemExtensionsEntity)(EntitySetOperations.None)
            End Sub
        End Class
    End Class
    
    ''' <summary>
    ''' The 'SystemExtensionsEntity' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/SystemExtensions")>  _
    Partial Public NotInheritable Class SystemExtensionsEntity
        Inherits Entity
        
        Private _key As Integer
        
        Private _systemExtensionsEnum As SystemExtensionsEnum
        
        Private _systemExtensionsGeneratedEnum As SystemExtensionsGeneratedEnum
        
        #Region "Extensibility Method Definitions"

        ''' <summary>
        ''' This method is invoked from the constructor once initialization is complete and
        ''' can be used for further object setup.
        ''' </summary>
        Private Partial Sub OnCreated()
        End Sub
        Private Partial Sub OnKeyChanging(ByVal value As Integer)
        End Sub
        Private Partial Sub OnKeyChanged()
        End Sub
        Private Partial Sub OnSystemExtensionsEnumChanging(ByVal value As SystemExtensionsEnum)
        End Sub
        Private Partial Sub OnSystemExtensionsEnumChanged()
        End Sub
        Private Partial Sub OnSystemExtensionsGeneratedEnumChanging(ByVal value As SystemExtensionsGeneratedEnum)
        End Sub
        Private Partial Sub OnSystemExtensionsGeneratedEnumChanged()
        End Sub

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemExtensionsEntity"/> class.
        ''' </summary>
        Public Sub New()
            MyBase.New
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets or sets the 'Key' value.
        ''' </summary>
        <DataMember(),  _
         Editable(false, AllowInitialValue:=true),  _
         Key(),  _
         RoundtripOriginal()>  _
        Public Property Key() As Integer
            Get
                Return Me._key
            End Get
            Set
                If ((Me._key = value)  _
                            = false) Then
                    Me.OnKeyChanging(value)
                    Me.ValidateProperty("Key", value)
                    Me._key = value
                    Me.RaisePropertyChanged("Key")
                    Me.OnKeyChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SystemExtensionsEnum' value.
        ''' </summary>
        <DataMember(),  _
         SystemExtensionsNamespace()>  _
        Public Property SystemExtensionsEnum() As SystemExtensionsEnum
            Get
                Return Me._systemExtensionsEnum
            End Get
            Set
                If ((Me._systemExtensionsEnum = value)  _
                            = false) Then
                    Me.OnSystemExtensionsEnumChanging(value)
                    Me.RaiseDataMemberChanging("SystemExtensionsEnum")
                    Me.ValidateProperty("SystemExtensionsEnum", value)
                    Me._systemExtensionsEnum = value
                    Me.RaiseDataMemberChanged("SystemExtensionsEnum")
                    Me.OnSystemExtensionsEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Gets or sets the 'SystemExtensionsGeneratedEnum' value.
        ''' </summary>
        <DataMember()>  _
        Public Property SystemExtensionsGeneratedEnum() As SystemExtensionsGeneratedEnum
            Get
                Return Me._systemExtensionsGeneratedEnum
            End Get
            Set
                If ((Me._systemExtensionsGeneratedEnum = value)  _
                            = false) Then
                    Me.OnSystemExtensionsGeneratedEnumChanging(value)
                    Me.RaiseDataMemberChanging("SystemExtensionsGeneratedEnum")
                    Me.ValidateProperty("SystemExtensionsGeneratedEnum", value)
                    Me._systemExtensionsGeneratedEnum = value
                    Me.RaiseDataMemberChanged("SystemExtensionsGeneratedEnum")
                    Me.OnSystemExtensionsGeneratedEnumChanged
                End If
            End Set
        End Property
        
        ''' <summary>
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
    
    Public Enum SystemExtensionsGeneratedEnum
        
        SystemExtensionsGeneratedEnumValue = 0
    End Enum
End Namespace
