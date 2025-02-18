namespace TechnicalAirTechTest.Services
{
    public class GreeterService
    {
        private readonly string name;

        public GreeterService(string name)
        {
            this.name = name;
        }

        public void Hello()
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
