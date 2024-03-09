Console.WriteLine("Digite um número inteiro:");
int numero = Console.ReadLine();

if (num <= 1){
    Console.WriteLine(numero + " não é um número primo.");
}
else if (num <= 3){
    Console.WriteLine(numero + " é um número primo.");
}
else if (num % 2 == 0 || num % 3 == 0){
    Console.WriteLine(numero + " não é um número primo.");
}

int divisor = 5;
while (divisor*divisor<=num){
    if (num%divisor == 0 || num%(divisor+2) == 0){
        Console.WriteLine(numero + " não é um número primo.");
    }
    divisor += 6;
}
    Console.WriteLine(numero+" é um número primo.");
}