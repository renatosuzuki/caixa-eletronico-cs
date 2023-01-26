using static System.Console;

namespace TransData.TesteTecnico.Saque {
   class FuncoesSaque {
        public static void LogicaPrincipalSaque() {
            int ValorNotasSaque = -1;

            string ValorNotasInput;

            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            while (ValorNotasSaque < 0) {
                WriteLine("Digite o ValorNotas do saque: ");

                ValorNotasInput = ReadLine()!;

                ValorNotasSaque = Convert.ToInt32(ValorNotasInput); 

                if (ValorNotasSaque < 0) {
                    WriteLine("O ValorNotas deve ser maior que 0");
                }
                else {
                    for (int i = 0; i < notas.Length; i++) {
                        int qtdNotas = ValorNotasSaque / notas[i];

                        ValorNotasSaque = ValorNotasSaque % notas[i];

                        if (ValorNotasSaque == 1 || ValorNotasSaque == 3) {
                            ValorNotasSaque = ValorNotasSaque + 1;
                        };

                        RespostaNotas RespostaNotas = new RespostaNotas(qtdNotas, notas[i]);

                        RespostaNotas.MostrarResposta();
                    }
                }
            };
        }
    }

    public class RespostaNotas {
        private int _QuantidadeNotas;

        private int _ValorNotas;

        private string? _Resposta;

        public RespostaNotas (int QuantidadeNotas, int ValorNotas) {
            _QuantidadeNotas = QuantidadeNotas;
            _ValorNotas = ValorNotas;
        }

        public string Resposta {
            get {
                if (_QuantidadeNotas == 0) {
                    return "";
                }

                else if (_QuantidadeNotas == 1) {
                    return $"{_QuantidadeNotas} nota de R$ {_ValorNotas},00";
                }

                return $"{_QuantidadeNotas} notas de R$ {_ValorNotas},00";
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