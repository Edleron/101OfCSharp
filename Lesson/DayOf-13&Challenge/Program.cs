namespace DayOf_13_Challenge;

class Program
{
    static void Main(string[] args)
    {
        StateOne();
        StateTwo();
        StateThree();
    }

    #region State - 1
    static void StateOne()
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        int count = 0;
        while (count < 20)
        {
            Console.Write("Pozitif bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    nonPrimeNumbers.Add(number);
                }
                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir sayı giriniz.");
            }
        }

        primeNumbers.Sort();
        primeNumbers.Reverse();
        nonPrimeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        Console.WriteLine("Asal Sayılar:");
        foreach (int prime in primeNumbers)
        {
            Console.WriteLine(prime);
        }

        Console.WriteLine("Asal Olmayan Sayılar:");
        foreach (int nonPrime in nonPrimeNumbers)
        {
            Console.WriteLine(nonPrime);
        }

        Console.WriteLine($"Asal Sayılar Toplam: {primeNumbers.Count}, Ortalama: {CalculateAverage(primeNumbers)}");
        Console.WriteLine($"Asal Olmayan Sayılar Toplam: {nonPrimeNumbers.Count}, Ortalama: {CalculateAverage(nonPrimeNumbers)}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0)
            return 0;
        double sum = 0;
        foreach (int number in list)
        {
            sum += number;
        }
        return sum / list.Count;
    }

    #endregion

    #region State - 2
    static void StateTwo()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Tekrar deneyin.");
                i--;
            }
        }

        Array.Sort(numbers);

        int[] enBuyukUc = new int[3];
        int[] enKucukUc = new int[3];

        for (int i = 0; i < 3; i++)
        {
            enBuyukUc[i] = numbers[19 - i];
            enKucukUc[i] = numbers[i];
        }

        double enBuyukUcOrtalama = CalculateAverage(enBuyukUc);
        double enKucukUcOrtalama = CalculateAverage(enKucukUc);

        Console.WriteLine("En Büyük 3 Sayılar:");
        foreach (int num in enBuyukUc)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"En Büyük 3 Sayılar Ortalama: {enBuyukUcOrtalama}");

        Console.WriteLine("En Küçük 3 Sayılar:");
        foreach (int num in enKucukUc)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"En Küçük 3 Sayılar Ortalama: {enKucukUcOrtalama}");

        Console.WriteLine($"Toplam Ortalama: {(enBuyukUcOrtalama + enKucukUcOrtalama) / 2}");
    }

    static double CalculateAverage(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }
    #endregion

    #region State - 3
    static void StateThree()
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        char[] sesliHarfDizisi = CumledekiSesliHarfleriBul(cumle);

        Array.Sort(sesliHarfDizisi);

        Console.WriteLine("Sesli Harfler Sıralı:");

        foreach (char harf in sesliHarfDizisi)
        {
            Console.WriteLine(harf);
        }
    }

    static bool SesliHarfMi(char harf)
    {
        char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return sesliHarfler.Contains(harf);
    }

    static char[] CumledekiSesliHarfleriBul(string cumle)
    {
        char[] sesliHarfDizisi = cumle.Where(c => SesliHarfMi(c)).ToArray();
        return sesliHarfDizisi;
    }
    #endregion
}
