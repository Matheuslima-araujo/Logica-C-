using System;

namespace Atividade_24._09._2026
{
    internal class Program
    {
        public static class variaveis
        {
            // Variáveis globais
            public static int IdCliente;
            public static string NomeCliente;
            public static string CPFCliente;
            public static string TelefoneCliente;
            public static string ObservacoesAnamnese;
            public static bool PossuiDiabetes;
            public static DateTime DataNascimento;

            public static int IdProfissional;
            public static string NomeProfissional;
            public static string TelefoneProfissional;
            public static string RegistroProfissional;
            public static string Especialidade;

            public static int IdProcedimento;
            public static string NomeProcedimento;
            public static int DuracaoProcedimento;
            public static decimal ValorProcedimento;

            public static int IdAgendamento;
            public static int ClienteIdAgendamento;
            public static int PodologoIdAgendamento;
            public static int ProcedimentoIdAgendamento;
            public static DateTime DataHoraAgendamento;
            public static string StatusAgendamento;
        }

        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝░██╔══██╗
██████╔╝██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░██╗░███████║
██╔═══╝░██║░░██║██║░░██║██║░░██║██║░░░░░██║░░██║██║░░╚██╗██╔══██║
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝███████╗╚█████╔╝╚██████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚═════╝░╚═╝░░╚═╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 1 - Cadastrar Cliente (Ficha Rápida): ");
                Console.WriteLine(" 2 - Cadastrar Podólogo: ");
                Console.WriteLine(" 3 - Cadastrar Procedimento/Serviço: ");
                Console.WriteLine(" 4 - Agendar Consulta: ");
                Console.WriteLine(" 5 - Listar Agendamentos: ");
                Console.WriteLine(" 6 - Exibir Todos os Cadastros: ");
                Console.WriteLine(" 0 - Sair. ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ClientePodologa();
                        break;
                    case 2:
                        CadastroProfissional();
                        break;
                    case 3:
                        CadastrarProcedimento();
                        break;
                    case 4:
                        Agendamento();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Você saiu do programa! Obrigado");
                        break;


                }
            }
        }
        static void ClientePodologa()
        {

            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do usuario: ");
            variaveis.IdCliente = int.Parse(Console.ReadLine());

            Console.WriteLine(" Nome completo do paciente: ");
            variaveis.NomeCliente = Console.ReadLine();

            Console.WriteLine(" Digite o seu CPF: ");
            variaveis.CPFCliente = Console.ReadLine();

            Console.WriteLine(" Digite o seu número de telefone: ");
            variaveis.TelefoneCliente = Console.ReadLine();

            Console.WriteLine(" Você possui alguma alergia, ferida ou condições prévias? ");
            variaveis.ObservacoesAnamnese = Console.ReadLine();

            Console.WriteLine(" Possui diabetes? (true/false): ");
            variaveis.PossuiDiabetes = bool.Parse(Console.ReadLine());

            Console.WriteLine(" Informe a sua data de nascimento/Idade: ");
            variaveis.DataNascimento = DateTime.Parse(Console.ReadLine());

            
            Console.WriteLine("\n--- PACIENTE CADASTRADO ---");
            Console.WriteLine("ID" + variaveis.IdCliente);
            Console.WriteLine("CPF: " + variaveis.CPFCliente);
            Console.WriteLine("TELEFONE: " + variaveis.TelefoneCliente);
            Console.WriteLine("OBSERVAÇÕES: " + variaveis.ObservacoesAnamnese);
            Console.WriteLine("POSSUI DIABETES: " + variaveis.PossuiDiabetes);
            Console.WriteLine("DATA DE NASCIMENTO: " + variaveis.DataNascimento);

            Console.WriteLine("\nCliente cadastrado com sucesso! ");
            Console.ReadLine();


        }
        static void CadastrarProcedimento()
        {

            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░██████╗░░█████╗░░█████╗░███████╗██████╗░██╗███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗██║████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
██████╔╝██████╔╝██║░░██║██║░░╚═╝█████╗░░██║░░██║██║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██╔═══╝░██╔══██╗██║░░██║██║░░██╗██╔══╝░░██║░░██║██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗██████╔╝██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═════╝░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();

            Console.Write("Digite o ID do procedimento: ");
            variaveis.IdProcedimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do procedimento: ");
            variaveis.NomeProcedimento = Console.ReadLine();

            Console.Write("Digite a duração em minutos: ");
            variaveis.DuracaoProcedimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do procedimento: R$ ");
            variaveis.ValorProcedimento = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n--- PROCEDIMENTO CADASTRADO ---");
            Console.WriteLine("ID" + variaveis.IdProcedimento);
            Console.WriteLine("Nome: " + variaveis.NomeProcedimento);
            Console.WriteLine("Duração: " + variaveis.DuracaoProcedimento + " minutos");
            Console.WriteLine("Valor: R$ " + variaveis.ValorProcedimento);

            Console.WriteLine("\nProcedimento Cadastrado com Sucesso! ");
            Console.ReadLine();



        }
        static void CadastroProfissional()
        {
            
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

██████╗░██████╗░░█████╗░███████╗██╗░██████╗░██████╗██╗░█████╗░███╗░░██╗░█████╗░██╗░░░░░
██╔══██╗██╔══██╗██╔══██╗██╔════╝██║██╔════╝██╔════╝██║██╔══██╗████╗░██║██╔══██╗██║░░░░░
██████╔╝██████╔╝██║░░██║█████╗░░██║╚█████╗░╚█████╗░██║██║░░██║██╔██╗██║███████║██║░░░░░
██╔═══╝░██╔══██╗██║░░██║██╔══╝░░██║░╚═══██╗░╚═══██╗██║██║░░██║██║╚████║██╔══██║██║░░░░░
██║░░░░░██║░░██║╚█████╔╝██║░░░░░██║██████╔╝██████╔╝██║╚█████╔╝██║░╚███║██║░░██║███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝");
            Console.ResetColor();


            Console.Write("Digite o ID do profissional: ");
            variaveis.IdProfissional = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome completo do profissional: ");
            variaveis.NomeProfissional = Console.ReadLine();

            Console.WriteLine("Insira o número de telefone: ");
            variaveis.TelefoneProfissional = Console.ReadLine();

            Console.Write("Insira o Número do conselho/registro técnico: ");
            variaveis.RegistroProfissional = Console.ReadLine();

            Console.Write("Digite a sua especialidade: R$ ");
            variaveis.Especialidade = Console.ReadLine();

            Console.WriteLine("\n--- PROFISSIONAL CADASTRADO ---");
            Console.WriteLine("ID: " + variaveis.IdProfissional);
            Console.WriteLine("Nome: " + variaveis.NomeProfissional);
            Console.WriteLine("Telefone: " + variaveis.TelefoneProfissional);
            Console.WriteLine("Registro: " + variaveis.RegistroProfissional);
            Console.WriteLine("Especialidade: R$ " + variaveis.Especialidade);

            Console.WriteLine("\nProfissional Cadastrado com Sucesso! ");
            Console.ReadLine();

        }
        static void Agendamento()
        {
            
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░██████╗░███████╗███╗░░██╗██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝░██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
███████║██║░░██╗░█████╗░░██╔██╗██║██║░░██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██╔══██║██║░░╚██╗██╔══╝░░██║╚████║██║░░██║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();

            Console.Write("Digite o ID do agendamento: ");
            variaveis.IdAgendamento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ID do cliente cadastrado: ");
            variaveis.ClienteIdAgendamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do profissional responsável: ");
            variaveis.PodologoIdAgendamento = int.Parse(Console.ReadLine());

            Console.Write("Digite o Código do procedimento a ser realizado: ");
            variaveis.ProcedimentoIdAgendamento = int.Parse(Console.ReadLine());

            Console.Write("Digite a Data e horário marcados: ");
            variaveis.DataHoraAgendamento = DateTime.Parse(Console.ReadLine());

            if (variaveis.StatusAgendamento == "Agendado")
            {
                Console.WriteLine("O agendamento está marcado.");
            }
            else if (variaveis.StatusAgendamento == "Concluído")
            {
                Console.WriteLine("O agendamento foi concluído.");
            }
            else if (variaveis.StatusAgendamento == "Cancelado")
            {
                Console.WriteLine("O agendamento foi cancelado.");
            }

            Console.WriteLine("\n--- AGENDADO ---");
            Console.WriteLine("ID do agendamento: " + variaveis.IdAgendamento);
            Console.WriteLine("ID do cliente: " + variaveis.ClienteIdAgendamento);
            Console.WriteLine("Codigo do Profissional responsavel: " + variaveis.PodologoIdAgendamento);
            Console.WriteLine("Código do procedimento realizado: " + variaveis.ProcedimentoIdAgendamento);
            Console.WriteLine("Data e Hora marcado: " + variaveis.DataHoraAgendamento);

        }
        static void listaProcedimento()
        {
            Console.WriteLine("\n--- PROCEDIMENTO CADASTRADO ---");
            Console.WriteLine("ID" + variaveis.IdProcedimento);
            Console.WriteLine("Nome: " + variaveis.NomeProcedimento);
            Console.WriteLine("Duração: " + variaveis.DuracaoProcedimento + " minutos");
            Console.WriteLine("Valor: R$ " + variaveis.ValorProcedimento);
        }
        static void ListaProfissional()
        {
            Console.WriteLine("\n--- PROFISSIONAL CADASTRADO ---");
            Console.WriteLine("ID: " + variaveis.IdProfissional);
            Console.WriteLine("Nome: " + variaveis.NomeProfissional);
            Console.WriteLine("Telefone: " + variaveis.TelefoneProfissional);
            Console.WriteLine("Registro: " + variaveis.RegistroProfissional);
            Console.WriteLine("Especialidade: R$ " + variaveis.Especialidade);
        }
        static void ListaAgendamento()
        {
            Console.WriteLine("\n--- AGENDADO ---");
            Console.WriteLine("ID do agendamento: " + variaveis.IdAgendamento);
            Console.WriteLine("ID do cliente: " + variaveis.ClienteIdAgendamento);
            Console.WriteLine("Codigo do Profissional responsavel: " + variaveis.PodologoIdAgendamento);
            Console.WriteLine("Código do procedimento realizado: " + variaveis.ProcedimentoIdAgendamento);
            Console.WriteLine("Data e Hora marcado: " + variaveis.DataHoraAgendamento);
        }
        static void ListaPaciente()
        {
            Console.WriteLine("\n--- PACIENTE CADASTRADO ---");
            Console.WriteLine("ID" + variaveis.IdCliente);
            Console.WriteLine("CPF: " + variaveis.CPFCliente);
            Console.WriteLine("TELEFONE: " + variaveis.TelefoneCliente);
            Console.WriteLine("OBSERVAÇÕES: " + variaveis.ObservacoesAnamnese);
            Console.WriteLine("POSSUI DIABETES: " + variaveis.PossuiDiabetes);
            Console.WriteLine("DATA DE NASCIMENTO: " + variaveis.DataNascimento);
        }
    }
}