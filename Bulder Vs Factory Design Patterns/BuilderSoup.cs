namespace Bulder_Vs_Factory_Design_Patterns
{
    //Builder Pattern
    public class BuilderSoup
    {
        public int MushroomAmount { get; set; }
        public int CarrotAmout { get; set; }
        public int TomatoAmount { get; set; }
        public List<string> Flavours { get; set; } = new List<string>();
    }
    public class BuilderSoupBuilder
    {
        private BuilderSoup _builderSoup = new BuilderSoup();
        public BuilderSoupBuilder AddMushroom(int mushroomAmount)
        {
            _builderSoup.MushroomAmount = mushroomAmount;
            return this;
        }

        public BuilderSoupBuilder AddCarrot(int carrotAmout)
        {
            _builderSoup.CarrotAmout = carrotAmout;
            return this;
        }

        public BuilderSoupBuilder AddTomato(int tomatoAmount)
        {
            _builderSoup.TomatoAmount = tomatoAmount;
            return this;
        }

        public BuilderSoupBuilder AddFlavours(string flavours)
        {
            _builderSoup.Flavours.Add(flavours);
            return this;
        }

        public BuilderSoup Buid()
        { return _builderSoup; }
    }

}
