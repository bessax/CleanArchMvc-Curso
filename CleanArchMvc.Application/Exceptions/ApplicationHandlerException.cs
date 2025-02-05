namespace CleanArchMvc.Application.Exceptions;

public class ApplicationHandlerException : Exception
{
    public ApplicationHandlerException()
    {
    }

    public ApplicationHandlerException(string? message) : base(message)
    {
    }

    public ApplicationHandlerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}