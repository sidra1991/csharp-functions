// See https://aka.ms/new-console-template for more information
using System;


//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina


void StampaArray(int[] array){
    string text = "";
    for (int i = 0; i < array.Length; i++) {
        string trim = "";
        if ( i > 0)
        {
            trim = ",";
        }
        text += trim + Convert.ToString(array[i]);
    }
    Console.WriteLine("[" + text + "]");
}

//tester
//int[] array = { 3, 3, 3, 3, 3 };

//StampaArray(array);

//------------------------------------....................------------------------
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    int risultato = 0;

    for (int i = 1; i < numero; i++)
    {
        if( numero / i == i)
        {
           risultato = i;
            break;
        }
    }

    return  risultato;
}


//tester
//int numero = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine(Quadrato(numero));

//------------------------------............................-------------------
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray= new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * array[i];
    }

    return  newArray;
}

//tester
//int[] array = { 1, 2, 3, 4, 5 };

//StampaArray(ElevaArrayAlQuadrato(array));

//---------------------------...........................----------------------------
//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SommaElementiArray(int[] array)
{
    int somma=0;

    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }

    return somma;
}

//tester
//int[] array = { 3, 3, 3, 3, 3, 3 };

//Console.WriteLine(SommaElementiArray(array));

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati


int[] array = arrayPazzo();

int[] arrayPazzo() {
    Console.WriteLine("quanti numeri vuoi inrerire?");
    int quantita = Convert.ToInt32( Console.ReadLine());
    int[] arP = new int[quantita];
    for (int i = 0; i < quantita; i++)
    {
        Console.WriteLine("inserisci il " + (i+1) + " numero");
        arP[i] =Convert.ToInt32( Console.ReadLine());
    }

    return arP;
}

StampaArray(array);
StampaArray(ElevaArrayAlQuadrato(array));

Console.WriteLine("controllo che l'array origginale non sia stato modificato");
StampaArray(array);
Console.WriteLine(SommaElementiArray(array));
Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(array)));





//---------------------...................------------------------
//    aggiunte da me





//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. Potete prendere quella fatta in classe questa mattina
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati
//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.