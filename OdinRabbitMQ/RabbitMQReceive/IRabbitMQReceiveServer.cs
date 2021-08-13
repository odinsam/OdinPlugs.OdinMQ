using System;
using OdinPlugs.OdinInject.InjectInterface;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQModel;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace OdinPlugs.OdinMQ.OdinRabbitMQ.RabbitMQReceive
{
    public interface IRabbitMQReceiveServer : IAutoInject
    {
        void ReceiveJsonMessage(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel);
        void ReceiveJsonMessageByEvent(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel);
    }
}