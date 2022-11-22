using System;

namespace Address
{
    public class Address
    {
        private string indecs;
        private string krayina;
        private string misto;
        private string vulitsya;
        private string dim;
        private int nomer;

        public string Indecs { get => index; set => index = value; }
        public string Krayina { get => krayina; set => ktayina = value; }
        public string Misto { get => misto; set => misto = value; }
        public string Vulitsya { get => vulitsya; set => vulitsya = value; }
        public string Dim { get => dim; set => dim = value; }
        public int nomer { get => nomer; set => nomer = value; }

        public override string ToString()
        {
            return $"{Indecs}, {Krayina}: {Misto}; {Vulitsya} {Dim}, {nomer}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Indecs = "07201",
                Krayina = "Ukraine",
                Misto = "Ivankiv",
                Vulitsya = "8 March",
                Dim = "6",
                Nomer = ""
            };

            Console.WriteLine(address.ToString());
        }
    }
}
