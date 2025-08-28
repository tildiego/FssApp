namespace FssApp.UseCases.Interfaces
{
    public interface IDeletePrestationByIdUseCase
    {
        Task ExecuteAsync(int fosaId);
    }
}