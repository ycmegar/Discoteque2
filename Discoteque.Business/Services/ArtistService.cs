using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public class ArtistService : IArtistService
{
    public Task<Artist> CreateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> GetArtistById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}