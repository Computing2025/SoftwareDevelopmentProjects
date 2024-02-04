namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new (new NewEStateUserValidationManager());

            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                BirthYear = 1980,
                IdentityNumber = 123421
            });
        }
    }
}
