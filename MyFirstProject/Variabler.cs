namespace DataTyper
{
    internal class Variabler
    {
    int heltal = 5;
    float decimalTal = 5.5f; // float är ett decimal tal
    double stortDecimalTal = 5.5; // double är ett stort decimal tal
    decimal stortDecimalTal2 = 5.5M; // decimal är ett stort decimal tal med hög precision
    char bokstav = 'A'; // char är en bokstav
    string text = "Hej"; // string är en text
    bool santEllerFalskt = true; // bool är sant eller falskt

    int[] tellArray = {1, 2, 3, 4, 5}; // array är en lista med värden
    string[] textArray = {"Hej", "på", "dig"}; // array är en lista med värden
    List<int> lista = new List<int>(); // lista är en lista med värden
    public string NumberFive()
    {
        return "hei";
        }
    }
}