using Firestore.Interfaces;
using Google.Cloud.Firestore;

namespace Firestore.Models;

/// <summary>
/// Represents a user that will be stored in firestore.
/// </summary>
[FirestoreData]
public class User : IBaseFirestoreData
{
    /// <inheritdoc />
    public string Id { get; set; }

    /// <inheritdoc />
    [FirestoreProperty]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the surname of the user.
    /// </summary>
    [FirestoreProperty]
    public string Surname { get; set; }

    /// <summary>
    /// Gets or sets the gender of the user.
    /// </summary>
    [FirestoreProperty]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or sets the city of the user.
    /// </summary>
    [FirestoreProperty]
    public City CityFrom { get; set; }

    /// <summary>
    /// Gets or sets a property that will not be saved.
    /// </summary> 
    public string NotSavedProperty { get; set; }
}

