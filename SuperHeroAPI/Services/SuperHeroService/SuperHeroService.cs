namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = ";alibu"
                },
                new SuperHero
                {
                    Id = 3,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham City"
                },

            };

        public SuperHero AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public SuperHero DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public SuperHero GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> GetSuperHeroes()
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
            {
                return null;
            }
            superHeroes.Remove(hero);
            return superHeroes;
        }
    }
}
