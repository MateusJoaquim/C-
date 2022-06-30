using System.Runtime.Serialization;

[Serializable]
internal class MinhaException : Exception
{
    private DateTime now;

    public MinhaException()
    {
    }

    public MinhaException(DateTime now)
    {
        this.now = now;
    }

    public MinhaException(string? message) : base(message)
    {
    }

    public MinhaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MinhaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}