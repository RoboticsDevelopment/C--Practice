using System;
using System.Security.Cryptography;


public class Awesome : IDisposable
{
    private bool disposed = false;
    private RandomNumberGenerator numberGenerator;

    public Awesome()
    {
        Console.WriteLine("Awesome object created.");
        numberGenerator = RandomNumberGenerator.Create();
    }

    public int[] GetPrimeNumberList(int max)
    {
        if (max < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(max), "max must be greater than or equal to 2.");
        }

        int[] primes = new int[max / 2];
        int count = 0;
        for (int i = 2; i <= max; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes[count++] = i;
            }
        }

        Array.Resize(ref primes, count);

        return primes;
    }

    public int CreateRandomNumber(int fromNumber, int toNumber)
    {
        if (fromNumber < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(fromNumber), "fromNumber must be greater than or euqal to 2.");
        }

        if (toNumber <= fromNumber)
        {
            throw new ArgumentOutOfRangeException(nameof(toNumber), "toNumber must be greater than fromNumber.");
        }

        if (!IsPrime(fromNumber) || !IsPrime(toNumber))
        {
            throw new ArgumentException("fromNumber and toNumber must be prime numbers.");
        }

        byte[] randomNumber = new byte[1];
        int range = toNumber - fromNumber;

        if (range < byte.MaxValue)
        {
            range++;
            do
            {
                numberGenerator.GetBytes(randomNumber);
            }
            while (randomNumber[0] >= range * (byte.MaxValue / range));
        }
        else
        {
            int numberOfBytes = (int)Math.Ceiling(Math.Log(range, 256));
            int fullRange = numberOfBytes * byte.MaxValue;

            do
            {
                numberGenerator.GetBytes(randomNumber);
            }
            while (randomNumber[0] >= fullRange - (fullRange % range));
        }
        return (fromNumber + (randomNumber[0] % range));
    }

    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;
        int sqrt = (int)Math.Sqrt(number);
        for (int i = 5; i <= sqrt; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }
        return true;
    }






    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Dispose of managed resources here.
                Console.WriteLine("Awesome object disposed of managed resourses.");
            }

            //Dispose of unmanaged resources here.
            Console.WriteLine("Awesome object disposed of unmanaged resources.");
            numberGenerator.Dispose();
            disposed = true;
        }

    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~Awesome()
    {
        Dispose(false);
    }
}