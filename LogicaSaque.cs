using static System.Console;

namespace TransData.TesteTecnico.Saque {
   class FuncaoSaque {
        public static void LogicaSaque() {
            int valorSaque = -1;

            string valorInput;

            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            while (valorSaque < 0) {
                WriteLine("Digite o valor do saque: ");

                valorInput = ReadLine()!;

                valorSaque = Convert.ToInt32(valorInput); 

                if (valorSaque < 0) {
                    WriteLine("O valor deve ser maior que 0");
                }
                else {
                    for (int i = 0; i < notas.Length; i++) {
                        int qtdNotas = valorSaque / notas[i];

                        valorSaque = valorSaque % notas[i];

                        if (valorSaque == 1 || valorSaque == 3) {
                            valorSaque = valorSaque + 1;
                        };

                        RespostaNotas RespostaNotas = new RespostaNotas(qtdNotas, notas[i]);

                        RespostaNotas.MostrarResposta();
                    }
                }
            };
        }
    }

    public class RespostaNotas {
        private int _Quantidade;

        private int _Valor;

        private string? _Resposta;

        public RespostaNotas (int Quantidade, int Valor) {
            _Quantidade = Quantidade;
            _Valor = Valor;
        }

        public string Resposta {
            get {
                if (_Quantidade == 0) {
                    return "";
                }
                
                else if (_Quantidade == 1) {
                    return $"{_Quantidade} nota de R$ {_Valor},00";
                }

                return $"{_Quantidade} notas de R$ {_Valor},00";
            } 
            set {
                _Resposta = value;
            }
        }

        public void MostrarResposta() {
            WriteLine(Resposta);
        }
    }
}