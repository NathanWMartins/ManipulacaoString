namespace ex6Manipulacao;
    internal class Program
    {
        static void Main(string[] args)
        {
            string municipiosStr = File.ReadAllText("C:/ProjetosAcadProgramador/cidades.csv");
            string[] linhas = municipiosStr.Split('\n');

            string[] posicao = new string[linhas.Length];
            string[] codigoIBGE = new string[linhas.Length];
            string[] municipio = new string[linhas.Length];
            string[] uf = new string[linhas.Length];
            string[] populacao = new string[linhas.Length];

            for (int i = 0; i < linhas.Length-2;i++)
            {
                string[] campos = linhas[i].Split(';');
                posicao[i] = campos[0];
                codigoIBGE[i] = campos[1];
                municipio[i] = campos[2];
                uf[i] = campos[3];
                populacao[i] = campos[4];
            }

            Console.WriteLine("Você quer apresentar as cidades agrupado(a) por: \n(1)Letras  (2)Estado ");
            int resposta = int.Parse(Console.ReadLine());

            string alf = "ABCDEFGHIJKLMONPQRSTUVWXYZ";

            if(resposta == 1)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    Console.WriteLine("Municipios com a letra " + alf[i] + ": ");
                    for (int j = 0; j < municipio.Length-2; j++)
                    {
                        if (alf[i].Equals(municipio[j][0]))
                        {
                            Console.WriteLine(municipio[j]);
                        }
                }  
                    Console.WriteLine();
                }
            }

            if(resposta == 2)
            {
                string[] estados = { " Acre", " Alagoas", " Amapá", " Amazonas", " Bahia", " Ceará", " Distrito Federal", " Espírito Santos", " Goiás",
                                    " Maranhão", " Mato Grosso", " Mato Grosso do Sul", " Minas Gerais", " Pará", " Paraíba", " Paraná", " Pernanbuco",
                                    " Piauí", " Rio de Janeiro", " Rio Grande do Norte", " Rio Grande do Sul", " Rondônia", " Roraima", " Santa Catarina",
                                    " São Paulo", " Sergipe", " Tocantins"};
                for (int i = 0; i < estados.Length; i++)
                {
                    Console.WriteLine("Municipios no estado de(a): " + estados[i] + ": ");
                    for(int j = 1;j < uf.Length-2; j++)
                    {
                        if (estados[i].Equals(uf[j]))
                        {
                            Console.WriteLine(municipio[j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }