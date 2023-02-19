using System;
using System.Configuration;                                                                                                     
using System.Data.SqlClient;                                                                                                   
using System.Windows.Forms;


namespace 课程设计_药库管理
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection=new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand=new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =                                                        
                $"SELECT COUNT(1) FROM tb_User" +
                $" WHERE No='{this.txb_UserNo.Text.Trim()}'" +								
                $" AND Password=HASHBYTES('MD5','{this.txb_Password.Text.Trim()}');";
            sqlConnection.Open();                                                           
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 
                                                                                            
            sqlConnection.Close();                                                          
            if (rowCount == 1)                                                              
            {
                MessageBox.Show("登录成功。");		
                frm_Manage frm_Manage = new frm_Manage();
                frm_Manage.Show();
                this.Close();
            }
            else                                                                            
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");								
                this.txb_Password.Focus();                                                  
                this.txb_Password.SelectAll();                                              
            }
        }
    }
}
