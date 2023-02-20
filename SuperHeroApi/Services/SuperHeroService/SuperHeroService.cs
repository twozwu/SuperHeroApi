using SuperHeroApi.Models;

namespace SuperHeroApi.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        public Task<List<SuperHero>> AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>?> DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>> GetAllHeroes()
        {
            throw new NotImplementedException();
        }

        public Task<SuperHero?> GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperHero>?> UpdateHero(int id, SuperHero request)
        {
            throw new NotImplementedException();
        }
    }
}
