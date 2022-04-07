namespace TesteAPI.Shared.Interfaces
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        string Message { get; set; }
        dynamic Data { get; set; }
    }
}
