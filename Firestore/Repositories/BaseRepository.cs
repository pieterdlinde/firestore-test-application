using Firestore.Interfaces;
using Google.Cloud.Firestore;

namespace Firestore.Repositories;

public class BaseRepository<T>: IBaseRepository<T>
{
    private readonly string _collectionName;
    public FirestoreDb _firestoreDb;

    public BaseRepository(string collectionName)
    {
        _collectionName = collectionName;

    }

    public async Task<T> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
