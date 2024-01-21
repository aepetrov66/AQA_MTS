using System.Runtime.CompilerServices;
using System.Text;

namespace Task4;

public static class Generator
{
    public static Auto[] GenAutoArray(int amount)
    {
        Auto[] array = new Auto[amount];
        for (int i = 0; i < amount; i++)
        {
            array[i] = GenAuto(GenBrand(), GenNumber(), new Random().Next(0, 9)/10.0 + new Random().Next(10, 90), new Random().Next(0, 9)/10.0 + new Random().Next(10, 90), new Random().NextDouble() < 0.5);
        }
        return array;
    }
    
    public static Auto GenAuto(string brand, string number, double speed, double loadCapacity, bool trailerOrSidecar)
    {
        int spin = new Random().Next(0, 3);
        switch (spin)
        {
            case 0: return new Car(brand, number, speed, loadCapacity);
            case 1: return new Bike(brand, number, speed, loadCapacity, trailerOrSidecar);
            case 2: return new Truck(brand, number, speed, loadCapacity, trailerOrSidecar);
            default: return new Car(brand, number, speed, loadCapacity);
        }
    }

    public static string GenBrand()
    {
        string[] CarBrands = { "Toyota", "Ford", "BMW", "Honda", "Chevrolet" };
        return CarBrands[new Random().Next(0, CarBrands.Length)];
    }

    public static string GenNumber()
    {
        string alphabet = "абвекмснорсух";
        string number = "";
        number += alphabet[new Random().Next(0, alphabet.Length)];
        number += Convert.ToString(new Random().Next(0, 9));
        number += Convert.ToString(new Random().Next(0, 9));
        number += Convert.ToString(new Random().Next(0, 9));
        number += alphabet[new Random().Next(0, alphabet.Length)];
        number += alphabet[new Random().Next(0, alphabet.Length)];
        return number;
    }


}
