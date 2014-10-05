﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591  // "Missing XML comment..."


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="INodeXLGraphGalleryService")]
public interface INodeXLGraphGalleryService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraph", ReplyAction="http://tempuri.org/INodeXLGraphGalleryService/AddGraphResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraphStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    void AddGraph(string title, string author, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, string graphML);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraphWithCredentials", ReplyAction="http://tempuri.org/INodeXLGraphGalleryService/AddGraphWithCredentialsResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraphWithCredentialsStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    void AddGraphWithCredentials(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, string graphML);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraph3", ReplyAction="http://tempuri.org/INodeXLGraphGalleryService/AddGraph3Response")]
    [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraph3StringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    void AddGraph3(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, byte[] workbook, string workbookSettings, string graphML);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraph4", ReplyAction="http://tempuri.org/INodeXLGraphGalleryService/AddGraph4Response")]
    [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/INodeXLGraphGalleryService/AddGraph4StringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    void AddGraph4(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, byte[] workbook, string workbookSettings, byte[] graphMLZipped);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeXLGraphGalleryService/GetTestString", ReplyAction="http://tempuri.org/INodeXLGraphGalleryService/GetTestStringResponse")]
    string GetTestString(int numberToIncludeInString);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface INodeXLGraphGalleryServiceChannel : INodeXLGraphGalleryService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class NodeXLGraphGalleryServiceClient : System.ServiceModel.ClientBase<INodeXLGraphGalleryService>, INodeXLGraphGalleryService
{
    
    public NodeXLGraphGalleryServiceClient()
    {
    }
    
    public NodeXLGraphGalleryServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public NodeXLGraphGalleryServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public NodeXLGraphGalleryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public NodeXLGraphGalleryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddGraph(string title, string author, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, string graphML)
    {
        base.Channel.AddGraph(title, author, description, spaceDelimitedTags, fullSizeImage, thumbnail, graphML);
    }
    
    public void AddGraphWithCredentials(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, string graphML)
    {
        base.Channel.AddGraphWithCredentials(title, author, password, description, spaceDelimitedTags, fullSizeImage, thumbnail, graphML);
    }
    
    public void AddGraph3(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, byte[] workbook, string workbookSettings, string graphML)
    {
        base.Channel.AddGraph3(title, author, password, description, spaceDelimitedTags, fullSizeImage, thumbnail, workbook, workbookSettings, graphML);
    }
    
    public void AddGraph4(string title, string author, string password, string description, string spaceDelimitedTags, byte[] fullSizeImage, byte[] thumbnail, byte[] workbook, string workbookSettings, byte[] graphMLZipped)
    {
        base.Channel.AddGraph4(title, author, password, description, spaceDelimitedTags, fullSizeImage, thumbnail, workbook, workbookSettings, graphMLZipped);
    }
    
    public string GetTestString(int numberToIncludeInString)
    {
        return base.Channel.GetTestString(numberToIncludeInString);
    }
}