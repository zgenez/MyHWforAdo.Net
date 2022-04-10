using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // 1. SqlConnection
            // 2. SqlCommand
            // 3. SqlDataReader  
            // 4.  UI Control

            SqlConnection conn = null;
            try
            {


                conn =
                new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");


                conn.Open();


                SqlCommand command = new SqlCommand("select*from Products", conn);
                SqlDataReader dataReader = command.ExecuteReader();



                while (dataReader.Read())
                {
                    ////字串整理格式化
                    string.Format(...) //syntax sugar 語法糖  $"{}"
                    //String s = $"{dataReader["ProductName"],-40}"   //  -40 置左並給予40個字元
                    //                + $"-{dataReader["UnitPrice"]:c2}";           //   c2 貨幣格式 NT


                    this.comboBox1.Items.Add(s);


                    ////注意輸出文字避免迴圈失敗
                    //this.listBox1.Items.Add(dataReader["ProductName"]
                    //                                          + dataReader["ProductName"].ToString());

                }

                ////MessageBox.Show(dataReader["ProductName"].ToString());



                MessageBox.Show("Sucessfully");
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


            finally
            {

                if (conn != null)

                {
                    conn.Close();

                    //.............
                }


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
