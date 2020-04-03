﻿// AUTO GENERATED
//     This code was generated by signalgo add refenreces.
//     Runtime Version : 4.6.3.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     to download signalgo vsix for visual studio go https://marketplace.visualstudio.com/items?itemName=AliVisualStudio.SignalGoExtension
//     support and use signalgo go https://github.com/SignalGo/SignalGo-full-net
// AUTO GENERATED
using SignalGo.Shared.DataTypes;
using System.Threading.Tasks;
using SignalGo.Shared.Models;
using ServerManagerService.Interfaces;
using ServerManagerService.ServerServices;
using ServerManagerService.HttpServices;
using ServerManagerService.ClientServices;
using System;
namespace ServerManagerService.Interfaces
{

    [ServiceContract("serverstreammanagerstreamservice", ServiceType.StreamService, InstanceType.SingleInstance)]
    public partial interface IServerManagerStreamService
    {
        string UploadData(SignalGo.Shared.Models.StreamInfo streamInfo);
        Task<string> UploadDataAsync(SignalGo.Shared.Models.StreamInfo streamInfo);
        bool ExtractArchive(string archive);
        Task<bool> ExtractArchiveAsync(string archive);
    }
    [ServiceContract("servermanagerserverservice", ServiceType.ServerService, InstanceType.SingleInstance)]
    public partial interface IServerManagerService
    {
        bool StopServer(System.Guid serverKey, string name);
        Task<bool> StopServerAsync(System.Guid serverKey, string name);
        bool StartServer(System.Guid serverKey, string name);
        Task<bool> StartServerAsync(System.Guid serverKey, string name);
        bool RestartServer(System.Guid serverKey, string name, bool force);
        Task<bool> RestartServerAsync(System.Guid serverKey, string name, bool force);
        string CallClientService(string message);
        Task<string> CallClientServiceAsync(string message);
        string SayHello(string name);
        Task<string> SayHelloAsync(string name);
    }
}

namespace ServerManagerService.ServerServices
{
    [ServiceContract("servermanagerserverservice",ServiceType.ServerService, InstanceType.SingleInstance)]
    public partial class ServerManagerService : IServerManagerService
    {
        private SignalGo.Client.ClientProvider CurrentProvider { get; set; }
        string ServiceName { get; set; }
        public ServerManagerService(SignalGo.Client.ClientProvider clientProvider)
        {
            CurrentProvider = clientProvider;
            ServiceName = this.GetType().GetServerServiceName(true);
        }
        public bool StopServer(System.Guid serverKey, string name)
        {
                return  SignalGo.Client.ClientManager.ConnectorExtensions.SendDataSync<bool>(CurrentProvider, ServiceName,"StopServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
        public Task<bool> StopServerAsync(System.Guid serverKey, string name)
        {
                return SignalGo.Client.ClientManager.ConnectorExtensions.SendDataAsync<bool>(CurrentProvider, ServiceName,"StopServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
        public bool StartServer(System.Guid serverKey, string name)
        {
                return  SignalGo.Client.ClientManager.ConnectorExtensions.SendDataSync<bool>(CurrentProvider, ServiceName,"StartServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
        public Task<bool> StartServerAsync(System.Guid serverKey, string name)
        {
                return SignalGo.Client.ClientManager.ConnectorExtensions.SendDataAsync<bool>(CurrentProvider, ServiceName,"StartServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
        public bool RestartServer(System.Guid serverKey, string name, bool force)
        {
                return  SignalGo.Client.ClientManager.ConnectorExtensions.SendDataSync<bool>(CurrentProvider, ServiceName,"RestartServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(force),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(force) },
                });
        }
        public Task<bool> RestartServerAsync(System.Guid serverKey, string name, bool force)
        {
                return SignalGo.Client.ClientManager.ConnectorExtensions.SendDataAsync<bool>(CurrentProvider, ServiceName,"RestartServer", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(serverKey),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(serverKey) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(force),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(force) },
                });
        }
        public string CallClientService(string message)
        {
                return  SignalGo.Client.ClientManager.ConnectorExtensions.SendDataSync<string>(CurrentProvider, ServiceName,"CallClientService", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(message),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(message) },
                });
        }
        public Task<string> CallClientServiceAsync(string message)
        {
                return SignalGo.Client.ClientManager.ConnectorExtensions.SendDataAsync<string>(CurrentProvider, ServiceName,"CallClientService", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(message),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(message) },
                });
        }
        public string SayHello(string name)
        {
                return  SignalGo.Client.ClientManager.ConnectorExtensions.SendDataSync<string>(CurrentProvider, ServiceName,"SayHello", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
        public Task<string> SayHelloAsync(string name)
        {
                return SignalGo.Client.ClientManager.ConnectorExtensions.SendDataAsync<string>(CurrentProvider, ServiceName,"SayHello", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(name),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(name) },
                });
        }
    }
}

namespace ServerManagerService.StreamServices
{
    [ServiceContract("serverstreammanagerstreamservice",ServiceType.StreamService, InstanceType.SingleInstance)]
    public partial class ServerManagerStreamService : IServerManagerStreamService
    {
        public string ServerAddress { get; set; }
        public int? Port { get; set; }
        private string ServiceName { get; set; }

        private SignalGo.Client.ClientProvider CurrentProvider { get; set; }
        public ServerManagerStreamService(SignalGo.Client.ClientProvider clientProvider = null)
        {
            CurrentProvider = clientProvider;
            ServiceName = GetType().GetServerServiceName(true);
        }

