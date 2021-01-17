namespace DataLayer
{
    public interface IRabbitMQService
    {
        string PublishRabbitMQ(string msg);
    }
}
