namespace CSharpMosh
{
    public enum ShippingMethode
    {
        RegulerAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethode.Express;
            //Console.WriteLine((int)method);
            //Console.WriteLine(method);   should find the different !!
            var methodId = 3;
            Console.WriteLine((ShippingMethode)methodId);
        }
    }


}