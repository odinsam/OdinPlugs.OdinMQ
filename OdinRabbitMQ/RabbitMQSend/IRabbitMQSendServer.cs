using OdinPlugs.OdinInject.InjectInterface;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQConfigModel;
using OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQModel;

namespace OdinPlugs.OdinMQ.OdinRabbitMQ.RabbitMQSend
{
    public interface IRabbitMQSendServer : IAutoInject
    {
        void SendToRabbitMQ(RabbitMQOptions rabbitMQ, RabbitMQSendModel sendModel);
    }
}