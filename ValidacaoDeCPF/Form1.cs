using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoDeCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cpf = txtCpf.Text;
      
             Util u = new Util(); //INSTANCIAR UM OBJETO

            if (u.ValidaCpf(txtCpf.Text))
            {
                MessageBox.Show("Cpf valido");
            }
            else
            {
                MessageBox.Show("Cpf invalido");
            }
                
        }
        }

    

    }


