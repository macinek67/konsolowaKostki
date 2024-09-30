namespace konsolowaKostki
{
    internal class Program
    {
        public static int liczbaKostkek = 0;
        public static List<int> wylosowaneLiczby = new List<int>();
        public static int liczbaPunktow = 0;
        static void Main(string[] args)
        {
            string czyGracDalej = "t";

            while (liczbaKostkek < 3 || liczbaKostkek > 10)
            {
                Console.WriteLine("Ile kostek chcesz rzucic?(3-10)");
                liczbaKostkek = int.Parse(Console.ReadLine());
            }

            while (czyGracDalej == "t")
            {
                losujLiczbyDoKostek();
                liczPunkty();

                Console.WriteLine("Liczba uzyskanych punktow: " + liczbaPunktow);

                wylosowaneLiczby.Clear();
                liczbaPunktow = 0;
                Console.WriteLine("Jeszcze raz? (t/n)");
                czyGracDalej = (string)(Console.ReadLine());
            }
        }

        public static void losujLiczbyDoKostek()
        {
            Random random = new Random();
            for (int i = 1; i <= liczbaKostkek; i++)
            {
                int wylosowanaLiczba = random.Next(1, 7);
                wylosowaneLiczby.Add(wylosowanaLiczba);
                Console.WriteLine("Kostka " + i + ": " + wylosowanaLiczba);
            }
        }

        public static int liczPunkty()
        {
            for (int j = 1; j <= 6; j++)
            {
                int liczPowtorki = 0;
                int wynik = 0;

                for (int i = 0; i < liczbaKostkek; i++)
                {
                    if (wylosowaneLiczby[i] == j)
                    {
                        liczPowtorki++;
                        wynik += j;
                    }
                }

                if (liczPowtorki >= 2)
                {
                    liczbaPunktow += wynik;
                }
            }

            return liczbaPunktow;
        }
    }
}
