namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetSuperHeroes();
        SuperHero GetSingleHero(int id);
        SuperHero AddHero(SuperHero hero);
        SuperHero UpdateHero(int id, SuperHero request);
        SuperHero DeleteeHero(int id);
    }
}