        public ServerManagerStreamService(string serverAddress = null, int? port = null, SignalGo.Client.ClientProvider clientProvider = null)
        {
            ServerAddress = serverAddress;
            Port = port;
            CurrentProvider = clientProvider;
            ServiceName = GetType().GetServerServiceName(true);
        }
        public string UploadData(SignalGo.Shared.Models.StreamInfo streamInfo)
        {
                return  SignalGo.Client.ClientProvider.UploadStreamSync<string>(CurrentProvider, ServerAddress, Port, ServiceName ,"UploadData", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(streamInfo),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(streamInfo) },
                }, streamInfo);
        }
        public Task<string> UploadDataAsync(SignalGo.Shared.Models.StreamInfo streamInfo)
        {
                return SignalGo.Client.ClientProvider.UploadStreamAsync<string>(CurrentProvider, ServerAddress, Port, ServiceName ,"UploadData", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(streamInfo),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(streamInfo) },
                }, streamInfo);
        }
        public bool ExtractArchive(string archive)
        {
                return  SignalGo.Client.ClientProvider.UploadStreamSync<bool>(CurrentProvider, ServerAddress, Port, ServiceName ,"ExtractArchive", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(archive),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(archive) },
                }, null);
        }
        public Task<bool> ExtractArchiveAsync(string archive)
        {
                return SignalGo.Client.ClientProvider.UploadStreamAsync<bool>(CurrentProvider, ServerAddress, Port, ServiceName ,"ExtractArchive", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(archive),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(archive) },
                }, null);
        }
    }
}

namespace ServerManagerService.OneWayServices
{
}

namespace ServerManagerService.HttpServices
{
    public partial class ServerManagerStreamService : IServerManagerStreamService
    {
        public ServerManagerStreamService(string serverUrl, SignalGo.Client.HttpClient httpClient = null)
        {
            _serverUrl = serverUrl;
            _httpClient = httpClient;
            if (_httpClient == null)
                _httpClient = new SignalGo.Client.HttpClient();
        }

        private readonly string _serverUrl = null;
        private SignalGo.Client.HttpClient _httpClient;
        public SignalGo.Shared.Http.WebHeaderCollection RequestHeaders
        {
            get
            {
                return _httpClient.RequestHeaders;
            }
            set
            {
                _httpClient.RequestHeaders = value;
            }
        }

        public SignalGo.Shared.Http.WebHeaderCollection ResponseHeaders { get; set; }
        public System.Net.HttpStatusCode Status { get; set; }
        public static ServerManagerStreamService Current { get; set; }
        public string UploadData(SignalGo.Shared.Models.StreamInfo streamInfo)
        {
                SignalGo.Client.HttpClientResponse result = _httpClient.Post(_serverUrl + (_serverUrl.EndsWith("/") ? "" : "/") + "serverstreammanager/UploadData", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(streamInfo),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(streamInfo) },
                }, streamInfo);
                ResponseHeaders = result.ResponseHeaders;
                Status = result.Status;
                if (Status == System.Net.HttpStatusCode.InternalServerError)
                        throw new Exception(result.Data);
                return SignalGo.Client.ClientSerializationHelper.DeserializeObject<string>(result.Data);
        }
        public async Task<string> UploadDataAsync(SignalGo.Shared.Models.StreamInfo streamInfo)
        {
                SignalGo.Client.HttpClientResponse result = await _httpClient.PostAsync(_serverUrl + (_serverUrl.EndsWith("/") ? "" : "/") + "serverstreammanager/UploadData", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(streamInfo),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(streamInfo) },
                }, streamInfo);
                ResponseHeaders = result.ResponseHeaders;
                Status = result.Status;
                if (Status == System.Net.HttpStatusCode.InternalServerError)
                        throw new Exception(result.Data);
                return SignalGo.Client.ClientSerializationHelper.DeserializeObject<string>(result.Data);
        }
        public bool ExtractArchive(string archive)
        {
                SignalGo.Client.HttpClientResponse result = _httpClient.Post(_serverUrl + (_serverUrl.EndsWith("/") ? "" : "/") + "serverstreammanager/ExtractArchive", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(archive),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(archive) },
                });
                ResponseHeaders = result.ResponseHeaders;
                Status = result.Status;
                if (Status == System.Net.HttpStatusCode.InternalServerError)
                        throw new Exception(result.Data);
                return SignalGo.Client.ClientSerializationHelper.DeserializeObject<bool>(result.Data);
        }
        public async Task<bool> ExtractArchiveAsync(string archive)
        {
                SignalGo.Client.HttpClientResponse result = await _httpClient.PostAsync(_serverUrl + (_serverUrl.EndsWith("/") ? "" : "/") + "serverstreammanager/ExtractArchive", new SignalGo.Shared.Models.ParameterInfo[]
                {
                         new  SignalGo.Shared.Models.ParameterInfo() { Name = nameof(archive),Value = SignalGo.Client.ClientSerializationHelper.SerializeObject(archive) },
                });
                ResponseHeaders = result.ResponseHeaders;
                Status = result.Status;
                if (Status == System.Net.HttpStatusCode.InternalServerError)
                        throw new Exception(result.Data);
                return SignalGo.Client.ClientSerializationHelper.DeserializeObject<bool>(result.Data);
        }
    }
}

namespace ServerManagerService.ClientServices
{
}

