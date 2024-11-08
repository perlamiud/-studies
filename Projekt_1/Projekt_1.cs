using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1_Kumszczynski_71523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej identyfikującej naciśnięty klawisz
            ConsoleKeyInfo WybranaFunkcjonalność;

            // wypisanie metryki programu
            Console.WriteLine("\n\n\t\t\t\tPROGRAM KALKULATOR umożliwia obliczanie wartości wybranych wielkości matematycznych");

            // zapisanie wielokrotnego powtarzania wywołania Kalkulatorów
            do
            {
                // wypisanie MENU części głównej programu
                Console.WriteLine("\n\n\t\tMENU części głównej programu");

                // wypisanie kolejnych pozycji MENU programu
                Console.WriteLine("\n\t\tA. Kalkulator Labolatoryjny");
                Console.WriteLine("\n\t\tB. Kalkulator Indywidualny");
                Console.WriteLine("\n\t\tX. Zakończenie (wyjście z programu)");

                // wypisanie podpowiedzi dla użytkownika
                Console.Write("\n\n\t\tNaciśnij jeden z dozwolonych klawiszy (A, B, X) dla wybrania wymaganej funkcjonalności: ");

                // wczytanie kodu naciśniętego klawisza (wybranej funkcjonalności)
                WybranaFunkcjonalność = Console.ReadKey();

                // rozpoznanie wybranej funkcjonalności
                if (WybranaFunkcjonalność.Key == ConsoleKey.A)
                {
                    // został wybrany Kalkulator Labolatoryjny, który teraz musimy wywołać
                    KalkulatorLabolatoryjny();
                }
                else if (WybranaFunkcjonalność.Key == ConsoleKey.B)
                {
                    // został wybrany Kalkulator Indywidualny, który teraz musimy wywołać
                    KalkulatorIndywidualny();
                }
                else if (WybranaFunkcjonalność.Key != ConsoleKey.X)
                {
                    // jest błąd, to go sygnalizujemy
                    Console.WriteLine("\n\n\t\tERROR: nacisnąłeś niedozwolony znak!!!");

                    // chwilowe zatrzymanie programu
                    Console.WriteLine("\n\n\t\tNaciśnij dowolny klawisz dla kontynuacji . . . ");

                    // oczekiwanie na naciśnięcie dowolnego klawisza
                    Console.ReadKey();
                }

                // wyczyszczenie okna Konsoli
                Console.Clear();

            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);

            // wypisanie autorstwa programu
            Console.WriteLine("\n\n\n\t\tAutor programu: Kamil Kumszczyński, 71523");

            // wypisanie daty uruchomienia (testowania) programu
            Console.WriteLine("\n\t\tDzisiejsza data: {0}", DateTime.Now);

            // chwilowe zatrzymanie programu
            Console.Write("\n\n\n\t\tNaciśnij dowolny klawisz dla kontynuacji . . . ");

            // oczekiwanie na naciśnięcie dowolnego klawisza
            Console.ReadKey();

        } // od Main ( . . . )

        #region Deklaracje metod z Kalkulatorami

        static void KalkulatorLabolatoryjny()
        {
            // deklaracja zmiennej identyfikującej naciśnięty klawisz
            ConsoleKeyInfo WybranaFunkcjonalność;

            // wyczyszczenie okna konsoli
            Console.Clear();

            // zapisanie wielokrotnego powtarzania obliczeń wielkości matematycznych oferowanych przez Kalkulator Labolatoryjny
            do
            {
                // wypisanie metryki Kalkulatora Labolatoryjnego
                Console.WriteLine("\n\n\n\t\tMENU Kalkulatora Labolatoryjnego");

                // wypisanie kolejnych pozycji MENU Kalkulatora Labolatoryjnego
                Console.WriteLine("\n\n\t\tA. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\n\t\tB. Obliczenie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\n\n\t\tC. Konwersja znakowego zapisu liczby na wartość");
                Console.WriteLine("\n\n\t\tD. Obliczenie wartości symbolu Newtona");
                Console.WriteLine("\n\n\t\tX. Wyjście z Kalkulatora Labolatoryjnego");

                // wypisanie podpowiedzi dla użytkownika programu
                Console.WriteLine("\n\n\t\tNaciśnij dowolny klawisz (A, B, C, D, X) dla wybrania jednej z oferowanych funkcjonalności: ");

                // wczytanie kodu naciśniętego klawisza
                WybranaFunkcjonalność = Console.ReadKey();

                // rozpoznanie wybranej funkcjonalności
                switch (WybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A:
                        // potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\n\t\tWybrałeś funkcjonalność A. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                        //wywolanie funkcji do obliczania sredniej arytmetycznej
                        /*Zalozenia projektowe:
                        * 1) Dane wyjsciow, kolejnosc ich wczytywania i ich typy danych
                        * n - licznosc wyrazow ciagu liczbowego, typu ushort (liczby naturalne >= 0)
                        * a1, a2, ... , an - wyrazy ciagu liczbowego, typu float
                        * 2) warunek wejsciuwy nakladany na dane wejsciowe N> 0
                        * 3) wynik obliczben wedlug znanego wzoru, typu
                        */

                        //deklaracja zmiennych dla przechowania wcytanych danych wejsciowych
                        ushort n;
                        float a;
                        //deklaracje zmiennych dla posrednich i koncowych wynikow obliczen
                        float suma, sredniaArytmetyczna;
                        //wczytanie licznosci wyrazow ciagu liczbowego
                        do
                        {
                            //wypisanie zaproszenia dla podania licznosci 'n' wyrazow ciagu liczbowego
                            n = wczytajLiczbeNaturalna("licznosc wyrazow ciagu liczbowego");

                            //sprawdzanie warunku wejsciowego
                            if (n == 0)
                                //jest blad
                                Console.WriteLine("\n\n\t\tERROR: podana wartosc licznosci ciagu liczbowego" +
                                    "nie spelnia warnku wejciowego (n > 0)");

                        } while (n == 0); //warunek n <= 0 jest z nadmiarem
                        //obliczanie sumy wyrazow ciagu liczbowego
                        //ustalenie poczatkowego stanu obliczen
                        suma = 0.0F;
                        //wyznaczenie sumy wyrazow wedlug zaleznosci iteracyjnych
                        for(int i = 1; i <= n; i++)
                        {
                            //wczytanie wartosci i-tego wyrazu
                            wczytajLiczbeRzeczywista($"Podaj wartosc {i}-ego wyrazu ciagu liczbowego: ", out a);

                            //iteracyjne sumowanie
                            suma += a;
                        }
                        //tutaj suma jest OK
                        //obliczanie sredniej arytmetyczniej
                        sredniaArytmetyczna = suma / n;
                        //wypisanie wyniku obliczen w formacie fixed point
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:F2}");
                        //wypisanie wyniku obliczen w formacie wykladniczym
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:E2}");
                        //wypisanie wyniku obliczen w formacie ustalanym automatycznie, najlepszym dla wypisywanej wartosci
                        Console.WriteLine($"\n\n\t\tWYNIKI OBLICZE: obliczona srednia arytmetyczna {n} wczytanych wyrazow ciagu liczbowego" +
                            $"jest rowna: {sredniaArytmetyczna,6:G}");
                        break;

                    case ConsoleKey.B:
                        // potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\n\t\tWybrałeś funkcjonalność B. Obliczenie wartości wielomianu n-tego stopnia");
                        Console.WriteLine("\n\n\t\tPRZEPRASZAM, ale jestem w trakcie implementacji");
                        break;

                    case ConsoleKey.C:
                        // potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\n\t\tWybrałeś funkcjonalność C. Konwersja znakowego zapisu liczby na wartość");
                        Console.WriteLine("\n\n\t\tPRZEPRASZAM, ale jestem w trakcie implementacji");
                        break;

                    case ConsoleKey.D:
                        // potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\n\t\tWybrałeś funkcjonalność D. Obliczenie wartości symbolu Newtona");
                        Console.WriteLine("\n\n\t\tPRZEPRASZAM, ale jestem w trakcie implementacji");
                        break;

                    case ConsoleKey.X:
                        // potwierdzenie wybranej funkcjonalności
                        Console.WriteLine("\n\n\t\tWybrałeś funkcjonalność X. Wyjście z Kalkulatora Labolatoryjnego");
                        break;

                    default:
                        Console.WriteLine("\n\n\t\tERROR: Nacisnąłeś niedozwolony znak");
                        break;
                }

                // chwilowe zatrzymanie programu
                Console.Write("\n\n\n\t\tNaciśnij dowolny klawisz dla kontynuacji . . . ");

                // oczekiwanie na naciśnięcie dowolnego klawisza
                Console.ReadKey();

                // wyczyszczenie okna konsoli
                Console.Clear();

            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);
        }

        static void KalkulatorIndywidualny()
        {
            // wypisanie komunikatu
            Console.WriteLine("\n\n\n\t\tPRZEPRASZAM, ale jestem w trakcie implementacji");

            // chwilowe zatrzymanie programu
            Console.Write("\n\n\n\t\tNaciśnij dowolny klawisz dla kontynuacji . . . ");

            // oczekiwanie na naciśnięcie dowolnego klawisza
            Console.ReadKey();
        }

        #endregion
    }
}
