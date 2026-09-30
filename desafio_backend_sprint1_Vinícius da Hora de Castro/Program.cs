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
            Alunos.Add("Hermione Granger", new Aluno("Hermione Granger", "Grifinória", new List<double> { 9, 8.5, 10, 9 }));
            Alunos.Add("Harry Potter", new Aluno("Harry Potter", "Grifinória", new List<double> { 8, 6.5, 8.5, 7,5 }));
            Alunos.Add("Draco Malfoy", new Aluno("Draco Malfoy", "Sonserina", new List<double> { 7, 8.5, 8, 7 }));
            Alunos.Add("Cedrico Diggory", new Aluno("Cedrico Diggory", "Lufa-Lufa", new List<double> { 9, 7.5, 8, 8 }));

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
                    Console.WriteLine("4- Registrar novo Salário de um professor");
                    Console.WriteLine("5 - Sair");

                    Console.Write("\nO que deseja fazer? (1 - 5): ");
                    string OpcaoEscolhida = Console.ReadLine()!;

                    bool converteuComSucesso = int.TryParse(OpcaoEscolhida, out OpcaoEscolhidaNumerica);

                    if (converteuComSucesso && OpcaoEscolhidaNumerica >= 1 && OpcaoEscolhidaNumerica <= 5)
                    {
                        opcaoValida = true;
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Por favor, escolha um número de 1 a 5.");
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
                        Salario();  
                        break;
                    case 5:
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

                string nomeDigitado = string.Empty;
                bool nomeValido = false;

                while (!nomeValido)
                {
                    Console.Write("\nDigite o nome do professor: ");
                    nomeDigitado = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(nomeDigitado))
                    {
                        Console.WriteLine("O nome não pode ficar em branco!");
                    }
                    else if (nomeDigitado.Any(char.IsDigit))
                    {
                        Console.WriteLine("Nome inválido! O nome não pode conter números.");
                    }
                    else
                    {
                        professor1.Nome = nomeDigitado;
                        nomeValido = true;
                    }
                }

                bool casaValida = false;
                while (!casaValida)
                {
                    Console.Write("\nDigite a casa do professor: \n");
                    Console.WriteLine("1 - Grifinória");
                    Console.WriteLine("2 - Sonserina");
                    Console.WriteLine("3 - Corvinal");
                    Console.WriteLine("4 - Lufa-Lufa\n");
                    Console.Write("Opção: ");

                    string entradaCasa = Console.ReadLine()!;
                    bool converteu = int.TryParse(entradaCasa, out int OpcaoEscolhidaNumerica);

                    if (converteu && OpcaoEscolhidaNumerica >= 1 && OpcaoEscolhidaNumerica <= 4)
                    {
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
                        }
                        casaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida. Por favor, escolha um número entre 1 e 4.");
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                    }
                }

                bool disciplinaValida = false;
                while (!disciplinaValida)
                {
                    Console.Write("\nQual a disciplina que o professor leciona? \n");
                    Console.WriteLine("1 - Feitiços");
                    Console.WriteLine("2 - Poções");
                    Console.WriteLine("3 - Herbologia");
                    Console.WriteLine("4 - Transfiguração\n");
                    Console.Write("Opção: ");

                    string entradaDisciplina = Console.ReadLine()!;
                    bool converteu = int.TryParse(entradaDisciplina, out int OpcaoEscolhidaNumerica2);

                    if (converteu && OpcaoEscolhidaNumerica2 >= 1 && OpcaoEscolhidaNumerica2 <= 4)
                    {
                        switch (OpcaoEscolhidaNumerica2)
                        {
                            case 1: professor1.Disciplinas = "Feitiços"; break;
                            case 2: professor1.Disciplinas = "Poções"; break;
                            case 3: professor1.Disciplinas = "Herbologia"; break;
                            case 4: professor1.Disciplinas = "Transfiguração"; break;
                        }
                        Console.WriteLine($"\nO(a) professor(a) {professor1.Nome} leciona a disciplina de {professor1.Disciplinas}.");
                        disciplinaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida. Por favor, escolha um número entre 1 e 4.");
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                    }
                }

                double salarioTemp;
                Console.Write("\nDigite o salário do professor (R$): ");

                while (!double.TryParse(Console.ReadLine()!, out salarioTemp) || salarioTemp < 0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor numérico válido para o salário.");
                    Console.Write("Digite o salário do professor (R$): ");
                }

                professor1.Salario = salarioTemp;

                Professores.Add(professor1.Nome, professor1);
                Console.WriteLine($"\nProfessor(a) {professor1.Nome} (Matrícula: {professor1.Matricula}) foi cadastrado(a) com sucesso!\n");
                professor1.LancarFeitico();

                Thread.Sleep(6000);
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

                bool nomeValido = false;
                while (!nomeValido)
                {
                    Console.Write("Digite o nome do aluno: ");
                    string nomeDigitado = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(nomeDigitado))
                    {
                        Console.WriteLine("O nome não pode ficar em branco!\n");
                    }
                    else if (nomeDigitado.Any(char.IsDigit))
                    {
                        Console.WriteLine("Nome inválido! O nome não pode conter números.\n");
                    }
                    else
                    {
                        aluno1.Nome = nomeDigitado;
                        nomeValido = true;
                    }
                }

                string[] casas = { "Grifinória", "Sonserina", "Corvinal", "Lufa-Lufa" };

                Random random = new Random();
                int indiceSorteado = random.Next(casas.Length); 

                aluno1.Casa = casas[indiceSorteado];

                Console.WriteLine($"\nO Chapéu Seletor pensou, pensou... e escolheu:");
                Thread.Sleep(2250); 
                Console.WriteLine($"{aluno1.Casa}!!!");

                switch (aluno1.Casa)
                {
                    case "Grifinória":
                        Grifinoria();
                        break;
                    case "Sonserina":
                        Sonserina();
                        break;
                    case "Corvinal":
                        Corvinal();
                        break;
                    case "Lufa-Lufa":
                        LufaLufa();
                        break;
                }

                Console.WriteLine("\nQuais notas o aluno recebeu nas respectivas disciplinas?");
                string[] disciplinas = { "Feitiços", "Poções", "Herbologia", "Transfiguração" };

                foreach (string disciplina in disciplinas)
                {
                    double notaValida = 0;
                    bool notaCorreta = false;

                    while (!notaCorreta)
                    {
                        Console.Write($"Nota na disciplina de {disciplina}: ");
                        string entradaNota = Console.ReadLine()!;

                        if (double.TryParse(entradaNota, out notaValida) && notaValida >= 0 && notaValida <= 10)
                        {
                            aluno1.Notas.Add(notaValida);
                            notaCorreta = true;
                        }
                        else
                        {
                            Console.WriteLine("Nota inválida! Digite um valor numérico entre 0 e 10.\n");
                        }
                    }
                }

                Alunos.Add(aluno1.Nome, aluno1);
                Console.WriteLine($"\nAluno(a) {aluno1.Nome} (Matrícula: {aluno1.Matricula}) foi cadastrado(a) com sucesso!\n");
                aluno1.LancarFeitico();

                Thread.Sleep(6000);
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
                    Console.WriteLine($"{p.Nome} | Matrícula: {p.Matricula} | Casa: {p.Casa} | Disciplina: {p.Disciplinas} | Salário: {p.Salario}");
                }
                Console.WriteLine("\n");

                Console.WriteLine(@"
▄▀█ █░░ █░█ █▄░█ █▀█ █▀
█▀█ █▄▄ █▄█ █░▀█ █▄█ ▄█");
                Console.WriteLine("\n");
                foreach (var infos in Alunos)
                {
                    Aluno a = infos.Value;
                    Console.WriteLine($"{a.Nome} | Matrícula: {a.Matricula} | Casa: {a.Casa} | Notas: {string.Join(", ", a.Notas)} | Média: {a.Media:F2}");
                }
                Console.WriteLine("\nDigite qualquer tecla para voltar...");
                Console.ReadKey();
                Console.Clear();
                MostrarMenuInicial();
            }

            void Salario()
            {
                Console.Clear();
                Console.WriteLine(@"
█▀ ▄▀█ █░░ ▄▀█ █▀█ █ █▀█
▄█ █▀█ █▄▄ █▀█ █▀▄ █ █▄█");
                Console.Write("\nDigite o nome do professor que você deseja alterar a informação de salário: ");
                string nomeProf = Console.ReadLine()!;
                if (Professores.ContainsKey(nomeProf))
                {
                    double novoSalario;
                    Console.WriteLine($"O salário atual do professor é R$ {Professores[nomeProf].Salario:F2}");
                    Console.Write($"Qual o novo salário você deseja registrar para o(a) professor(a) {nomeProf}? (R$): ");

                    while (!double.TryParse(Console.ReadLine()!, out novoSalario) || novoSalario < 0)
                    {
                        Console.WriteLine("Valor inválido! Digite um valor numérico positivo para o salário.");
                        Console.Write($"Qual o novo salário para o(a) professor(a) {nomeProf}? (R$): ");
                    }

                    Professores[nomeProf].Salario = novoSalario;

                    Console.WriteLine($"\nSucesso! O salário de {nomeProf} foi atualizado para R$ {novoSalario:F2}.");
                }
                else
                {
                    Console.WriteLine($"\nProfessor(a) '{nomeProf}' não foi encontrado(a) nos registros.");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
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