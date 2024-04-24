using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe5Mia
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Vezbe 5

            /*Zadatak 1
                Napraviti konzolnu aplikaciju koja sadrži dve funkcije. Jednu za ispis
                svakog parnog elementa niza i jednu za ispis svakog drugog
                elementa niza.
            

            int[] niz = new int [] {0,1,2,5,4,6,8};//prvo cu deklarisati niz
            Console.WriteLine("Niz:");//tekst u posebnoj, gornjoj liniji
           // Console.WriteLine(niz);// samo mi ispiši ovaj core, početni niz

            foreach (int i in niz) {

                Console.Write(i+ " ");
            }
            Console.WriteLine();


            parni(niz);
            svakiDrugi(niz);

            Console.ReadLine(); */


            /*Zadatak 2
             Napraviti konzolnu aplikaciju koja sadrži dve funkcije. Jednu za
             sortiranje elemenata niza u rastućem redosledu i jednu za ispis
             elemenata niza. Pogledati datu sliku.*/

            int length;

            Console.WriteLine("Unesite dužinu Vašeg niza:");
            length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            Console.WriteLine("Unesite elemente Vašeg niza:");

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            sort(array);
            print(array); //funkcija je kao visak, ako iskoristimo foreach ispod
            Console.ReadKey();

            /*Console.WriteLine("Sorted array:");  OVO JE UMESTO PRINT FUNKCIJE, a posto je imam, suvisno je
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();*/


            /*Zadatak 3
                Napraviti konzolnu aplikaciju koja uneti string ispisuje
                obrnuto. Logiku zadatka realizovati u okviru funkcije.
                Zadatak treba da izgleda kao na slici ispod.
                Tekst:"Danas je divan dan!"
            */

            Console.WriteLine("Unesite tekst koji želite obrnuto ispisati:");
            string input=Console.ReadLine();//input koji je tipa string preuzima vrednost onoga sto je korisnik uneo 
            //nema potrebe za konvertovanjem jer je sve sto korisnik unese u konzolu po default-u string
            Console.WriteLine("Obrnuti ispis: "+ reverseString(input));
            Console.ReadKey();



            /*Zadatak 4
                Napraviti konzolnu aplikaciju koja sabira elemente unete
                matrice po dijagonali. Logiku zadatka realizovati u
                funkciji.
             */

            int[,] insertedMatrix = InsertMatrix(); 
            Console.WriteLine(SumOfElements(insertedMatrix));
            Console.Read();


            

        } //kraj Main-a



        //Izvan Main-a se definisu nove funkcije

        //Funkcije za 4. zadatak

        static int[,] InsertMatrix() {

            Console.WriteLine("Aplikacija vrši sabiranje elemenata matrice po dijagonali matrice.");
            Console.WriteLine("Unesite broj redova i kolona:");
            int rowCol = int.Parse(Console.ReadLine()); //pretvaramo ono sto je korisnik uneo u konzolu (string) u integer

            int[,] matrix = new int[rowCol, rowCol];
            Console.WriteLine("Unesite elemente matrice:");

            for (int i=0; i<rowCol;i++) {

                for (int j=0;j<rowCol;j++)
                {
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Unesena matrica:");
            for (int i=0;i<matrix.GetLength(0);i++) {

                for (int j=0; j<matrix.GetLength(1);j++) {
                    Console.Write("\t{0}", matrix[i,j]);//\t (horizontal tab) Moves the active position to the next horizontal tabulation position on the current line. [...]
                }
                Console.WriteLine();
            }

            return matrix;

        }

        static int SumOfElements(int[,] matrix) {

            int diagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) {

                for (int j = 0; j < matrix.GetLength(1); j++) {

                    if (i == j) {
                        diagonalSum = diagonalSum + matrix[i, j];
                    }
                }
            }
            return diagonalSum;
        }


        //Zadatak 3

        public static string reverseString(string text) {//reverse je postupak ove metode, aktivnost

            string reversedString = "";// reversed je konkreatn string
            int length = text.Length-1; //pazi na -1
                     while (length >= 0) {
                    reversedString = reversedString + text[length];
                    length--;
                        }
            return reversedString; //nakon sto while prestane da vazi
        }

        /*
        public static void parni(int[] niz)
        { //kao parametar, ova funkcija prima vrednost niza "niz"

            Console.WriteLine("Parni brojevi u nizu su:");

            for (int i = 0; i < niz.Length-1; i++)
            {//krovni uslov, mora da sadrzi info o relevantnom nizu

                if (niz[i] % 2 == 0)
                {//ostatak pri deljenju elementa niza i sa 2 je 0->i je paran broj 

                    Console.Write(niz[i] + " ");
                }
                else
                {
                    Console.WriteLine();
                }// kraj if-a

            }//kraj for-a
        }//kraj 1. metode/f-je za parne brojeve


        public static void svakiDrugi(int[] niz)
        {

            Console.WriteLine("Svaki drugi broj niza je:");



            for (int i = 0; i < niz.Length; i++)
            {

                if (i % 2 != 0)
                {

                    Console.Write(niz[i] + " ");
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
        */


            //Funkcije za 2. zadatak

            //Funkcija za sortiranje brojeva

          public static void sort (int[] array){//Selection sort

                 for (int i = 0; i < array.Length-1; i++)
                 {
                     int min = i;//pretpostavka

                     for (int j = i + 1; j < array.Length; j++)
                     {

                         if (array[j] < array[min]) {
                             min = j;
                         }   

                         if (min!=i)
                         { //po rastucem redosledu, dakle od najmanjeg do najveceg broja

                             int temp = array[min]; //treba nam temp za zamenu vrednosti u okviru indeksa
                             array[min] = array[i];
                             array[i] = temp;
                         } //kraj if-a
                     }
                 }
             }// kraj metode selection sort-a

             //Metoda printovanja, klasika, koristi se da bi izbegavali foreach za sve

             public static void print(int[] array) {

                 for(int i = 0;i < array.Length-1;i++)
                 {

                     Console.Write(array[i] + " ");
                 }
                 Console.WriteLine();    

             } // kraj print metode


            



        }//class Program
}//namespace



