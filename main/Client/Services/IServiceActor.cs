using popcorntime.Shared.Entity;
using System.Collections.Generic;

namespace popcorntime.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}