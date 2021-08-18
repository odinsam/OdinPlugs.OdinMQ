using System;
using OdinPlugs.OdinModels.ConfigModel.RabbitMQ;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinMQ.OdinRabbitMQ.RabbitMQReceive
{
    public class RabbitMQReceiveServer : AbstractRabbitMQReceiveServer
    {
        public override void ReceiveJsonMessage(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel)
        {
            base.ReceiveMessage(rabbitMQ, receivedModel);
        }

        public override void ReceiveJsonMessageByEvent(RabbitMQOptions rabbitMQ, RabbitMQReceivedModel[] receivedModel)
        {
            base.ReceiveMessageByEvent(rabbitMQ, receivedModel);
        }
    }
}