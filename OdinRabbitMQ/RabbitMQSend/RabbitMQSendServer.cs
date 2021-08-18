using OdinPlugs.OdinModels.ConfigModel.RabbitMQ;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinMQ.OdinRabbitMQ.RabbitMQSend
{
    public class RabbitMQSendServer : AbstractRabbitMQSendServer
    {
        public override void SendToRabbitMQ(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel)
        {
            base.SendJsonMessage(rabbitMQ, sendModel);
        }
    }
}