namespace MTGManager.Infrastructure
{
    class DbInitializer
    {
        public static void Initialize(CardDbContext cardDbContext)
        {
            cardDbContext.Database.EnsureCreated();
        }
    }
}
