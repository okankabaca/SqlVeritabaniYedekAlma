using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlVeritabaniYedekAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            String sourceDb = txtSourceDb.Text;
            String sourceTable = txtSourceTable.Text;
            String targetDb = txtTargetDb.Text;
            String targetTable = txtTargetTable.Text;
            String serverName=txtServer.Text;
            String userID=txtUserID.Text;

            var connectionString = $@"SERVER={serverName};Database={sourceDb};uId={userID};Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "CREATE  DATABASE "+ targetDb;
            command.ExecuteNonQuery();
            command.Dispose();
            command.CommandText = "USE "+ targetDb + "; select * into "+ targetTable + " from " + sourceDb + ".dbo."+ sourceTable + ";";
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            connection.Dispose();
        }
    }
}
