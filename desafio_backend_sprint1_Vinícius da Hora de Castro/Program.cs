using System.Runtime.InteropServices.Marshalling;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            void MostrarLogo()
            {
                Console.WriteLine(@"
██╗░░██╗░█████╗░░██████╗░░██╗░░░░░░░██╗░█████╗░██████╗░████████╗░██████╗
██║░░██║██╔══██╗██╔════╝░░██║░░██╗░░██║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝
███████║██║░░██║██║░░██╗░░╚██╗████╗██╔╝███████║██████╔╝░░░██║░░░╚█████╗░
██╔══██║██║░░██║██║░░╚██╗░░████╔═████║░██╔══██║██╔══██╗░░░██║░░░░╚═══██╗
██║░░██║╚█████╔╝╚██████╔╝░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║░░░██║░░░██████╔╝
╚═╝░░╚═╝░╚════╝░░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░");
            }

            void MostrarImagemHog()
            {
                Console.WriteLine(@"⠀⠀
  ⠀⠀⠀⢠⣾⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠟⢂⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣴⣿⣿⣿⣿⣿⣦⣄⣀⡀⠀⠀⣀⣀⣠⠞⣉⡀⠀⠀⠂⢀⠀⠀⠀⠀
⠀⣠⣶⣿⣿⣿⣇⢶⢹⡿⠋⠻⣿⣿⣦⠞⠛⣽⣷⡿⠟⢿⣦⢀⣴⡿⠿⣶⠀⠀
⠀⢿⡄⠀⠙⣿⣿⣾⣸⠃⠀⠀⣨⣿⣿⠀⠸⠗⠉⢀⣠⣼⡿⣾⠃⠀⣠⡿⠀⠀
⠀⠈⠛⢶⣄⢸⣿⢧⣿⠃⠀⠀⣉⣿⣿⠀⠀⣠⣾⠿⠛⠁⢸⣿⠀⡾⠋⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣿⡜⠁⠀⣰⣤⣍⣙⣿⣀⣸⣿⣷⣄⣴⣿⣿⣿⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣸⡿⠋⠀⠀⣹⣷⡀⢰⣿⣷⡄⢰⣿⣿⣷⢟⣿⢿⡄⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢠⣿⣿⣘⣿⣎⣛⣿⠇⢈⡁⢙⡃⢘⣽⣤⣽⣿⣿⣼⣷⡀⠀⠀⠀⠀
⠀⠀⠀⢀⣾⠋⢉⡩⠭⡉⢉⣿⡇⢸⣿⣿⡇⢸⣟⣉⠝⠻⣿⣿⠙⢷⡀⠀⠀⠀
⠀⠀⣰⣿⡃⢀⣾⣿⡥⠜⢸⣿⠃⣸⣿⣟⣁⡘⣿⣿⠃⠀⠘⠁⠀⠈⢿⣦⡀⠀
⢀⣾⠟⠘⠻⢿⣿⣿⣿⣷⣬⡛⠉⠉⢸⣿⣿⠉⠛⠉⠀⠀⠀⣆⠀⠀⢸⣿⣿⣦
⠙⢷⣄⣀⣀⣼⡿⢿⣿⣿⣿⣿⣦⡀⢸⣿⣿⠀⠀⢀⠀⠀⢀⣿⣀⡀⣘⣿⡟⠁
⠀⠀⠙⢿⡁⣀⡀⠀⠙⢿⣿⣿⣿⡇⠈⣿⣿⡆⢀⣼⡄⣀⣼⢿⣿⣿⣿⠋⠀⠀
⠀⠀⠀⠀⠿⠟⠻⣦⣀⣀⣿⢿⣏⢷⠀⣿⣿⣷⣾⡿⢱⣏⣼⠟⠉⠻⠁⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠛⠿⢴⣾⣋⠀⠀⣿⣿⣿⣻⣴⠿⠟⠁⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢷⣤⣿⡿⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            }

            void MostrarMenuInicial()
            {
                Console.WriteLine("\nBem vindo ao sistema acadêmico de Hogwarts!");

                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Cadastrar Aluno");
                Console.WriteLine("3 - Ver relação de alunos");
                Console.WriteLine("4 - Ver relação de professores");
                Console.WriteLine("5 - Sair");

                Console.Write("\nDigite sua escolha: ");
                string OpcaoEscolhida = Console.ReadLine()!;
                int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);

                switch (OpcaoEscolhidaNumerica)
                {
                    case 1:
                        OpcaoProfessor();
                        break;
                    case 2:
                        OpcaoAluno();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha 1 para Aluno ou 2 para Professor.");
                        break;
                }
            }

            void OpcaoProfessor()
            {
                Console.Clear();
                Console.WriteLine(@"
█▀█ █▀█ █▀█ █▀▀ █▀▀ █▀ █▀ █▀█ █▀█
█▀▀ █▀▄ █▄█ █▀░ ██▄ ▄█ ▄█ █▄█ █▀▄");
                Console.WriteLine("\nHá um novo professor em Hogwarts!\n");

                Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⠒⠒⠢⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡰⠋⠀⠈⡆⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⢠⠴⠊⠁⡏⠠⡀⢧⣀⠀⠀⠈⠑⠢⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡎⠁⠀⠀⠀⠀⠙⠦⡀⠀⠹⡷⠤⠭⠵⡄⢱⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⠀⠀⢀⣰⠏⠀⠀⠀⠀⣀⣀⣀⠀⠈⠙⡎⠁⠀⠀⠀⠈⢦⡹⡄⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⠋⠁⠀⠀⠀⢠⣎⠭⠥⠤⢀⠀⠡⣇⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠴⠶⡾⢂⡀⠀⠀⢀⡰⠏⠁⢀⣮⣤⣄⠑⠖⠽⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀  ⠀⠀⠀⠀⠀⢀⢰⣃⣤⡀⠈⠀⠀⡰⠊⠉⠀⣠⣶⣿⣿⣿⣿⡅⠘⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀ ⠀⠀⠀⠀⠀⠀⠈⠱⡽⣷⣆⠀⢸⡅⠀⣰⣾⣿⣿⣿⣿⡿⡟⡁⡄⢰⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠳⠿⠿⠧⠼⠱⠞⠙⠛⠿⠭⠥⠴⠟⠊⠅⠀⠀⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡄⡠⠈⠀⠀⢀⡀⠀⠀⠀⠁⠀⠀⠀⠀⠀⢀⠀⡀⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢀⡀⠀⠀⠀⠀⠀⠀⠀⢀⡎⣩⣴⣶⣶⣶⣷⣿⣿⣷⣿⣶⣶⡶⠶⠞⠒⠒⢍⡙⣾⣆⣀⠀⠀⠀⠀⠀⠀⠀
⢸⠱⡄⠀⠀⠀⠀⠀⢀⢀⡗⠨⡻⢿⣿⣿⣿⡿⠿⠛⠋⢉⠁⠤⠀⠀⠀⠀⢉⠉⠕⢊⣉⡩⠭⠥⣖⣲⢄⡀⠀
⠈⠣⡙⢶⡲⡤⣄⢠⠴⢏⢀⡠⢔⠲⠮⢄⣀⣀⣈⡠⠔⠉⠉⠀⠀⠀⢀⣀⠥⠒⠈⠁⠀⠀⠀⠀⠀⠈⠑⢗⠆
⠀⠀⠈⠪⡱⢵⣌⠂⠀⠀⠀⠀⠀⠈⠀⠂⠀⠢⠁⠀⠀⠀⠐⣀⠤⠖⠛⠒⠒⠢⠀⠀⠀⠀⠀⠀⠀⠀⠀⡈⠎
⠀⠀⠀ ⠈⠢⡉⠳⠦⠄⡀⠀⠀⠄⠀⠀⠀⠀⠁⢀⣠⣖⡉⠀⠀⣀⣀⣄⠠⠤⠤⠶⠤⠤⠤⠤⠖⠒⠉⠀⠀
⠀⠀⠀⠀⠀⠀⡈⠑⠦⠄⢀⣨⣀⣈⡡⠤⠴⠒⠊⡉⠀⠈⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");

                Professor professor1 = new Professor(string.Empty, string.Empty, string.Empty, 0);
                Console.Write("\nDigite o nome do professor: ");
                professor1.Nome = Console.ReadLine()!;

                Console.Write("Digite a casa do professor: \n");

                Console.WriteLine("1 - Grifinória");
                Console.WriteLine("2 - Sonserina");
                Console.WriteLine("3 - Corvinal");
                Console.WriteLine("4 - Lufa-Lufa\n");
                professor1.Casa = Console.ReadLine()!;
                int OpcaoEscolhidaNumerica = int.Parse(professor1.Casa);

                switch (OpcaoEscolhidaNumerica)
                {
                    case 1:
                        Grifinoria();
                        break;
                    case 2:
                        Sonserina();
                        break;
                    case 3:
                        Corvinal();
                        break;
                    case 4:
                        LufaLufa();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }

                Console.Write("\nDigite as disciplinas que o professor leciona: ");
                professor1.Disciplinas = Console.ReadLine()!;

                Console.Write("Digite o salário do professor (R$): ");
                professor1.Salario = double.Parse(Console.ReadLine()!);

                Console.WriteLine($"\nProfessor(a) {professor1.Nome} cadastrado(a) com sucesso!\n");
                professor1.LancarFeitico();

                Thread.Sleep(4000);
                Console.Clear();
                MostrarLogo();
                MostrarImagemHog();
                MostrarMenuInicial();
            }

            void OpcaoAluno()
            {
                Console.Clear();
                Console.WriteLine(@"
▄▀█ █░░ █░█ █▄░█ █▀█
█▀█ █▄▄ █▄█ █░▀█ █▄█");
                Console.WriteLine("\nHá um novo aluno em Hogwarts!\n");

                Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠴⠒⠒⠢⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡰⠋⠀⠈⡆⠀⠈⠳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⢠⠴⠊⠁⡏⠠⡀⢧⣀⠀⠀⠈⠑⠢⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡎⠁⠀⠀⠀⠀⠙⠦⡀⠀⠹⡷⠤⠭⠵⡄⢱⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⠀⠀⢀⣰⠏⠀⠀⠀⠀⣀⣀⣀⠀⠈⠙⡎⠁⠀⠀⠀⠈⢦⡹⡄⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⠋⠁⠀⠀⠀⢠⣎⠭⠥⠤⢀⠀⠡⣇⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠴⠶⡾⢂⡀⠀⠀⢀⡰⠏⠁⢀⣮⣤⣄⠑⠖⠽⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀  ⠀⠀⠀⠀⠀⢀⢰⣃⣤⡀⠈⠀⠀⡰⠊⠉⠀⣠⣶⣿⣿⣿⣿⡅⠘⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀ ⠀⠀⠀⠀⠀⠀⠈⠱⡽⣷⣆⠀⢸⡅⠀⣰⣾⣿⣿⣿⣿⡿⡟⡁⡄⢰⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠳⠿⠿⠧⠼⠱⠞⠙⠛⠿⠭⠥⠴⠟⠊⠅⠀⠀⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⡄⡠⠈⠀⠀⢀⡀⠀⠀⠀⠁⠀⠀⠀⠀⠀⢀⠀⡀⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢀⡀⠀⠀⠀⠀⠀⠀⠀⢀⡎⣩⣴⣶⣶⣶⣷⣿⣿⣷⣿⣶⣶⡶⠶⠞⠒⠒⢍⡙⣾⣆⣀⠀⠀⠀⠀⠀⠀⠀
⢸⠱⡄⠀⠀⠀⠀⠀⢀⢀⡗⠨⡻⢿⣿⣿⣿⡿⠿⠛⠋⢉⠁⠤⠀⠀⠀⠀⢉⠉⠕⢊⣉⡩⠭⠥⣖⣲⢄⡀⠀
⠈⠣⡙⢶⡲⡤⣄⢠⠴⢏⢀⡠⢔⠲⠮⢄⣀⣀⣈⡠⠔⠉⠉⠀⠀⠀⢀⣀⠥⠒⠈⠁⠀⠀⠀⠀⠀⠈⠑⢗⠆
⠀⠀⠈⠪⡱⢵⣌⠂⠀⠀⠀⠀⠀⠈⠀⠂⠀⠢⠁⠀⠀⠀⠐⣀⠤⠖⠛⠒⠒⠢⠀⠀⠀⠀⠀⠀⠀⠀⠀⡈⠎
⠀⠀⠀ ⠈⠢⡉⠳⠦⠄⡀⠀⠀⠄⠀⠀⠀⠀⠁⢀⣠⣖⡉⠀⠀⣀⣀⣄⠠⠤⠤⠶⠤⠤⠤⠤⠖⠒⠉⠀⠀
⠀⠀⠀⠀⠀⠀⡈⠑⠦⠄⢀⣨⣀⣈⡡⠤⠴⠒⠊⡉⠀⠈⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");

                Aluno aluno1 = new Aluno(string.Empty, string.Empty, 0, 0);
                Console.Write("\nDigite o nome do aluno: ");
                aluno1.Nome = Console.ReadLine()!;

                Console.Write("Digite a casa do aluno: \n");

                Console.WriteLine("1 - Grifinória");
                Console.WriteLine("2 - Sonserina");
                Console.WriteLine("3 - Corvinal");
                Console.WriteLine("4 - Lufa-Lufa\n");
                aluno1.Casa = Console.ReadLine()!;
                int OpcaoEscolhidaNumerica = int.Parse(aluno1.Casa);

                switch (OpcaoEscolhidaNumerica)
                {
                    case 1:
                        Grifinoria();
                        break;
                    case 2:
                        Sonserina();
                        break;
                    case 3:
                        Corvinal();
                        break;
                    case 4:
                        LufaLufa();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }

                Console.Write("\nDigite as notas do aluno no último semestre: ");

                Console.WriteLine($"\nAluno(a) {aluno1.Nome} cadastrado(a) com sucesso!\n");
                aluno1.LancarFeitico();

                Thread.Sleep(4000);
                Console.Clear();
                MostrarLogo();
                MostrarImagemHog();
                MostrarMenuInicial();
            }

            //casas de Hogwarts
            void Grifinoria()
            {
                Console.WriteLine("\nEle(a) é Grifinória!");
                Console.WriteLine(@"
⠀⠀⠀⠀⠀⠀⣤⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⡆⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣿⣿⡍⠉⢸⡆⢀⣠⢟⣿⣿⣿⡿⣿⡿⣿⣧⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢀⣿⣿⣿⠂⢻⣿⣿⣿⠛⠛⣙⠻⠷⣿⣿⢿⣿⣄⠀⠀⠀⠀⠀⠀
⠀⠀⣠⣶⣶⣿⣿⠿⠏⢀⣾⣿⣿⡐⠂⠀⢀⣀⣈⣿⣿⣿⡻⠿⣿⣿⣆⠀⠀⠀
⠀⠀⣿⣿⡟⣿⠁⢀⣦⢐⣽⣿⣿⣿⣇⠀⠘⠛⢻⣇⣿⡏⠀⢠⣿⣿⣿⠀⠀⠀
⠀⠀⢹⣿⡷⣿⡇⠸⣿⠻⣟⣿⣿⠟⢻⣷⣶⣶⣾⣿⣿⠃⢀⣾⣿⣿⣿⠀⠀⠀
⠀⠀⢸⡿⠃⠉⠢⠀⢉⠀⠈⣹⠏⠀⠀⠈⠉⠛⠛⠿⠁⠀⣾⠿⣿⣿⣿⠀⠀⠀
⠀⠀⠘⣇⢰⣸⣆⢂⢻⡆⣼⣿⡀⠀⠀⠀⠀⠀⠤⠜⣀⣰⣿⣶⡟⣿⣿⠀⠀⠀
⢠⣶⣶⣿⣿⠛⠇⠘⠈⠁⠘⠟⠁⠐⣢⠠⠀⠀⠀⢀⣀⣀⣀⠀⠀⢹⣿⣿⣷⠀
⠘⠿⢿⣿⣿⡷⠞⣿⢠⣿⠟⣿⠇⠀⠀⠀⠀⠀⢀⠈⠙⡿⠁⢳⣶⣾⣿⠛⠋⠀
⠀⠀⢀⣹⡿⠇⠓⢻⣸⣿⣿⣃⣀⣤⣤⣤⣤⣴⣿⣄⣼⣿⣀⣾⣿⣿⡇⠀⠀⠀
⠤⣴⡇⢠⡔⢦⡄⠸⠉⠋⠉⠉⠉⣩⠭⢩⢭⡉⠉⠉⠉⠩⡭⠉⠛⠛⠟⠿⣷⠆
⠀⢹⠀⣿⠀⠈⠀⠀⢴⠶⢲⣰⠂⣿⠁⣿⢱⡇⣶⢲⢠⡶⡇⣴⣤⢠⣤⠀⣿⠀
⠀⢿⡀⣿⠐⢶⡆⠀⠼⣀⡨⠃⢀⣿⢀⡿⠘⠃⠇⠾⠸⠾⢇⢿⡽⣸⡀⠀⣿⠀
⠀⣿⡇⢹⣧⣸⠧⢠⣤⣬⣤⣤⣤⣤⣤⣤⣶⣤⣤⣤⣤⣤⣤⣤⣄⡀⠀⠀⣧⠀
⠀⡿⣇⠀⠉⠤⠤⢼⣿⣿⡀⠀⠻⠷⡟⣰⣦⡀⠈⠒⢶⣿⡿⠉⠉⠛⠻⠿⠿⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣶⣤⡴⡆⠘⢟⣵⣶⣾⣾⠋⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠁⠙⢿⣿⣷⣾⣿⠟⠁⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            }

            void Sonserina()
            {
                Console.WriteLine("\nEle(a) é Sonserina!");
                Console.WriteLine(@"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⣶⣾⣶⣿⣿⣷⣷⣶⡦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢰⣦⣤⣤⣤⣤⣴⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣦⣤⣤⣤⣤⣤⡄⠀⠀
⠀⠀⠀⣻⠿⣛⠋⠑⠻⠟⠛⠛⠛⠋⠉⣉⠙⠛⠛⠛⠛⠻⠿⠿⣿⣿⣿⠁⠀⠀
⠀⠀⢸⢰⡋⠹⠋⠀⠀⣾⠀⡀⠀⣰⠆⢹⣀⡀⢀⣄⡀⣀⣀⠀⡄⠈⠙⠀⢀⠀
⠂⡀⢸⠈⠻⣶⣄⠀⡄⣿⠸⣇⡏⢻⡀⣾⠉⡇⢾⠔⡃⣿⠉⢰⡖⢰⣦⣄⠀⠔
⠀⠀⣼⠖⢲⡌⢿⡇⡇⢋⣤⠝⢀⠨⠀⠁⠨⢉⠈⠉⠀⠛⠀⠻⠁⣿⢠⡇⠌⠀
⠀⠰⣇⠐⠚⠃⣼⠇⡧⢤⣾⡝⠁⣠⢴⣶⡦⣄⠈⣚⡖⠶⣦⣄⡀⠀⠉⢁⠀⠀
⠀⠀⠙⠛⠒⣫⢁⣴⣤⣿⢿⡀⠰⣃⢸⡇⣸⣞⠇⢶⠀⣠⣼⣿⣿⣷⡆⠜⠀⠀
⠀⠀⠀⠀⣿⣿⠀⡻⡟⠿⣿⣧⠀⠑⠕⡾⣿⣿⣅⣶⣤⣹⣟⡁⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⣿⣿⠈⢿⡲⡐⡿⣿⣿⣶⣤⡀⠀⠋⢿⣿⢟⠉⣿⠃⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⣿⣿⡴⣷⠀⠓⡌⡌⣿⣿⣏⣹⡷⣦⣄⠘⢿⠒⣿⠇⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⣿⣿⡧⣮⠦⢨⣠⢣⠻⣿⣿⣿⣿⣿⠻⣆⠀⢣⣿⡆⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⣿⣿⣇⣴⣿⣿⣿⢸⣾⣿⣿⣿⢿⣿⣶⣿⢀⢸⣿⡄⣿⣿⠃⠀⠀⠀
⠀⠀⠀⠀⣿⣿⡟⣿⣿⣤⣿⡄⠫⡁⢈⣏⠀⣙⡷⠋⣼⣇⣿⣿⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⣿⣿⣧⣝⡻⢿⢟⣻⢦⣬⣍⣉⣉⣡⠴⡾⡿⢟⣯⣷⣿⣿⡇⠀⠀⠀
⠀⠀⠀⠀⠉⠛⠿⢿⣿⣷⣮⣉⡙⢶⠚⣿⠒⡶⣩⣽⣾⣿⡿⠿⠛⠋⠁⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠿⣿⣿⣷⣮⣭⣶⣿⣿⡿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⢿⣿⠿⠛⠁⠀⠀⠀⠀⠀");
            }

            void Corvinal()
            {
                Console.WriteLine("\nEle(a) é Corvinal!");
                Console.WriteLine(@"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⡀⠀⠱⢄⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣷⣄⢳⣴⣄⠈⢠⡋⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣾⣿⡿⢸⢒⢣⡾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢰⣤⣄⣀⣤⣤⣤⣶⣿⣿⡿⢁⠃⡕⣳⠦⣸⣄⣀⣀⣀⣤⡤⠀⠀⠀⠀
⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⡿⢁⢁⢎⡾⣉⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀
⠀⢠⠔⢒⣒⣛⠛⠻⢽⡩⠋⢿⣿⡃⠀⣋⠥⢚⣽⡾⡻⡩⢙⣹⠿⠿⠅⢀⡀⠀⠀
⢀⣴⠻⣿⡏⠹⣷⠆⠈⠁⠐⠚⠛⠓⠒⠒⠒⠛⠉⠉⢡⡄⠀⠀⠀⠀⣴⡄⢀⠆⠀
⠻⣽⠇⣿⣇⣠⡿⠇⡇⠴⣦⣴⡆⣦⣶⡤⣶⢶⣴⡿⢼⡗⢾⣶⣶⣴⣼⣇⠎⠢⡀
⠀⠀⠀⢹⡏⢻⣷⡀⡇⣞⣿⡸⣿⠛⢯⠄⡿⣸⠟⠧⠾⠿⠧⠼⠘⠋⠋⢸⠀⠔⠀
⠀⠀⠀⢸⡇⠚⠛⠳⢰⠠⠤⡤⠤⠤⢤⠄⡀⣰⡶⢒⠋⢻⡏⢹⣿⣿⢌⣙⢸⠀⠀
⠀⠐⠂⢸⡏⣿⣿⡏⢸⣠⢮⠐⣂⠸⠘⡇⣊⣱⣃⣬⣽⡿⠕⢸⣿⣿⠀⣖⡺⠀⠀
⠀⠀⠀⢸⠅⣿⣿⡟⠡⢉⠵⠿⣿⣷⢸⣿⣿⣿⣿⣿⡟⠂⠀⢸⣿⣿⠘⡔⠀⠀⠀
⠀⠀⠀⠈⠀⣿⣿⣿⠀⢉⠠⢚⠈⢻⢿⣿⣿⣿⣯⣍⡣⣀⠔⣾⣿⣿⠀⠁⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣿⣿⡖⠃⠀⢨⠀⢸⢺⣯⣿⡿⢛⢿⠿⣗⢎⣝⣛⢛⡄⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢿⣿⣿⣆⣰⣾⣪⡮⠿⠼⡩⢷⠁⠄⠀⣿⣿⣷⡿⠉⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⠉⠈⠹⡏⣸⠀⠀⠀⠇⣸⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣷⣔⡊⠉⢸⠀⠀⣠⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣦⣼⣴⣿⣿⡿⠿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⠿⠿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            }

            void LufaLufa()
            {
                Console.WriteLine("\nEle(a) é Lufa-Lufa!");
                Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣶⣿⣷⣦⣤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣀⣠⣤⣶⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣤⣄⡀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⣿⣿⣿⠿⠿⠛⠛⠛⠉⠉⠉⠉⠉⠉⠛⠛⠛⠿⠿⢿⣿⣿⣿⠁⠀⠀⠀
⠀⠀⠀⠀⠀⣰⣿⣿⠇⠀⠀⠀⠀⢠⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⡀⠀⠀⠀
⠀⠀⠀⢸⣿⣿⣿⡏⢰⣀⡀⣀⣶⣿⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⡀⠀⠀
⠀⠀⠀⠘⣿⣿⣿⡇⣆⠈⢉⠙⢛⣯⣽⢿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⠁⠀⠀
⠀⠀⠀⠀⣿⣿⣿⡀⢹⡠⣿⡇⠈⠩⢿⣆⢙⣷⣦⣄⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠁⠀⠀
⠀⠀⠀⠀⢸⣿⣿⡆⠀⢳⣼⣿⣦⣤⣤⣽⣿⣿⣿⣿⣷⣄⣀⣀⣀⠤⠤⣼⣿⣿⠀⠀⠀
⠀⠀⠀⠀⢸⣿⣿⣇⢀⣾⣿⣿⣿⣿⣿⣿⠿⠟⠛⠉⠉⣉⣀⠀⣀⣀⣴⡟⢳⣿⠿⠢⡀
⠀⢀⣀⣠⣾⢿⢿⣿⣿⣿⡿⠿⢛⣽⣷⡶⢶⡎⣠⣤⣾⡏⢿⣿⡇⣿⣛⣿⢹⣿⠻⡆⢸
⠀⢸⡇⣠⡴⢀⣴⡎⣿⠀⠀⠀⣼⡶⢺⡟⢻⣯⣿⠚⣻⡷⠛⠛⠛⠛⢫⡏⢸⡿⠀⠀⠃
⠀⣸⣇⣿⣇⠀⣿⡇⡇⣶⢸⡏⣿⠀⢸⡇⣸⠿⠻⠞⣿⣧⣀⣀⣀⣰⣿⣥⣿⢃⡀⠀⠀
⢸⣭⡇⣿⡟⠛⣿⡇⡇⢿⠾⠇⣿⢀⣼⣥⡡⠤⣶⣾⣿⣿⣿⣿⡿⣹⡿⣿⣿⢸⣉⡶⡇
⠀⢹⠇⣿⣧⢀⣿⡇⣇⣠⡤⠾⠛⣿⣿⣧⣄⠀⠈⢻⣿⣿⣿⣿⣿⢷⣿⣼⣿⠘⢬⡥⠃
⠀⠸⠿⠧⣤⣮⣤⠴⠏⠀⠀⠀⣀⣿⣿⣿⣿⣷⣶⣦⣿⣿⣿⣿⣿⠟⢹⣿⣿⠆⠀⠀⠀
⠀⠀⠀⠀⢹⣿⣿⡆⠀⠀⠀⣾⣿⣿⣿⡿⠁⠀⣸⣿⣿⣿⣿⡿⠁⠀⣸⣿⣿⠀⠀⠀⠀
⠀⠀⠀⠀⠈⢿⣿⣿⣤⡀⠀⠈⠉⠉⠉⠀⠀⠀⠉⠉⠉⠉⠁⢀⣠⣴⣿⣿⡟⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠙⠿⣿⣿⣿⣶⣶⣦⣄⡀⠀⢀⣤⣴⣶⣶⣿⣿⣿⣿⠿⠋⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠿⢿⣿⣿⣿⣿⣿⠿⠟⠛⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀");
            }

            MostrarLogo();
            MostrarImagemHog();
            MostrarMenuInicial();
        }
    }
}
