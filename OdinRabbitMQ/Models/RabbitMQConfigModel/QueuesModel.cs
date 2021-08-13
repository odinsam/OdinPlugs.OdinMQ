namespace OdinPlugs.OdinMQ.OdinRabbitMQ.Models.RabbitMQConfigModel
{
    public class QueuesModel
    {
        public string QueuesName { get; set; }
        public bool Durable { get; set; } = true;
        public string RoutingKey { get; set; }
        public bool AutoDelete { get; set; } = false;
        public bool Exclusive { get; set; } = false;
        public ArgumentsModel[] Arguments { get; set; }
    }
}