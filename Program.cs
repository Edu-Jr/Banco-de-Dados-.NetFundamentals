using System;

namespace ProjetoDotNet
{
    class Program
    {
        static Serie_repositorio repositorio = new Serie_repositorio();
        
        static void Main ()
        {
            string OpcaoUsuario = ObteropcaoUsuario();

            while(OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                case "1":
                    ListarSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3":
                   AtualizarSerie();
                    break;
                case "4":
                    ExcluirSerie();
                    break;
                case "5":
                    VisualizarSerie();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();

                }
                OpcaoUsuario = ObteropcaoUsuario();

            }
            Console.WriteLine("Obrigado por utilizar nossos serviços. ");
            Console.ReadLine();
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine ("Digite O Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine ("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de Lançamento da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite a descrição da Série: ");
            String entradaDescricao = Console.ReadLine();

            Console.WriteLine ("Digite o Diretor da Série: ");
            String entradaDiretor = Console.ReadLine();

            Series atualizaSerie = new Series (id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        diretor: entradaDiretor);
            
            repositorio.atualizar(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine ("Digite o Id do item a ser excluído: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.excluir(indiceSerie);

        }

        private static void VisualizarSerie()
        {
            Console.WriteLine ("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);


        }


        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");
            var Lista = repositorio.Lista();

            if (Lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in Lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido? "Excluído" : ""));
            }
        }
         private static void InserirSerie()
         {
             Console.WriteLine("Inserir Nova Série: ");

             foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                 Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine ("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de Lançamento da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite a descrição da Série: ");
            String entradaDescricao = Console.ReadLine();

            Console.WriteLine ("Digite o diretor da Série: ");
            String entradaDiretor = Console.ReadLine();

            Series novaSerie = new Series (id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        diretor: entradaDiretor);
            repositorio.Insere(novaSerie);

         }


        private static string ObteropcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Projeto Dot Net - Seleção de séries");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
 
            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;





    
      


        
            
        }
    }
}
