// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.ServiceModel;
using Moryx.Tools.Wcf;

namespace Moryx.TestModule
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IHelloWorldWcfServiceCallback))]
    [ServiceVersion(ServerVersion = HelloWorldWcfService.ServerVersion, MinClientVersion = HelloWorldWcfService.MinClientVersion)]
    public interface IHelloWorldWcfService : ISessionService
    {
        [OperationContract(IsOneWay = false)]
        string Hello(string name);

        [OperationContract(IsOneWay = false)]
        string Throw(string name);

        [OperationContract(IsOneWay = true)]
        void TriggerHelloCallback(string name);

        [OperationContract(IsOneWay = true)]
        void TriggerThrowCallback(string name);

        void HelloCallback(string message);

        string ThrowCallback(string message);

        [OperationContract(IsOneWay = true)]
        void DeferredDisconnect(int waitInMs);
    }
}
