namespace Calculadora.Services
{
    public class CalculadoraService
    {
        private List<string> _historicoOperacoes;
        public CalculadoraService()
        {
            _historicoOperacoes = new List<string>();
        }

        public int Somar(int num1, int num2, string dtOperacao)
        {
            int res = num1 + num2;
            _historicoOperacoes.Add($"Res: {res} - Data: {dtOperacao}");

            return res;
        }

        public int Subtrair(int num1, int num2, string dtOperacao)
        {
            int res = num1 - num2;
            _historicoOperacoes.Add($"Res: {res} - Data: {dtOperacao}");

            return res;
        }

        public int Mutiplicar(int num1, int num2, string dtOperacao)
        {
            int res = num1 * num2;
            _historicoOperacoes.Add($"Res: {res} - Data: {dtOperacao}");

            return res;
        }

        public int Dividir(int num1, int num2, string dtOperacao)
        {
            int res = num1 / num2;
            _historicoOperacoes.Add($"Res: {res} - Data: {dtOperacao}");

            return res;
        }

        public List<string> HistoricoOperacoes() 
        {
            return _historicoOperacoes; 
        }

    }
}
