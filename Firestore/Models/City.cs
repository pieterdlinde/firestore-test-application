using Firestore.Interfaces;
using Google.Cloud.Firestore;

namespace Firestore.Models;

/// <summary>
/// Represents a city that will be stored in firestore.
/// </summary>
[FirestoreData]
public class City: IBaseFirestoreData
{
    /// <inheritdoc />
    public string Id { get; set; }

    /// <inheritdoc />
    [FirestoreProperty]
    public string Name { get; set; }
}
