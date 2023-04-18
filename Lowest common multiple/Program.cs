Console.WriteLine("Hello, this is a program what can find a LCM for you!");


//założenia:
int i, n, m;
n = 12;
m = 13;
i = 0;
Console.WriteLine("LCM {0} and {1} is...",n,m);

int ctr = 0;                      //zmienna kontrolna

do
{
    i++;                        //pierwsze zwiększenie +1 zmiennej 'i', ponieważ musi byc minimum 1 aby zaszło prawidłowe dzielenie w warunku
    if (i%n==0 && i % m == 0)    //warunek na znalezienie najmniejszej wspólnej wielokrotności podanych liczb 'n' raz 'm'
    {
        ctr++;                  //jeśli warunek się wypełni, czyli mamy wspólną najmniejszą wielokrotność,                               
    }                          //to zwiększamy zmienną kontrolną żeby przerwała pętlę szukania
}
while (ctr==0);                 //jeśli zmienna kontrolna jest 1 to przerywamy pętle, bo zmienna 'i' ma wartość
                               //minimalnej wspólnej wielokrotności, natomiast jeśli nie, to zmienna 'ctr' 
Console.WriteLine(i);         //jest dalej 0 i pętla się dalej kręci szukają wymaganej wartości