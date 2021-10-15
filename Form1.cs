using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textPrenom_TextChanged(object sender, EventArgs e)
        {

        }
        private void textNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String Prenom = textPrenom.Text;
            String Nom = textNom.Text;
            String Email = textEmail.Text;
            String Tel = textTel.Text;


            MessageBox.Show(Prenom +"\t"+ Nom + "\n" + Email + "\n" + Tel );
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
