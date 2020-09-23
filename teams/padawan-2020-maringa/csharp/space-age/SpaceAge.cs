using System;
using System.IO.Pipes;

public class SpaceAge
{
    private const double anoTerra = 31557600;
    public double Seconds { get; set; }

    public SpaceAge(int seconds) => Seconds = seconds;
 

    public double OnEarth()
    {
        return Seconds / anoTerra ;
    }

    public double OnMercury()
    {
        var anoMercurio = anoTerra * 0.2408467;
        return Seconds / anoMercurio;
    }

    public double OnVenus()
    {
        var anoVenus = anoTerra * 0.6151972;
        return Seconds / anoVenus;

    }

    public double OnMars()
    {
        var anoMarte = anoTerra * 1.8808158;
        return Seconds / anoMarte;
    }

    public double OnJupiter()
    {
        var anoJupiter = anoTerra * 11.862615;
        return Seconds / anoJupiter;
    }

    public double OnSaturn()
    {
        var anoSaturno = anoTerra * 29.447498;
        return Seconds / anoSaturno;
    }

    public double OnUranus()
    {
        var anoUrano = anoTerra * 84.016846;
        return Seconds / anoUrano;
    }

    public double OnNeptune()
    {
        var anoNetuno = anoTerra * 164.79132;
        return Seconds / anoNetuno;
    }
}