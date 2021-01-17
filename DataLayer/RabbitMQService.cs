using RepoLayer;

namespace DataLayer
{
    public class RabbitMQService : IRabbitMQService
    {
        public RabbitMQService(IRabbitMQRepo ops)
        {
            this.Repository = ops;
        }

        public IRabbitMQRepo Repository { get; set; }

        public string PublishRabbitMQ(string msg)
        {
            return Repository.PublishRabbitMQ(msg);
        }
    }
}
