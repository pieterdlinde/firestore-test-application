using Firestore.Enums; 
using Firestore.Models;
using Google.Cloud.Firestore;

namespace Firestore.Repositories;

public class UserRepository
{
    private readonly BaseRepository<User> _repository;
    public UserRepository()
    {
        // This should be injected - This is just an example.
        _repository = new BaseRepository<User>(Collection.Users);
    }

    public async Task<List<User>> GetAllAsync() => await _repository.GetAllAsync<User>(); 

    public async Task<User?> GetAsync(User entity) => (User?) await _repository.GetAsync(entity);

    public async Task<User> AddAsync(User entity) => await _repository.AddAsync(entity);

    public async Task<User> UpdateAsync(User entity) => await _repository.UpdateAsync(entity);

    public async Task DeleteAsync(User entity) => await _repository.DeleteAsync(entity);

    public async Task<List<User>> QueryRecordsAsync(Query query) => await _repository.QueryRecordsAsync<User>(query);

    // This is specific to users.
    public async Task<List<User>> GetUserWhereCity(string cityName)
    {
        var cities = new List<City>()
        {
            new()
            {
                Name=cityName
            }
        };
       
        var query = _repository._firestoreDb.Collection(Collection.Users.ToString()).WhereIn(nameof(User.CityFrom), cities);
        return await this.QueryRecordsAsync(query);
    }
}
