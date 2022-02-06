using Movies.Domain.Commands.Contracts;

namespace Movies.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }
        public object Data { get; private set; }

        public GenericCommandResult(string message, bool success, object data)
        {
            Message = message;
            Success = success;
            Data = data;
        }
    }
}
