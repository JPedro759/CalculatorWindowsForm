using System;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        String conta;
        String contacento;
        String operador;
        Double resultado;
        Double memoria;
        Double porcentagem;

        bool mudar = false;

        public Form1() => InitializeComponent();

        private void btnOpe_Click(object sender, EventArgs e)
        {
            Button op = sender as Button;
            operador = op.Text;
            conta = txtresultado.Text;
            txtresultado.Text = Evaluate(lblconta.Text + txtresultado.Text).ToString();
            lblconta.Text += conta + " " + op.Text + " ";
            mudar = true;
        }

        private double Evaluate(string expression)
        {
            expression = expression.Replace(",", ".");
            expression = expression.Replace("÷", "/");
            expression = expression.Replace("X", "*");

            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
            }
            catch
            {
                return double.Parse("0");
            }
        } 

        private void btnC_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
            lblconta.Text = "";
        }

        private void bnt_Click(object sender, EventArgs e)
        {
            Button bnt = sender as Button;
            if (txtresultado.Text == "0" || mudar)
            {
                txtresultado.Text = "";
                mudar = false;
            }
            txtresultado.Text += bnt.Text;
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
                txtresultado.Text = txtresultado.Text + ",";
        }

        private void btnCE_Click(object sender, EventArgs e) => txtresultado.Text = "0";

        private void btnseta_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length > 0)
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1, 1);

            if (txtresultado.Text == "")
                txtresultado.Text = "0";
        }

        private void btninversao_Click(object sender, EventArgs e)
        {
            txtresultado.Text = Convert.ToString(-Convert.ToInt32(txtresultado.Text));
            mudar = false;
        }

        private void btnfraçao_Click(object sender, EventArgs e)
        {
            lblconta.Text += "reciproc(" + txtresultado.Text + ")";
            Double fraçao = (1/double.Parse(txtresultado.Text));
            txtresultado.Text = fraçao.ToString();
            mudar = true;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            conta = lblconta.Text + txtresultado.Text;
            resultado = Evaluate(conta);
            txtresultado.Text = resultado.ToString();
            lblconta.Text = "";
            mudar = true;
        }

        private void btnMRN_Click(object sender, EventArgs e) => memoria -= Convert.ToDouble(txtresultado.Text);

        private void btnMRP_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(txtresultado.Text);
            mudar = true;
            txtMemoria.Text = "M";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(txtresultado.Text);
            mudar = true;
            txtMemoria.Text = "M";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtresultado.Text = Convert.ToString(memoria);
            mudar = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            txtMemoria.Text = "";
            mudar = true;
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            lblconta.Text += "sqrt(" + txtresultado.Text + ")";
            Double raiz = Math.Sqrt(Convert.ToDouble(txtresultado.Text));
            txtresultado.Text = raiz.ToString();
            mudar = false;
        }

        private void btnporcentagem_Click(object sender, EventArgs e)
        {
            conta = txtresultado.Text;
            porcentagem = Convert.ToDouble(txtresultado.Text) / Convert.ToDouble(100);
            txtresultado.Text = Evaluate(lblconta.Text + porcentagem).ToString();
            lblconta.Text += txtresultado.Text;
            mudar = true;
        }
    }
}
