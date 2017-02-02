using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Levismad.Repository;
using log4net;

namespace Levismad
{
    static class Program
    {
        private static ILog _log;

        private static bool _c1;
        private static bool _c2;
        private static bool _c3;
        private static bool _c4;
        private static bool _c5;
        private static bool _c6;
        private static bool _c7;
        private static bool _c8;
        private static bool _c9;
        private static bool _c10;
        private static bool _c11;
        private static bool _c12;
        private static bool _c13;
        private static bool _c14;
        private static bool _c15;
        private static bool _c16;

        static void Main(string[] args)
        {
            if (args != null && args.Length >= 2 && args[0] == "config")
            {
                var origem = Environment.CurrentDirectory;
                CriarArquivo(TipoArquivo.Copiar, origem, args[1], args.Where((x, i) => i >= 2).ToList());
                CriarArquivo(TipoArquivo.Executar, origem, args[1], args.Where((x, i) => i >= 2).ToList());
                Console.WriteLine($"Arquivos gerados na pasta de origem: {origem}");
            }
            else
            {
                _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                _log.Info("Inicio do Processo de Carga");

                if (args == null || args.Length == 0)
                {

                    ExecutaConfiguracao();

                }
                else if (args.Length > 0)
                {

                    args.ToList().ForEach(arg =>
                    {
                        switch (arg)
                        {
                            case "1":
                                _c1 = true;
                                break;
                            case "2":
                                _c2 = true;
                                break;
                            case "3":
                                _c3 = true;
                                break;
                            case "4":
                                _c4 = true;
                                break;
                            case "5":
                                _c5 = true;
                                break;
                            case "6":
                                _c6 = true;
                                break;
                            case "7":
                                _c7 = true;
                                break;
                            case "8":
                                _c8 = true;
                                break;
                            case "9":
                                _c9 = true;
                                break;
                            case "10":
                                _c10 = true;
                                break;
                            case "11":
                                _c11 = true;
                                break;
                            case "12":
                                _c12 = true;
                                break;
                            case "13":
                                _c13 = true;
                                break;
                            case "14":
                                _c14 = true;
                                break;
                            case "15":
                                _c16 = true;
                                break;
                            case "16":
                                _c15 = true;
                                break;
                        }
                    });
                }

                Executar();
                _log.Info("Fim do Processo de Carga");
            }

            Console.WriteLine("Pressione Esc ou qualquer tecla para sair...");
            Console.ReadLine();
        }
        private static void Executar()
        {
            try
            {
                if (_c1)
                    new C1Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c2)
                    new C2Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c3)
                    new C3Repository().EfetuarCarga();
                //new C3Repository().EfetuarTeste();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c4)
                    new C4Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c5)
                    new C5Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c6)
                    new C6Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c7)
                    new C7Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c8)
                    new C8Repository().EfetuarCarga();
            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c9)
                    new C9Repository().EfetuarCarga();

            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c10)
                    new C10Repository().EfetuarCarga();
            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c11)
                    new C11Repository().EfetuarCarga();
            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c12)
                {
                    new C12Repository().EfetuarCarga();
                }
            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c13)
                {
                    new C13Repository().EfetuarCarga();
                }
            }
            catch (Exception)
            {

                //throw;
            }

            try
            {
                if (_c14)
                {
                    new C14Repository().EfetuarCarga(false);
                }
            }
            catch (Exception)
            {

                //throw;
            }


            try
            {
                if (_c15)
                {
                    new C14Repository().EfetuarCarga(true);
                }
            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                if (_c16)
                {
                    new C16Repository().EfetuarCarga();
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }
        private static void ExecutaConfiguracao()
        {


            var culture = new CultureInfo(ConfigurationManager.AppSettings["DefaultCulture"]);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            _c1 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C1"]);
            _c3 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C3"]);
            _c2 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C2"]);
            _c4 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C4"]);
            _c5 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C5"]);
            _c6 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C6"]);
            _c7 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C7"]);
            _c8 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C8"]);
            _c9 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C9"]);
            _c10 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C10"]);
            _c11 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C11"]);
            _c12 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C12"]);
            _c13 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C13"]);
            _c14 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C14"]);
            _c15 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C15"]);
            _c16 = bool.Parse(ConfigurationManager.AppSettings["Levismad.ExecutarCarga.C16"]);
        }

        private static void CriarArquivo(TipoArquivo tipo, string origem, string destino, IReadOnlyCollection<string> args)
        {
            switch (tipo)
            {
                case TipoArquivo.Copiar:
                    CriarArquivoCopiar(origem, destino, args);
                    break;
                case TipoArquivo.Executar:
                    CriarArquivoExecutar(origem, destino, args);
                    break;
            }
        }

        private static void CriarArquivoCopiar(string origem, string destino, IReadOnlyCollection<string> args)
        {

            using (var sw = new StreamWriter(origem + "\\copiar_arquivos.bat"))
            {
                if (args.Any())
                {
                    for (var i = 0; i < args.Count; i++)
                    {
                        sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_{i + 1}\\\" /E");
                    }
                }
                else
                {
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_1\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_2\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_3\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_4\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_5\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_6\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_7\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_8\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_9\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_10\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_11\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_12\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_13\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_14\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_15\\\" /E");
                    sw.WriteLine($"xcopy \"{origem}\" \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_16\\\" /E");
                }
                sw.Close();
            }
        }
        private static void CriarArquivoExecutar(string origem, string destino, IReadOnlyCollection<string> args)
        {

            using (var sw = new StreamWriter(origem + "\\executar_migracao.bat"))
            {
                if (args.Any())
                {
                    for (var i = 0; i < args.Count; i++)
                    {
                        sw.WriteLine(GetExecutionPath(args.ElementAt(i), i + 1, destino));
                    }

                }
                else
                {
                    sw.WriteLine(
                        $"start \"CargaClientes\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_1\\Levismad.exe\" 1  ");
                    sw.WriteLine(
                        $"start \"CargaParcelas\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_2\\Levismad.exe\" 2");
                    sw.WriteLine(
                        $"start \"CargaPropostas\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_3\\Levismad.exe\" 3  ");
                    sw.WriteLine(
                        $"start \"CargaPagamentos e Ocorrencias Peculio\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_4\\Levismad.exe\" 4");
                    sw.WriteLine(
                        $"start \"CargaContatos\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_5\\Levismad.exe\" 5  ");
                    sw.WriteLine(
                        $"start \"CargaBancarios\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_6\\Levismad.exe\" 6");
                    sw.WriteLine(
                        $"start \"CargaEnderecos\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_7\\Levismad.exe\" 7  ");
                    sw.WriteLine(
                        $"start \"CargaOcupacoes\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_8\\Levismad.exe\" 8");
                    sw.WriteLine(
                        $"start \"CargaDadosProfissionais\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_9\\Levismad.exe\" 9  ");
                    sw.WriteLine(
                        $"start \"CargaOrgao\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_10\\Levismad.exe\" 10");
                    sw.WriteLine(
                        $"start \"CargaSubOrgao\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_11\\Levismad.exe\" 11  ");
                    sw.WriteLine(
                        $"start \"CargaTransferenciaAtraso e Prejuizo\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_12\\Levismad.exe\" 12 13");
                    sw.WriteLine(
                        $"start \"CargaOcorrencia\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_14\\Levismad.exe\" 14 16");
                    sw.WriteLine(
                        $"start \"CargaLiberacao\" cmd.exe /C \"{destino}\\Rotinas Migracao\\Execucao Paralela\\Rotina_15\\Levismad.exe\" 15");
                    sw.WriteLine("pause");
                }
                sw.Close();
            }
        }

        private static string GetExecutionPath(string param, int idx, string path)
        {
            var name = "";
            var composto = false;
            var aux = param.Split('#').ToList();
            aux.ForEach(x =>
            {
                if (name.Length > 0) composto = true;
                switch (x)
                {
                    case "1":
                        name += (composto ? " e " : "") + "CargaC1";
                        break;
                    case "2":
                        name += (composto ? " e " : "") + "CargaC2";
                        break;
                    case "3":
                        name += (composto ? " e " : "") + "CargaC3";
                        break;
                    case "4":
                        name += (composto ? " e " : "") + "CargaC4";
                        break;
                    case "5":
                        name += (composto ? " e " : "") + "CargaC5";
                        break;
                    case "6":
                        name += (composto ? " e " : "") + "CargaC6";
                        break;
                    case "7":
                        name += (composto ? " e " : "") + "CargaC7";
                        break;
                    case "8":
                        name += (composto ? " e " : "") + "CargaC8";
                        break;
                    case "9":
                        name += (composto ? " e " : "") + "CargaC9";
                        break;
                    case "10":
                        name += (composto ? " e " : "") + "CargaC10";
                        break;
                    case "11":
                        name += (composto ? " e " : "") + "CargaC11";
                        break;
                    case "12":
                        name += (composto ? " e " : "") + "CargaC12";
                        break;
                    case "13":
                        name += (composto ? " e " : "") + "CargaC13";
                        break;
                    case "14":
                        name += (composto ? " e " : "") + "CargaC14";
                        break;
                    case "16":
                        name += (composto ? " e " : "") + "CargaC16";
                        break;
                    case "15":
                        name += (composto ? " e " : "") + "Carga15";
                        break;
                }

            });
            return $"start \"{name}\" cmd.exe /C \"{path}\\Rotinas Migracao\\Execucao Paralela\\Rotina_{idx}\\Levismad.exe\" {string.Join(" ", aux.ToArray())}  ";
        }
        private enum TipoArquivo
        {
            Copiar = 0,
            Executar = 1
        }

    }
}
