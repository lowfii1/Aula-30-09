{
    int idade = 35;
    Console.WriteLine($"A idade do mário é{idade}");
    // Váriaveis signed permite números negativos e assigned não permitem
    sbyte pessoas = -128; // =128 ~ = 127 - 0 255(256) 2*8 com sinal
    byte joias = 255; // Não pode têm sinal logo só poder ser positiva
    short malas = 32767; //store whole numbers in the range of - 32,768 to 32,767, 2*16
    ushort telas = 65535; // O maximo é 65635 e o minimo é 0
    int pcs = -2147483648;// o int é 2 elevado a 32, dando -2.147.483.648 e 2.147.483.647
    uint malhas = 4294967295;// Aceita no máximo 4.294.967.296
    long estrelas = -922337236854775808; // Aceita no máximo 922337236854775807 e no mínimo -922337236854775808
    ulong planetas = 1844674473709551614; // Aecita no máximo 1844674473709551614
                                          //variáveis de ponto flutuante
                                          // Pontos flutuantes têm casas decimais depois da virgula
    float numero1 = 0.421423424242421234F; //Float é para números decimais aceita 32 bits depois da virgula
    double numero = 0.0D; // double é para números decimais aceita 64 bits depois da virgula
    decimal decimalzinho = 0.2133333334323423423424234234242424242M; //  decimal aceita 128 bits depois da virgula
                                                                     // Váriaveis  teste lógicas
    bool teste = true; // Aceita verdadeiro ou falso
                       //Operadores aritméticos no C#
    Console.WriteLine(5 - 6);
    Console.WriteLine(5 + 6);
    Console.WriteLine(5 * 6);
    Console.WriteLine((5 / 6).ToString("#0.00"));// Usamos todos esses parenteses por que to string não cabe no console.writeline
    Console.WriteLine($" 5 mod 2 -> {5 % 2}");
    int a = 0;
    Console.WriteLine($" a++{a++}");// Mostra no instante antes da adição então 0, das duas forma o valor final sera +1 o que muda 
                                    // é o tempo que ele mostra a++ é antes e o ++aa é depois da adição
    Console.WriteLine($" a++{++a}");// Mostra o resultado da adição então 1

    Console.WriteLine();

    Console.WriteLine(Math.Pow(5, 6)); // Aqui usando a clase math que têm vários funções de matématicas nesse caso o pow
                                       // O pow retorna uma valor da raiz
    double valor = 125.98;
    valor += 10; //valor = valor + 10/ atribuição composta


    Console.WriteLine(valor.ToString("#0.00"));// Limita a quantidade de números que aparece
    Console.WriteLine(5.0 * 2.0 - 7.0 / 4.0 + 3.0);// Precedência de operadores

    Console.WriteLine();

    Console.WriteLine("Tabuada");
    int num = 7;
    int cont = 0;
    while (cont < 10)
    {
        Console.WriteLine($" {num} x {cont + 1} = {num * (cont++ + 1)} ");
    }
    //Raiz quadrada
    Console.WriteLine($"Raiz quadrado de 144 ==> {Math.Sqrt(144)}");// Mostra a raiz quadrada
    Console.WriteLine($"Raiz quadrado de 144 ==> {Math.Pow(144, 0.5)}");

    // Matrizes
    int[] m = { 1, 3, 8, 7 };// Isso aqui é uma matrix auto-declara com atribuição
    int i = 0;
    Console.WriteLine(m[i++]);
    Console.WriteLine(m[i++]);
    Console.WriteLine(m[i++]);
    Console.WriteLine(m[i]);

    int[] mx = new int[5];
    mx[0] = 13;
    mx[1] = 23;
    mx[2] = 33;
    mx[3] = 43;
    mx[4] = 53;
    foreach (var item in mx) //  Foreach = Para cada 
    {

        Console.WriteLine(item); // Aqui nesse código usando o foreach atribuimos cada valor da matriz mx para a váriavel item 
    }

    //matrizes
    int[,] mat = new int[5, 5];
    mat[0, 0] = 65;

    Console.WriteLine($"Resultado => {mat[0, 0]}");
    // preencher a matriz de 5x5
    Random random = new(); // objeto para valores aleatórios
    for (int l = 0; l < 5; l++) // para faca
    {
        for (int c = 0; c < 5; c++)
        {
            mat[l, c] = random.Next(10, 100);
        }

    }
    Console.WriteLine();
    // exibir a matriz de 5x5
    for (int l = 0; l< 5;l++)
    {
        for(int c = 0;c < 5; c++)
        {
            Console.Write($" {mat[l,c]} ");
        }
        Console.WriteLine();

    }


C
        onsole.ReadKey();


}