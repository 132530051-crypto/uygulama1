namespace uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool oduncte = false;

            Console.Write("Kaç gün? ");
            string? giris = Console.ReadLine();

            if (!int.TryParse(giris, out int gun) || gun < 1 || gun > 7)
            {
                Console.WriteLine("1-7 arası sayı girin.");
            }
            else if (oduncte)
            {
                Console.WriteLine("Uygun değil: Ekipman ödünçte.");
            }
            else
            {
                Console.WriteLine($"Süre: {gun} gün - Ödünç verilebilir.");
            }
        }
    }
}
