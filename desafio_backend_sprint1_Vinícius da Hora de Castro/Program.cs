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
            Professores.Add("Fílio Flitwick", new Professor("Fílio Flitwick", "Corvinal", "Feitiços", 8000));
            Professores.Add("Minerva McGonagall", new Professor("Minerva McGonagall", "Grifinória", "Transfiguração", 7500));
            Professores.Add("Pomona Sprout", new Professor("Pomona Sprout", "Lufa-Lufa", "Herbologia", 7500));

            void MostrarMenuInicial()
            {
                int OpcaoEscolhidaNumerica = 0;
                bool opcaoValida = false;

                while (!opcaoValida)
                {

                    Console.WriteLine(@"
██╗░░██╗░█████╗░░██████╗░░██╗░░░░░░░██╗░█████╗░██████╗░████████╗░██████╗
██║░░██║██╔══██╗██╔════╝░░██║░░██╗░░██║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝
███████║██║░░██║██║░░██╗░░╚██╗████╗██╔╝███████║██████╔╝░░░██║░░░╚█████╗░
██╔══██║██║░░██║██║░░╚██╗░░████╔═████║░██╔══██║██╔══██╗░░░██║░░░░╚═══██╗
██║░░██║╚█████╔╝╚██████╔╝░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║░░░██║░░░██████╔╝
╚═╝░░╚═╝░╚════╝░░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░");

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
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⡿⠁⠀⠀");

                    Console.WriteLine("\nBem vindo ao sistema acadêmico de Hogwarts!\n");

                    Console.WriteLine("1 - Cadastrar Professor");
                    Console.WriteLine("2 - Cadastrar Aluno");
                    Console.WriteLine("3 - Ver relação de professores e alunos");
                    Console.WriteLine("4 - Sair");

                    Console.Write("\nO que deseja fazer? (1 - 4): ");
                    string OpcaoEscolhida = Console.ReadLine()!;

                    bool converteuComSucesso = int.TryParse(OpcaoEscolhida, out OpcaoEscolhidaNumerica);

                    if (converteuComSucesso && OpcaoEscolhidaNumerica >= 1 && OpcaoEscolhidaNumerica <= 4)
                    {
                        opcaoValida = true; 
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Por favor, escolha um número de 1 a 4.");
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        Console.Clear(); 
                    }
                }

                switch (OpcaoEscolhidaNumerica)
                {
                    case 1:
                        OpcaoProfessor();
                        break;
                    case 2:
                        OpcaoAluno();
                        break;
                    case 3:
                        Relacao();
                        break;
                    case 4:
                        Sair();
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

                Console.Write("\nDigite a casa do professor: \n");
                Console.WriteLine("1 - Grifinória");
                Console.WriteLine("2 - Sonserina");
                Console.WriteLine("3 - Corvinal");
                Console.WriteLine("4 - Lufa-Lufa\n");
                professor1.Casa = Console.ReadLine()!;
                int OpcaoEscolhidaNumerica = int.Parse(professor1.Casa);

                switch (OpcaoEscolhidaNumerica)
                {
                    case 1:
                        professor1.Casa = "Grifinória";
                        Grifinoria();
                        break;
                    case 2:
                        professor1.Casa = "Sonserina";
                        Sonserina();
                        break;
                    case 3:
                        professor1.Casa = "Corvinal";
                        Corvinal();
                        break;
                    case 4:
                        professor1.Casa = "Lufa-Lufa";
                        LufaLufa();
                        break;
                    default:
                        professor1.Casa = "Desconhecida";
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }

                Console.Write("\nQual a disciplina que o professor leciona? \n");
                Console.WriteLine("1 - Feitiços");
                Console.WriteLine("2 - Poções");
                Console.WriteLine("3 - Herbologia");
                Console.WriteLine("4 - Transfiguração\n");
                professor1.Disciplinas = Console.ReadLine()!;
                int OpcaoEscolhidaNumerica2 = int.Parse(professor1.Disciplinas);

                switch (OpcaoEscolhidaNumerica2)
                {
                    case 1:
                        professor1.Disciplinas = "Feitiços";
                        Console.WriteLine($"O(a) professor(a) {professor1.Nome} leciona a disciplina de Feitiços.");

                        break;
                    case 2:
                        professor1.Disciplinas = "Poções";
                        Console.WriteLine($"O(a) professor(a) {professor1.Nome} leciona a disciplina de Poções.");

                        break;
                    case 3:
                        professor1.Disciplinas = "Herbologia";
                        Console.WriteLine($"O(a) professor(a) {professor1.Nome} leciona a disciplina de Herbologia.");

                        break;
                    case 4:
                        professor1.Disciplinas = "Transfiguração";
                        Console.WriteLine($"O(a) professor(a) {professor1.Nome} leciona a disciplina de Transfiguração.");

                        break;
                    default:
                        professor1.Disciplinas = "Desconhecida";
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }

                Console.Write("\nDigite o salário do professor (R$): ");
                professor1.Salario = double.Parse(Console.ReadLine()!);

                Professores.Add(professor1.Nome, professor1);
                Console.WriteLine($"\nProfessor(a) {professor1.Nome} cadastrado(a) com sucesso!\n");
                professor1.LancarFeitico();

                Thread.Sleep(5000);
                Console.Clear();
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
                        aluno1.Casa = "Grifinória";
                        Grifinoria();
                        break;
                    case 2:
                        aluno1.Casa = "Sonserina";
                        Sonserina();
                        break;
                    case 3:
                        aluno1.Casa = "Corvinal";
                        Corvinal();
                        break;
                    case 4:
                        aluno1.Casa = "Lufa-Lufa";
                        LufaLufa();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }

                Console.WriteLine("\nQuais notas o aluno recebeu nas respectivas disciplinas?");
                Console.Write("Nota na disciplina de Feitiços: ");
                aluno1.Notas.Add(double.Parse(Console.ReadLine()!));
                Console.Write("Nota na disciplina de Poções: ");
                aluno1.Notas.Add(double.Parse(Console.ReadLine()!));
                Console.Write("Nota na disciplina de Herbologia: ");
                aluno1.Notas.Add(double.Parse(Console.ReadLine()!));
                Console.Write("Nota na disciplina de Transfiguração: ");
                aluno1.Notas.Add(double.Parse(Console.ReadLine()!));

                Alunos.Add(aluno1.Nome, aluno1);
                Console.WriteLine($"\nAluno(a) {aluno1.Nome} cadastrado(a) com sucesso!\n");
                aluno1.LancarFeitico();

                Thread.Sleep(5000);
                Console.Clear();
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
                }
                    Console.WriteLine("\nDigite qualquer tecla para voltar...");
                    Console.ReadKey();
                    Console.Clear();
                    MostrarMenuInicial();
                
            }

            void Sair()
            {
                Console.Clear();
                Console.WriteLine(@"
░█████╗░████████╗███████╗  ░█████╗░  ██████╗░██████╗░░█████╗░██╗░░██╗██╗███╗░░░███╗░█████╗░░░░
██╔══██╗╚══██╔══╝██╔════╝  ██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝██║████╗░████║██╔══██╗░░░
███████║░░░██║░░░█████╗░░  ███████║  ██████╔╝██████╔╝██║░░██║░╚███╔╝░██║██╔████╔██║███████║░░░
██╔══██║░░░██║░░░██╔══╝░░  ██╔══██║  ██╔═══╝░██╔══██╗██║░░██║░██╔██╗░██║██║╚██╔╝██║██╔══██║██╗
██║░░██║░░░██║░░░███████╗  ██║░░██║  ██║░░░░░██║░░██║╚█████╔╝██╔╝╚██╗██║██║░╚═╝░██║██║░░██║╚█║
╚═╝░░╚═╝░░░╚═╝░░░╚══════╝  ╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚╝

██████╗░██████╗░██╗░░░██╗██╗░░██╗░█████╗░██╗
██╔══██╗██╔══██╗██║░░░██║╚██╗██╔╝██╔══██╗██║
██████╦╝██████╔╝██║░░░██║░╚███╔╝░██║░░██║██║
██╔══██╗██╔══██╗██║░░░██║░██╔██╗░██║░░██║╚═╝
██████╦╝██║░░██║╚██████╔╝██╔╝╚██╗╚█████╔╝██╗
╚═════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝░╚════╝░╚═╝");
                Environment.Exit(0);
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

            MostrarMenuInicial();
        }
    }
}