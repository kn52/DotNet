namespace RepoLayer
{
    public interface IRabbitMQRepo
    {
        string PublishRabbitMQ(string msg);
    }
}
