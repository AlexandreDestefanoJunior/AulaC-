using System;

public static class RotationalCipher
{
    private const int CYCLE_SIZE = 26;


    public static string Rotate(string text, int shiftKey)
    {
        char[] mensagem = text.ToCharArray();

        char[] mensagemEncrp = new Char[mensagem.Length];



        for (int i = 0; i < mensagem.Length; i++)
        {
            if (!char.IsLetter(mensagem[i]))
            {
                mensagemEncrp[i] = mensagem[i];
            }
            else
            {
                char letra = mensagem[i];

                var isUpper = char.IsUpper(letra) ? 'A' : 'a';

                int posicaoLetra = letra - isUpper;

                char novaPosicao = (char) ((posicaoLetra + shiftKey) % CYCLE_SIZE);

                char letraEncrp = (char) (novaPosicao + isUpper);

                mensagemEncrp[i] = letraEncrp;
            }
        }
        string result = String.Join("", mensagemEncrp);


        return result;

    }
}