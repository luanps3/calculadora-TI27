
using calculadora_TI27.Core;

namespace calculadora_TI27
{
    public partial class frmCalculadora : Form
    {
        private double _valor1;
        private double _valor2;
        private string _operacaoAtual;
        private bool _deveLimparVisor;

        public frmCalculadora()
        {
            InitializeComponent();
            ZerarCalculadora();
        }

        private void ZerarCalculadora()
        {
            _valor1 = 0;
            _valor2 = 0;
            _operacaoAtual = string.Empty;
            _deveLimparVisor = false;
            txtVisor.Text = "0";
        }



        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string numeroDigitado = botaoClicado.Text;

            if (_deveLimparVisor)
            {
                txtVisor.Text = "";
                _deveLimparVisor = false;
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = numeroDigitado;
            }
            else
            {
                txtVisor.Text += numeroDigitado;
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ZerarCalculadora();
        }

        private void PrepararOperacao(string operacao)
        {
            // Se já houver uma operação em andamento, calcula o resultado antes de preparar a nova operação
            double.TryParse(txtVisor.Text, out _valor1);

            // atribui a operação atual para a variável de operação
            _operacaoAtual = operacao;

            _deveLimparVisor = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            PrepararOperacao("/");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PrepararOperacao("*");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            PrepararOperacao("-");
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            PrepararOperacao("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_operacaoAtual))
                return;

            double.TryParse(txtVisor.Text, out _valor2);

            double resultado = 0;

            try
            {
                switch (_operacaoAtual)
                {
                    case "+": resultado = CalculadoraService.Somar(_valor1, _valor2);  break;
                    case "-": resultado = CalculadoraService.Subtrair(_valor1, _valor2); break;
                    case "*": resultado = CalculadoraService.Multiplicar(_valor1, _valor2); break;
                    case "/": resultado = CalculadoraService.Dividir(_valor1, _valor2); break;
                }
                txtVisor.Text = resultado.ToString();
                _operacaoAtual = string.Empty;
                _deveLimparVisor = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZerarCalculadora();
            }

        }
    }
}
