// MENU 

// Bem-vindo ao Cadastrador de Produtos do mercado SENAI

// Digite '1' para Cadastrar um produto
//        '2' para Listar os prodrutos cadastrados
//        '0' para Desligar o Cadastrador de Produtos

// ----------------------------------------------------------------

// CADASTRO


// Criar metodo CadastroProduto(string[] nome, float[] preco, bool[] promocao)

// - Peguntar o nome, preco e se ta em promo
// - Perguntar se quer cadastrar outro produto
// - Dentro de um Do while para parar de perguntar caso que nao queira mais
// ou o numero de vezes acabe e colocar o indice nos arrays
// - Se acabar os slots livres exibir msg dizendo que acabou os espacos livres
// para cadastro
// - retornar numero de cadastros
// - voltar ao menu

//----------------------------------------------------------------

//VARIAVEIS

bool fecharProg = false;
string[] nome = new string[5];
double[] preco = new double[5];
bool[] promocao = new bool[5];

//METODOS

static int CadastroProduto(string[] nome, double[] preco, bool[] promocao)
{
    int i = 0;
    bool maisUm = false;
    bool pergunta = false;
    string promoOpcao;
    do
    {
        Console.WriteLine($"Insira o nome do produto:");
        nome[i] = Console.ReadLine();
        
        Console.WriteLine($"Insira o preco do produto:");
        preco[i] = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"Este produto esta em promocao? (Digite 'S' para sim ou 'N' para nao)");
        promoOpcao = Console.ReadLine();

        do
        {
            switch (promoOpcao)
        {
            case "S":
            promocao[i] = true;
            break;

            case "N":
            promocao[i] = false;
            pergunta = true;
            break;
            default:
            Console.WriteLine($"Opcao invalida");
            break;
        }
        } while (pergunta == false);

        Console.WriteLine($"Gostaria de cadastrar outro produto? (Digite 'S' para sim ou 'N' para nao) (Espacos livres {5 - i})");
        string maisUmProduto = Console.ReadLine().ToUpper();

        i = i + 1;

        do
        {
            switch (maisUmProduto)
        {
            case "S":
            pergunta = true;
            break;

            case "N":
            maisUm = true;
            pergunta = true;
            break;
            default:
            Console.WriteLine($"Opcao invalida");
            break;
        }
        } while (pergunta == false);
        
        
    } while ((maisUm == false) && (i < 2));

    return i;
}

Console.WriteLine($"Bem-vindo ao Cadastrador de Produtos do mercado SENAI");

do
{
    Console.WriteLine($"");
    Console.WriteLine($@"Digite '1' para Cadastrar um produto
        '2' para Listar os prodrutos cadastrados
        '0' para Desligar o Cadastrador de Produtos");
    Console.WriteLine($"");
    

    string opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
        CadastroProduto(nome, preco, promocao);
        break;

        case "2":
        Console.WriteLine($"Listar");
        break;

        case "0":
        Console.WriteLine($"");
        Console.WriteLine($"O programa encerrou");
        fecharProg = true;
        break;

        default:
        Console.WriteLine($"Digite uma opcao valida");
        break;
    }
    
} while (fecharProg == false);