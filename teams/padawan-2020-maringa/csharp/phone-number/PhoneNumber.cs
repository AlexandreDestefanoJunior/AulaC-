using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var rgxValidacao = new Regex(@"^(?:\+?1)?\D*\(?([2-9]{1}[0-9]{2})\)?\D*([2-9]{1}[0-9]{2})\D*([0-9]{4})\D*$");

        if (!rgxValidacao.IsMatch(phoneNumber))
            throw new ArgumentException("Formato inválido de telefone!");

        var match = rgxValidacao.Match(phoneNumber);
        var numeroLimpo = match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;

        return numeroLimpo;
    }