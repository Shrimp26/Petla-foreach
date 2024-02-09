using System;

//Wywołaj pętlę foreach na elementach pets = {"cat", "dog", "parrot", "guinea pig"}.
//Wyświetl elementy w konsoli. Jeżeli pętla trafi na element „dog”, niech program wyświetli komunikat „End” i wyjdzie z pętli.

class PetlaForeach {
    static void Main(string[] args)
    {
        string[] pets = { "kot", "pies", "papuga", "świnka morska" };
        foreach (var pet in pets)
        {
            Console.WriteLine(pet);
            
            if (pet == "pies")
            {
                Console.WriteLine("Koniec");
                break;
            }
        }
    }
}