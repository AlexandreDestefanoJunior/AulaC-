using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int Mask;
    public Allergies(int mask)
    {
        Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);
    }

    public Allergen[] List()
    {
        List<Allergen> individualAllergens = new List<Allergen>();
        foreach (var allergy in Enum.GetValues(typeof(Allergen)))
        {
            if ((Mask & (int)allergy) > 0) individualAllergens.Add((Allergen)allergy);
        }
        return individualAllergens.ToArray();
    }
}