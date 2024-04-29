// See https://aka.ms/new-console-template for more information

//oppgave1
int num1 = 5;
int num2 = 3;

int leggSammenTotall(int number1, int number2)
{
    return number1 + number2;
}

Console.WriteLine(leggSammenTotall(num1, num2)); //test linje: ville bare se om det funket

void run()
{
    Console.WriteLine(leggSammenTotall(num1, num2));
}
run();

//oppgave 2

void ingentingTilbake()
{
    Console.WriteLine("Denne metoden returner ingenting");
}

ingentingTilbake();