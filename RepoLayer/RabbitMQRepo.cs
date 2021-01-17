using Microsoft.Extensions.Options;
using ModelLayer.Rabbit;
using ModelLayer.Rabbit.Infc;

namespace RepoLayer
{
    public class RabbitMQRepo : IRabbitMQRepo
    {
        private readonly IRabbitManager _rabbitManager;

        private readonly IOptions<RabbitOptions> _rabbitOptions;

        public RabbitMQRepo(IRabbitManager rabbitManager, IOptions<RabbitOptions> rabbitOptions)
        {
            _rabbitOptions = rabbitOptions;
            _rabbitManager = rabbitManager;
        }

        public string PublishRabbitMQ(string msg)
        {
            _rabbitManager.Publish(msg,_rabbitOptions.Value.ExchangeName,
                _rabbitOptions.Value.ExchangeType,_rabbitOptions.Value.RoutingKey);
            return "Message send to queue";
        }
    }
}
