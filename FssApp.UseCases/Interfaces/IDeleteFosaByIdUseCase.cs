namespace FssApp.UseCases.Interfaces
{
    public interface IDeleteFosaByIdUseCase
    {
        Task ExecuteAsync(int fosaId);
    }
}