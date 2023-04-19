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

int numeroDeCadastros = 0;

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
        Console.WriteLine("");

        Console.WriteLine($"Insira o preco do produto:");
        preco[i] = double.Parse(Console.ReadLine().ToUpper());
        Console.WriteLine("");

        do
        {
            Console.WriteLine($"Este produto esta em promocao? (Digite 'S' para sim ou 'N' para nao)");
            promoOpcao = Console.ReadLine().ToUpper();
            Console.WriteLine("");

            switch (promoOpcao)
            {
                case "S":
                    promocao[i] = true;
                    pergunta = true;
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

        pergunta = false;

        i = i + 1;

        if (i < 5)
        {
            do
            {
                Console.WriteLine($"Gostaria de cadastrar outro produto? (Digite 'S' para sim ou 'N' para nao) (Espacos livres {5 - i})");
                string maisUmProduto = Console.ReadLine().ToUpper();
                Console.WriteLine("");

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
        }

        else
        {
            maisUm = true;
        }
        

        pergunta = false;

    } while ((maisUm == false) && (i < 5));

    if (5 == i)
    {
        Console.WriteLine($"Numero maximo de produtos cadastrados (5 produtos). Voce pode refaze-los, cadastrando novamente.");
        Console.WriteLine("");
    }

    return i;
}

// CODIGO

Console.WriteLine($"Bem-vindo ao Cadastrador de Produtos do mercado SENAI");

do
{
    Console.WriteLine($"");
    Console.WriteLine($@"Digite '1' para Cadastrar um produto
        '2' para Listar os prodrutos cadastrados
        '0' para Desligar o Cadastrador de Produtos");
    Console.WriteLine($"");


    string opcao = Console.ReadLine();
    Console.WriteLine("");

    switch (opcao)
    {
        case "1":
            numeroDeCadastros = CadastroProduto(nome, preco, promocao);
            break;

        case "2":
            
            for(int i = 0; i <= (numeroDeCadastros - 1); i++)
            {

                Console.WriteLine($"Produto numero {i + 1}");

                Console.WriteLine("");

                Console.WriteLine($@"Nome: {nome[i]}");

                Console.WriteLine($@"Preço: R$ {preco[i]}");

                if (promocao[i] == true)
                {
                    Console.WriteLine("Este produto esta em promoção");
                }
                else
                {
                    Console.WriteLine("Este produto NÃO esta em promoção");
                }

                Console.WriteLine("");
            }
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