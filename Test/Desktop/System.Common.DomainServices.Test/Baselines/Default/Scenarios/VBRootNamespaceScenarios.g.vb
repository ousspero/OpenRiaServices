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
Imports VBRootNamespaceTest.Other
Imports VBRootNamespaceTest.VBRootNamespaceTest3


''' <summary>
''' The 'VBRootNamespaceDomainObject' entity class.
''' </summary>
<DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/VBRootNamespaceTest")>  _
Partial Public NotInheritable Class VBRootNamespaceDomainObject
    Inherits Entity
    
    Private _key As Integer
    
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

        #End Region
    
    
    ''' <summary>
    ''' Initializes a new instance of the <see cref="VBRootNamespaceDomainObject"/> class.
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
    ''' Computes a value from the key fields that uniquely identifies this entity instance.
    ''' </summary>
    ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
    Public Overrides Function GetIdentity() As Object
        Return Me._key
    End Function
End Class

''' <summary>
''' The DomainContext corresponding to the 'VBRootNamespaceTestDomainService' DomainService.
''' </summary>
Partial Public NotInheritable Class VBRootNamespaceTestDomainContext
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
    ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainContext"/> class.
    ''' </summary>
    Public Sub New()
        Me.New(New WebDomainClient(Of IVBRootNamespaceTestDomainServiceContract)(New Uri("VBRootNamespaceTest-VBRootNamespaceTestDomainService.svc", UriKind.Relative)))
    End Sub
    
    ''' <summary>
    ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainContext"/> class with the specified service URI.
    ''' </summary>
    ''' <param name="serviceUri">The VBRootNamespaceTestDomainService service URI.</param>
    Public Sub New(ByVal serviceUri As Uri)
        Me.New(New WebDomainClient(Of IVBRootNamespaceTestDomainServiceContract)(serviceUri))
    End Sub
    
    ''' <summary>
    ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainContext"/> class with the specified <paramref name="domainClient"/>.
    ''' </summary>
    ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
    Public Sub New(ByVal domainClient As DomainClient)
        MyBase.New(domainClient)
        Me.OnCreated
    End Sub
    
    ''' <summary>
    ''' Gets the set of <see cref="VBRootNamespaceDomainObject"/> entity instances that have been loaded into this <see cref="VBRootNamespaceTestDomainContext"/> instance.
    ''' </summary>
    Public ReadOnly Property VBRootNamespaceDomainObjects() As EntitySet(Of VBRootNamespaceDomainObject)
        Get
            Return MyBase.EntityContainer.GetEntitySet(Of VBRootNamespaceDomainObject)
        End Get
    End Property
    
    ''' <summary>
    ''' Gets the set of <see cref="VBRootNamespaceDomainObject4"/> entity instances that have been loaded into this <see cref="VBRootNamespaceTestDomainContext"/> instance.
    ''' </summary>
    Public ReadOnly Property VBRootNamespaceDomainObject4s() As EntitySet(Of VBRootNamespaceDomainObject4)
        Get
            Return MyBase.EntityContainer.GetEntitySet(Of VBRootNamespaceDomainObject4)
        End Get
    End Property
    
    ''' <summary>
    ''' Gets an EntityQuery instance that can be used to load <see cref="VBRootNamespaceDomainObject"/> entity instances using the 'M' query.
    ''' </summary>
    ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="VBRootNamespaceDomainObject"/> entity instances.</returns>
    Public Function MQuery() As EntityQuery(Of VBRootNamespaceDomainObject)
        Me.ValidateMethod("MQuery", Nothing)
        Return MyBase.CreateQuery(Of VBRootNamespaceDomainObject)("M", Nothing, false, true)
    End Function
    
    ''' <summary>
    ''' Gets an EntityQuery instance that can be used to load <see cref="VBRootNamespaceDomainObject4"/> entity instances using the 'M4' query.
    ''' </summary>
    ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="VBRootNamespaceDomainObject4"/> entity instances.</returns>
    Public Function M4Query() As EntityQuery(Of VBRootNamespaceDomainObject4)
        Me.ValidateMethod("M4Query", Nothing)
        Return MyBase.CreateQuery(Of VBRootNamespaceDomainObject4)("M4", Nothing, false, true)
    End Function
    
    ''' <summary>
    ''' Creates a new EntityContainer for this DomainContext's EntitySets.
    ''' </summary>
    ''' <returns>A new container instance.</returns>
    Protected Overrides Function CreateEntityContainer() As EntityContainer
        Return New VBRootNamespaceTestDomainContextEntityContainer()
    End Function
    
    ''' <summary>
    ''' Service contract for the 'VBRootNamespaceTestDomainService' DomainService.
    ''' </summary>
    <ServiceContract()>  _
    Public Interface IVBRootNamespaceTestDomainServiceContract
        
        ''' <summary>
        ''' Asynchronously invokes the 'M' operation.
        ''' </summary>
        ''' <param name="callback">Callback to invoke on completion.</param>
        ''' <param name="asyncState">Optional state object.</param>
        ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
        <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/VBRootNamespaceTestDomainService/MDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
         OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/VBRootNamespaceTestDomainService/M", ReplyAction:="http://tempuri.org/VBRootNamespaceTestDomainService/MResponse"),  _
         WebGet()>  _
        Function BeginM(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
        
        ''' <summary>
        ''' Completes the asynchronous operation begun by 'BeginM'.
        ''' </summary>
        ''' <param name="result">The IAsyncResult returned from 'BeginM'.</param>
        ''' <returns>The 'QueryResult' returned from the 'M' operation.</returns>
        Function EndM(ByVal result As IAsyncResult) As QueryResult(Of VBRootNamespaceDomainObject)
        
        ''' <summary>
        ''' Asynchronously invokes the 'M4' operation.
        ''' </summary>
        ''' <param name="callback">Callback to invoke on completion.</param>
        ''' <param name="asyncState">Optional state object.</param>
        ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
        <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/VBRootNamespaceTestDomainService/M4DomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
         OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/VBRootNamespaceTestDomainService/M4", ReplyAction:="http://tempuri.org/VBRootNamespaceTestDomainService/M4Response"),  _
         WebGet()>  _
        Function BeginM4(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
        
        ''' <summary>
        ''' Completes the asynchronous operation begun by 'BeginM4'.
        ''' </summary>
        ''' <param name="result">The IAsyncResult returned from 'BeginM4'.</param>
        ''' <returns>The 'QueryResult' returned from the 'M4' operation.</returns>
        Function EndM4(ByVal result As IAsyncResult) As QueryResult(Of VBRootNamespaceDomainObject4)
    End Interface
    
    Friend NotInheritable Class VBRootNamespaceTestDomainContextEntityContainer
        Inherits EntityContainer
        
        Public Sub New()
            MyBase.New
            Me.CreateEntitySet(Of VBRootNamespaceDomainObject4)(EntitySetOperations.None)
            Me.CreateEntitySet(Of VBRootNamespaceDomainObject)(EntitySetOperations.None)
        End Sub
    End Class
End Class

Namespace Inner
    
    ''' <summary>
    ''' The 'VBRootNamespaceDomainObjectInsideInner' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/VBRootNamespaceTest.Inner")>  _
    Partial Public NotInheritable Class VBRootNamespaceDomainObjectInsideInner
        Inherits Entity
        
        Private _key As Integer
        
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

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceDomainObjectInsideInner"/> class.
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
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'VBRootNamespaceTestProviderInsideInner' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class VBRootNamespaceTestProviderInsideInner
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
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestProviderInsideInner"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of IVBRootNamespaceTestProviderInsideInnerContract)(New Uri("VBRootNamespaceTest-Inner-VBRootNamespaceTestProviderInsideInner.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestProviderInsideInner"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The VBRootNamespaceTestProviderInsideInner service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of IVBRootNamespaceTestProviderInsideInnerContract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestProviderInsideInner"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="VBRootNamespaceDomainObjectInsideInner"/> entity instances that have been loaded into this <see cref="VBRootNamespaceTestProviderInsideInner"/> instance.
        ''' </summary>
        Public ReadOnly Property VBRootNamespaceDomainObjectInsideInners() As EntitySet(Of VBRootNamespaceDomainObjectInsideInner)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of VBRootNamespaceDomainObjectInsideInner)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the set of <see cref="VBRootNamespaceDomainObject3"/> entity instances that have been loaded into this <see cref="VBRootNamespaceTestProviderInsideInner"/> instance.
        ''' </summary>
        Public ReadOnly Property VBRootNamespaceDomainObject3s() As EntitySet(Of VBRootNamespaceDomainObject3)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of VBRootNamespaceDomainObject3)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="VBRootNamespaceDomainObjectInsideInner"/> entity instances using the 'M' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="VBRootNamespaceDomainObjectInsideInner"/> entity instances.</returns>
        Public Function MQuery() As EntityQuery(Of VBRootNamespaceDomainObjectInsideInner)
            Me.ValidateMethod("MQuery", Nothing)
            Return MyBase.CreateQuery(Of VBRootNamespaceDomainObjectInsideInner)("M", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="VBRootNamespaceDomainObject3"/> entity instances using the 'M1' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="VBRootNamespaceDomainObject3"/> entity instances.</returns>
        Public Function M1Query() As EntityQuery(Of VBRootNamespaceDomainObject3)
            Me.ValidateMethod("M1Query", Nothing)
            Return MyBase.CreateQuery(Of VBRootNamespaceDomainObject3)("M1", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New VBRootNamespaceTestProviderInsideInnerEntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'VBRootNamespaceTestProviderInsideInner' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface IVBRootNamespaceTestProviderInsideInnerContract
            
            ''' <summary>
            ''' Asynchronously invokes the 'M' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/MDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/M", ReplyAction:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/MResponse"),  _
             WebGet()>  _
            Function BeginM(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginM'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginM'.</param>
            ''' <returns>The 'QueryResult' returned from the 'M' operation.</returns>
            Function EndM(ByVal result As IAsyncResult) As QueryResult(Of VBRootNamespaceDomainObjectInsideInner)
            
            ''' <summary>
            ''' Asynchronously invokes the 'M1' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/M1DomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/M1", ReplyAction:="http://tempuri.org/VBRootNamespaceTestProviderInsideInner/M1Response"),  _
             WebGet()>  _
            Function BeginM1(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginM1'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginM1'.</param>
            ''' <returns>The 'QueryResult' returned from the 'M1' operation.</returns>
            Function EndM1(ByVal result As IAsyncResult) As QueryResult(Of VBRootNamespaceDomainObject3)
        End Interface
        
        Friend NotInheritable Class VBRootNamespaceTestProviderInsideInnerEntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of VBRootNamespaceDomainObjectInsideInner)(EntitySetOperations.None)
                Me.CreateEntitySet(Of VBRootNamespaceDomainObject3)(EntitySetOperations.None)
            End Sub
        End Class
    End Class
End Namespace

Namespace Other
    
    ''' <summary>
    ''' The 'VBRootNamespaceDomainObject4' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/VBRootNamespaceTest.Other")>  _
    Partial Public NotInheritable Class VBRootNamespaceDomainObject4
        Inherits Entity
        
        Private _key As Integer
        
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

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceDomainObject4"/> class.
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
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
End Namespace

Namespace VBRootNamespaceTest2
    
    ''' <summary>
    ''' The 'VBRootNamespaceDomainObject2' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/VBRootNamespaceTest2")>  _
    Partial Public NotInheritable Class VBRootNamespaceDomainObject2
        Inherits Entity
        
        Private _key As Integer
        
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

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceDomainObject2"/> class.
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
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
    
    ''' <summary>
    ''' The DomainContext corresponding to the 'VBRootNamespaceTestDomainService2' DomainService.
    ''' </summary>
    Partial Public NotInheritable Class VBRootNamespaceTestDomainService2
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
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainService2"/> class.
        ''' </summary>
        Public Sub New()
            Me.New(New WebDomainClient(Of IVBRootNamespaceTestDomainService2Contract)(New Uri("VBRootNamespaceTest2-VBRootNamespaceTestDomainService2.svc", UriKind.Relative)))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainService2"/> class with the specified service URI.
        ''' </summary>
        ''' <param name="serviceUri">The VBRootNamespaceTestDomainService2 service URI.</param>
        Public Sub New(ByVal serviceUri As Uri)
            Me.New(New WebDomainClient(Of IVBRootNamespaceTestDomainService2Contract)(serviceUri))
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceTestDomainService2"/> class with the specified <paramref name="domainClient"/>.
        ''' </summary>
        ''' <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        Public Sub New(ByVal domainClient As DomainClient)
            MyBase.New(domainClient)
            Me.OnCreated
        End Sub
        
        ''' <summary>
        ''' Gets the set of <see cref="VBRootNamespaceDomainObject2"/> entity instances that have been loaded into this <see cref="VBRootNamespaceTestDomainService2"/> instance.
        ''' </summary>
        Public ReadOnly Property VBRootNamespaceDomainObject2s() As EntitySet(Of VBRootNamespaceDomainObject2)
            Get
                Return MyBase.EntityContainer.GetEntitySet(Of VBRootNamespaceDomainObject2)
            End Get
        End Property
        
        ''' <summary>
        ''' Gets an EntityQuery instance that can be used to load <see cref="VBRootNamespaceDomainObject2"/> entity instances using the 'M' query.
        ''' </summary>
        ''' <returns>An EntityQuery that can be loaded to retrieve <see cref="VBRootNamespaceDomainObject2"/> entity instances.</returns>
        Public Function MQuery() As EntityQuery(Of VBRootNamespaceDomainObject2)
            Me.ValidateMethod("MQuery", Nothing)
            Return MyBase.CreateQuery(Of VBRootNamespaceDomainObject2)("M", Nothing, false, true)
        End Function
        
        ''' <summary>
        ''' Creates a new EntityContainer for this DomainContext's EntitySets.
        ''' </summary>
        ''' <returns>A new container instance.</returns>
        Protected Overrides Function CreateEntityContainer() As EntityContainer
            Return New VBRootNamespaceTestDomainService2EntityContainer()
        End Function
        
        ''' <summary>
        ''' Service contract for the 'VBRootNamespaceTestDomainService2' DomainService.
        ''' </summary>
        <ServiceContract()>  _
        Public Interface IVBRootNamespaceTestDomainService2Contract
            
            ''' <summary>
            ''' Asynchronously invokes the 'M' operation.
            ''' </summary>
            ''' <param name="callback">Callback to invoke on completion.</param>
            ''' <param name="asyncState">Optional state object.</param>
            ''' <returns>An IAsyncResult that can be used to monitor the request.</returns>
            <FaultContract(GetType(DomainServiceFault), Action:="http://tempuri.org/VBRootNamespaceTestDomainService2/MDomainServiceFault", Name:="DomainServiceFault", [Namespace]:="DomainServices"),  _
             OperationContract(AsyncPattern:=true, Action:="http://tempuri.org/VBRootNamespaceTestDomainService2/M", ReplyAction:="http://tempuri.org/VBRootNamespaceTestDomainService2/MResponse"),  _
             WebGet()>  _
            Function BeginM(ByVal callback As AsyncCallback, ByVal asyncState As Object) As IAsyncResult
            
            ''' <summary>
            ''' Completes the asynchronous operation begun by 'BeginM'.
            ''' </summary>
            ''' <param name="result">The IAsyncResult returned from 'BeginM'.</param>
            ''' <returns>The 'QueryResult' returned from the 'M' operation.</returns>
            Function EndM(ByVal result As IAsyncResult) As QueryResult(Of VBRootNamespaceDomainObject2)
        End Interface
        
        Friend NotInheritable Class VBRootNamespaceTestDomainService2EntityContainer
            Inherits EntityContainer
            
            Public Sub New()
                MyBase.New
                Me.CreateEntitySet(Of VBRootNamespaceDomainObject2)(EntitySetOperations.None)
            End Sub
        End Class
    End Class
End Namespace

Namespace VBRootNamespaceTest3
    
    ''' <summary>
    ''' The 'VBRootNamespaceDomainObject3' entity class.
    ''' </summary>
    <DataContract([Namespace]:="http://schemas.datacontract.org/2004/07/VBRootNamespaceTest3")>  _
    Partial Public NotInheritable Class VBRootNamespaceDomainObject3
        Inherits Entity
        
        Private _key As Integer
        
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

        #End Region
        
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="VBRootNamespaceDomainObject3"/> class.
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
        ''' Computes a value from the key fields that uniquely identifies this entity instance.
        ''' </summary>
        ''' <returns>An object instance that uniquely identifies this entity instance.</returns>
        Public Overrides Function GetIdentity() As Object
            Return Me._key
        End Function
    End Class
End Namespace
