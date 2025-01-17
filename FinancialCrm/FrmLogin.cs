using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
             var user = db.Users.Where(x => x.UserName == txtUserName.Text && x.Password==txtPassword.Text ).FirstOrDefault();

            if (user != null) 
            {

                MessageBox.Show("Giriş Başarılı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();

                
            
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            

        


        }
    }
}
