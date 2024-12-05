namespace Bulder_Vs_Factory_Design_Patterns
{
    //Factory Pattern
    public class FactorySoup
    {
        public int MushroomAmount { get; set; }
        public int CarrotAmout { get; set; }
        public int TomatoAmount { get; set; }
        public List<string> Flavours { get; set; } = new List<string>();

        public FactorySoup CreateFactorySoup(int mushroomAmount, int carrotAmount, int tomatoAmount, List<string> flavours) 
        {
            return new FactorySoup()
            {
                MushroomAmount = mushroomAmount,
                CarrotAmout = carrotAmount,
                TomatoAmount = tomatoAmount,
                Flavours = flavours
            };
        }
    }
}
