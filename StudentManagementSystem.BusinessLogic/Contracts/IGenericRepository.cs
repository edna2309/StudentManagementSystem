namespace StudentManagementSystem.BusinessLogic.Contracts
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T?> GetAsync(int? id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> Exists(int id);
    }
}
