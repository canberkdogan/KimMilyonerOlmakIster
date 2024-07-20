using System;
using System;

class Program
{
    static void Main()
    {
        int correctAnswers = 0;

        Console.WriteLine("1-) Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a-) lama b-) deve");
        string answer1 = Console.ReadLine().ToLower();

        if (answer1 == "a") //Soru 1 
        {
            correctAnswers++;
            Console.WriteLine("doğru cevap");
        }
        else
        {
            Console.WriteLine("yanlış cevap");
        }

        Console.WriteLine("2-) Dünyaya en yakın gezegen hangisidir?");
        Console.WriteLine("a-) Venüs b-) Mars");
        string answer2 = Console.ReadLine().ToLower();

        if (answer2 == "a") //Soru 2 
        {
            correctAnswers++;
            Console.WriteLine("doğru cevap");
        }
        else
        {
            Console.WriteLine("yanlış cevap");
        
        }

       

        if (correctAnswers < 2)
        {
            Console.WriteLine("3-) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
            Console.WriteLine("a-) 7 b-) 12");
            string answer3 = Console.ReadLine().ToLower();

            if (answer3 == "a") //Soru 3 
            {
                correctAnswers++;
                Console.WriteLine("doğru cevap");
            }
            else
            {
                Console.WriteLine("yanlış cevap");
            }

            }
            if (correctAnswers >= 2)
            {
                Console.WriteLine("Tebrikler! Büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödüle ulaşamadınız!");
            
        } 
    }


}

