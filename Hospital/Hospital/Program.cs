using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Hospital.Program;

namespace Hospital
{
    internal class Program
      {

            public static class variaveis
            {
                // Variáveis globais 
                public static int IdPaciente;
                public static string NomePaciente;
                public static string CPFPaciente;
                public static DateTime DataNascimento;
                public static string TipoSanguineo;
                public static string AlergiasPaciente;
                public static string ContatoEmergencia;

                public static int IdMedico;
                public static string NomedoMedico;
                public static string CRM;
                public static string Especialidade;
                public static string TelefoneEmergencia;

                public static int Leitoid;
                public static string NumeroQuarto;
                public static string TipodeLeito;
                public static bool EstaOcupado;

                public static int Idinternacao;
                public static int PacienteId;
                public static int MedicoResponsavelId;
                public static DateTime DataEntrada;
                public static DateTime? DataAlta = null;
                public static string DiagnosticoEntrada, Status;
                
                public static int internacoes;
            }

            static void Main(string[] args)
            {
                int opcao = 0;
                while (opcao != 7)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1 - Cadastrar Paciente");
                    Console.WriteLine("2 - Cadastrar Médico");
                    Console.WriteLine("3 - Cadastrar Leito");
                    Console.WriteLine("4 - Registrar Internação (Entrada)");
                    Console.WriteLine("5 - Dar Alta Hospitalar (Saída)");
                    Console.WriteLine("6 - Listar Pacientes Internados");
                    Console.WriteLine("7 - Exibir Relatório Geral do Hospital");
                    Console.WriteLine("0 - Sair");
                    Console.ResetColor();
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            CadastroPaciente();
                            break;
                        case 2:
                            CadastrarMedico();
                            break;
                        case 3:
                            CadastrarLeito();
                            break;
                        case 4:
                            Internacao();
                            break;
                        case 5:
                            AltaHospitalar();
                            break;
                        case 6:
                            PacientesInternados();
                            break;
                        case 7:
                            RelatorioGeral();
                            break;
                        case 0:
                            Console.WriteLine("Você saiu do sistema.");
                            break;

                    }
                }
            }
            static void CadastroPaciente()
            {

                Console.Clear();
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
                Console.ResetColor();



                Console.WriteLine("Digite ID do Paciente:");
                variaveis.IdPaciente = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                variaveis.NomePaciente = Console.ReadLine();

                Console.Write("CPF: ");
                variaveis.CPFPaciente = Console.ReadLine();

                Console.Write("Data de nascimento (DD/MM/XXXX): ");
                variaveis.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Tipo sanguíneo: ");
                variaveis.TipoSanguineo = Console.ReadLine();

                Console.Write("Alergias: ");
                variaveis.AlergiasPaciente = Console.ReadLine();

                Console.Write("Contato de emergência: ");
                variaveis.ContatoEmergencia = Console.ReadLine();

                Console.WriteLine("\n-- PACIENTE CADASTRADO ---");
                Console.WriteLine("ID" + variaveis.IdPaciente);
                Console.WriteLine("Nome: " + variaveis.NomePaciente);
                Console.WriteLine("CPF: " + variaveis.CPFPaciente);
                Console.WriteLine("Data de Nascimento: " + variaveis.DataNascimento);
                Console.WriteLine("Tipo Sanguíneo: " + variaveis.TipoSanguineo);
                Console.WriteLine("Alergias: " + variaveis.AlergiasPaciente);
                Console.WriteLine("Contato de Emergência: " + variaveis.ContatoEmergencia);
                Console.WriteLine("\nPaciente cadastrado com sucesso!");
                Console.ReadLine();
            }
            static void CadastrarLeito()
            {
                Console.Clear();
                Console.WriteLine(@"
██╗░░░░░███████╗██╗████████╗░█████╗░
██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
███████╗███████╗██║░░░██║░░░╚█████╔╝
╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
                Console.ResetColor();

                Console.WriteLine("Digite o ID do Leito:");
                variaveis.Leitoid = int.Parse(Console.ReadLine());

                Console.Write("Número do quarto/ala: ");
                variaveis.NumeroQuarto = Console.ReadLine();

                Console.Write("Tipo do leito (Enfermaria/Apartamento/UTI): ");
                variaveis.TipodeLeito = Console.ReadLine();

                Console.WriteLine("O leito está ocupado? (true/false) ");
                variaveis.EstaOcupado = bool.Parse(Console.ReadLine());

                Console.WriteLine("\nLeito cadastrado com sucesso!");
                Console.ReadLine();

            }
            static void CadastrarMedico()
            {
                Console.Clear();
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");
                Console.ResetColor();

                Console.WriteLine("Digite o ID do Profissional: ");
                variaveis.IdMedico = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome do Profissonal: ");
                variaveis.NomedoMedico = Console.ReadLine();

                Console.WriteLine("Digite o CRM do Profissional: ");
                variaveis.CRM = Console.ReadLine();

                Console.WriteLine("Digite a Especialidade do Profissional: ");
                variaveis.Especialidade = Console.ReadLine();

                Console.WriteLine("Digite o telefone do Profissional: ");
                variaveis.TelefoneEmergencia = Console.ReadLine();

                Console.WriteLine("\n--- MÉDICO CADASTRADO ---");
                Console.WriteLine("ID" + variaveis.IdMedico);
                Console.WriteLine("Nome: " + variaveis.NomedoMedico);
                Console.WriteLine("CRM: " + variaveis.CRM);
                Console.WriteLine("Especialidade: " + variaveis.Especialidade);
                Console.WriteLine("Contato de Emergência: " + variaveis.TelefoneEmergencia);
                Console.WriteLine("\nMédico cadastrado com sucesso!");
                Console.ResetColor();


            }
            static void Internacao()
            {
                Console.Clear();
                Console.WriteLine(@"
██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
                Console.ResetColor();

                Console.WriteLine("Digite o ID da internação: ");
                variaveis.Idinternacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ID do paciente: ");
                variaveis.PacienteId = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ID do Médico Respónsavel: ");
                variaveis.MedicoResponsavelId = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o código do Leito alocado: ");
                variaveis.Leitoid = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data e a hora da admissão: ");
                var entradaInput = Console.ReadLine();
                variaveis.DataEntrada = DateTime.Parse(entradaInput);

                Console.WriteLine("Digite Data e hora da alta (deixe em branco caso ainda esteja internado): ");
                var altaInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(altaInput))
                {
                variaveis.DataAlta = null;
                }
                else
                {
                variaveis.DataAlta = DateTime.Parse(altaInput);
                }

                Console.WriteLine("Digite o Motivo da internação: ");
                variaveis.DiagnosticoEntrada = Console.ReadLine();

                Console.WriteLine("Digite o Status da internação: ");
                Console.WriteLine(" 1 - Em internação");
                Console.WriteLine(" 2 - Alta concluída");
                Console.WriteLine(" 3 - Transferido");
                variaveis.Status = Console.ReadLine();

            }
            static void AltaHospitalar()
            {
                if (variaveis.Status == null)
            {
                Console.WriteLine("Não existe nenhuma internação cadastrada.");
            }
                else if (variaveis.Status.Trim().Equals("Em Internação", StringComparison.OrdinalIgnoreCase))
            {
                variaveis.DataAlta = DateTime.Now;
                variaveis.Status = "Alta Concluída";

                Console.WriteLine("Alta hospitalar realizada com sucesso!");
                Console.WriteLine($"Data da alta: {variaveis.DataAlta}");
            }
                else
            {
                Console.WriteLine("O paciente não está internado.");
                Console.WriteLine($"Status atual: {variaveis.Status}");
            }

                Thread.Sleep(2000);
        }
        static void PacientesInternados()
        {
                Console.Clear();
                Console.WriteLine(" ID do paciente:" + variaveis.PacienteId);
                Console.WriteLine(" Nome do Paciente:" + variaveis.NomePaciente);
                Console.WriteLine(" Tipo sanguineo do paciente:" + variaveis.TipoSanguineo);
                Console.WriteLine(" Paciente Alergico à:" + variaveis.AlergiasPaciente);
                Console.WriteLine(" Contato De emergencia:" + variaveis.ContatoEmergencia);
                Console.WriteLine(" Numero do quarto:" + variaveis.NumeroQuarto);
                
                if (variaveis.Status != null && variaveis.Status == "em internação")
            {
                Console.WriteLine(" Identificação do paciente:" + variaveis.PacienteId);
                Console.WriteLine(" Nome do Paciente:" + variaveis.NomePaciente);
                Console.WriteLine(" Tipo sanguíneo:" + variaveis.TipoSanguineo);
                Console.WriteLine(" Alergias:" + variaveis.AlergiasPaciente);
                Console.WriteLine(" Contato de emergência:" + variaveis.ContatoEmergencia);
                Console.WriteLine(" Numero do quarto:" + variaveis.NumeroQuarto);
                Console.WriteLine(" Status:" + variaveis.Status);
            }
                else
            {
                Console.WriteLine("Não foi encontrado nenhum paciente internado.");
            }
                Thread.Sleep(2000);
        }
        static void RelatorioGeral()
        {
                Console.WriteLine(" ID do Paciente:" + variaveis.PacienteId);
                Console.WriteLine(" Nome do Paciente:" + variaveis.NomePaciente);
                Console.WriteLine(" CPF Do Paciente:" + variaveis.CPFPaciente);
                Console.WriteLine(" Tipo Sanguineo:" + variaveis.TipoSanguineo);
                Console.WriteLine(" Alergias Do Paciente:" + variaveis.AlergiasPaciente);
                Console.WriteLine(" Contato De Emergencia:" + variaveis.ContatoEmergencia);
                Console.WriteLine(" Data de Nascimento:" + variaveis.DataNascimento);

                Console.WriteLine(" ID do medico:" + variaveis.IdMedico);
                Console.WriteLine(" Nome do Medico:" + variaveis.NomedoMedico);
                Console.WriteLine(" CRM do Medico:" + variaveis.CRM);
                Console.WriteLine(" Especialidade Do Medico:" + variaveis.Especialidade);
                Console.WriteLine(" Telefone do Medico:" + variaveis.TelefoneEmergencia);
                Console.WriteLine(" Numero Do Quarto:" + variaveis.NumeroQuarto);
                Console.WriteLine(" Tipo De Leito:" + variaveis.TipodeLeito);
                Console.WriteLine(" Estado do Quarto:" + variaveis.EstaOcupado);

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                Thread.Sleep(5000);
        }
        
    }
}
