namespace Bulder_Vs_Factory_Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mickaelsBuilderSoup = new BuilderSoupBuilder()
                .AddMushroom(2)
                .AddTomato(1)
                .AddFlavours("pepper")
                .Buid();
            PrintSoup("MickaelsBuilderSoup", mickaelsBuilderSoup);

            var annesBuilderSoup = new BuilderSoupBuilder()
                .AddMushroom(3)
                .AddCarrot(4)
                .AddFlavours("pepper")
                .AddFlavours("lemon juice")
                .Buid();
            PrintSoup("AnnesBuilderSoup", annesBuilderSoup);

            var mickaelsFactorySoup = new FactorySoup()
                .CreateFactorySoup(1, 0, 2, new List<string> { "pepper" });
            PrintSoup("MickaelsFactorySoup", mickaelsFactorySoup);

            var annesFactorySoup = new FactorySoup()
                .CreateFactorySoup(3, 4, 0, new List<string> { "pepper", "lemon juice" });
            PrintSoup("AnnesFactorySoup", annesFactorySoup);

            Console.ReadKey();
        }

        static void PrintSoup(string soupOwner, object soup)
        {
            var soupType = soup.GetType();
            Console.WriteLine(soupOwner + " include: \n" +
                soupType.GetProperty("MushroomAmount")?.GetValue(soup) + " Mushrooms \n" +
                soupType.GetProperty("CarrotAmout")?.GetValue(soup) + " Carrots \n" +
                soupType.GetProperty("TomatoAmount")?.GetValue(soup) + " Tomatoes \n" +
                string.Join(", ", ((List<string>)soupType.GetProperty("Flavours")?.GetValue(soup))?.ToArray()) + " as flavours \n"
                );
        }
    }
}
