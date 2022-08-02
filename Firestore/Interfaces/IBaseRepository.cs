namespace Firestore.Interfaces;

/// <summary>
/// Represents a firestore base repository.
/// </summary>
public interface IBaseRepository<T>
{
    /// <summary>
    /// Gets all record from the repository.
    /// </summary> 
    /// <returns>a record of type T</returns>
    Task<T> GetAllAsync();

    /// <summary>
    /// Gets a record from the repository.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>a record of type T</returns>
    Task<T> GetAsync(T entity);

    /// <summary>
    /// Adds a record to the repository.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>a record of type T</returns>
    Task<T> AddAsync(T entity);

    /// <summary>
    /// Updates a record in the repository.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>a record of type T</returns>
    Task<T> UpdateAsync(T entity);

    /// <summary>
    /// Adds a record to the repository.
    /// </summary>
    /// <param name="entity"></param> S
    Task DeleteAsync(T entity); 
}
