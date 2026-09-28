using System.Runtime.InteropServices.Marshalling;

namespace desafio_backend_sprint1_Vinícius_da_Hora_de_Castro
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Alunos e Notas
            Dictionary<string, Aluno> Alunos = new Dictionary<string, Aluno>();
            Alunos.Add("Hermione Granger", new Aluno("Hermione Granger", "Grifinória", new List<double> { 9, 8.5, 10 }));
            Alunos.Add("Harry Potter", new Aluno("Harry Potter", "Grifinória", new List<double> { 8, 6.5, 8.5 }));
            Alunos.Add("Draco Malfoy", new Aluno("Draco Malfoy", "Sonserina", new List<double> { 7, 8.5, 8 }));
            Alunos.Add("Cedrico Diggory", new Aluno("Cedrico Diggory", "Lufa-Lufa", new List<double> { 9, 7.5, 8 }));

            //Professores, Disciplinas
            Dictionary<string, Professor> Professores = new Dictionary<string, Professor>();
            Professores.Add("Severus Snape", new Professor("Severus Snape", "Sonserina", "Poções", 8000));
            Professores.Add("Fílio Flitwick", new Professor("Fílio Flitwick", "Corvinal", "Feitiços", 800));
            Professores.Add("Minerva McGonagall", new Professor("Minerva McGonagall", "Grifinória", "Transfiguração", 7500));
            Professores.Add("Pomona Sprout", new Professor("Pomona Sprout", "Lufa-Lufa", "Herbologia", 75000));

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
                Console.WriteLine("\nBem vindo ao sistema acadêmico de Hogwarts!\n");

                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Cadastrar Aluno");
                Console.WriteLine("3 - Ver relação de professores e alunos");
                Console.WriteLine("4 - Pagar salário de professor");
                Console.WriteLine("5 - Pontuar aluno");
                Console.WriteLine("6 - Sair");

                Console.Write("\nO que deseja fazer?(1 - 6): ");
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
                    case 3: Relacao();
                        break;
                    case 4: PagarSalario();
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

                Console.Write("\nDigite a disciplina que o professor leciona: ");
                professor1.Disciplinas = Console.ReadLine()!;

                Console.WriteLine($"\nProfessor(a) {professor1.Nome} cadastrado(a) com sucesso!\n");
                professor1.LancarFeitico();

                Thread.Sleep(5000);
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

                Aluno aluno1 = new Aluno(string.Empty, string.Empty, new List<double>());
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

                Console.WriteLine($"\nAluno(a) {aluno1.Nome} cadastrado(a) com sucesso!\n");
                aluno1.LancarFeitico();

                Thread.Sleep(5000);
                Console.Clear();
                MostrarLogo();
                MostrarImagemHog();
                MostrarMenuInicial();
            }

            void Relacao()
            {
                Console.Clear();
                Console.WriteLine("Relação de Bruxos e Bruxas de Hogwarts\n");
                Console.WriteLine(@"
█▀█ █▀█ █▀█ █▀▀ █▀▀ █▀ █▀ █▀█ █▀█ █▀▀ █▀
█▀▀ █▀▄ █▄█ █▀░ ██▄ ▄█ ▄█ █▄█ █▀▄ ██▄ ▄█");
                Console.WriteLine("\n");
                foreach (var infos in Professores)
                {
                    Professor p = infos.Value;
                    Console.WriteLine($"{p.Nome} | Casa: {p.Casa} | Disciplina: {p.Disciplinas} | Salário: {p.Salario}");
                }
                Console.WriteLine("\n");

                Console.WriteLine(@"
▄▀█ █░░ █░█ █▄░█ █▀█ █▀
█▀█ █▄▄ █▄█ █░▀█ █▄█ ▄█");
                Console.WriteLine("\n");
                foreach (var infos in Alunos)
                {
                    Aluno a = infos.Value;
                    Console.WriteLine($"{a.Nome} | Casa: {a.Casa} | Notas: {string.Join(", ", a.Notas)} | Média: {a.Media:F2}");
                    
                    Console.WriteLine("\nDigite qualquer tecla para voltar...");
                    Console.ReadKey();
                    Console.Clear();
                    MostrarLogo();
                    MostrarImagemHog();
                    MostrarMenuInicial();
                }
            }

            void PagarSalario()
            {
                Console.Clear();
                Console.WriteLine("Pagamento de Salário de Professores\n");
                Console.WriteLine(@"");
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
