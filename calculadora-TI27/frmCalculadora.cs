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
    }
}
