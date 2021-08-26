using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bit3rdSemester
{
    
    public partial class data_entry : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-96FNSP3\SQLEXPRESS;Initial Catalog=bit3rdsemester;Integrated Security=True");
        public data_entry()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                //open sql connection
                sql.Open();

                string st_name = textBox_name.Text;
                string st_add = textBox_address.Text;
                

                // var file_name = "";
                string file_name = "";
                string path = "";
                if (openfiledialog != null)
                {
                    if(File.Exists(openfiledialog.FileName))
                    {
                        file_name = Path.GetFileName(openfiledialog.FileName);
                        path = Application.StartupPath + "\\uploadedimage\\" + file_name;
                        if(!Directory.Exists(Application.StartupPath + "\\uploadedimage\\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\uploadedimage\\");
                        }
                        File.Copy(openfiledialog.FileName, path);
                    }
                }
                
                

                //save data to database
                string query = "Insert into student_details(name,address,photo_path) values (@parameter_name,@parameter_address,@parameter_photo_path)";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.Parameters.AddWithValue("@parameter_name",st_name);
                cmd.Parameters.AddWithValue("@parameter_address", st_add);
                cmd.Parameters.AddWithValue("@parameter_photo_path", path);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved succesfully");
                textBox_name.Text = "";
                textBox_address.Text = "";

                //perform save action or select query
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close sql connection
                sql.Close();
            }

            displaydata();


            //    string name = textBox_name.Text;
            //    string address = textBox_address.Text;

            //    //creates new row
            //    //student_list.Rows.Add();

            //    //set data to display
            //    student_list.Rows.Add(student_list.Rows.Count+1,  name, address );
        }

        private void displaydata()
        {
            try
            {
                if (sql.State != ConnectionState.Open)
                {
                    //open sql connection
                    sql.Open();

                }


                //save data to database
                string query = "Select *from student_details";
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                student_list.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    //string saved_file_path = dataRow["photo_path"].ToString();
                    //Bitmap image = null;
                    //if(File.Exists(saved_file_path))
                    //{
                    //    image = new Bitmap(saved_file_path);
                    //}
                    sn++;
                    student_list.Rows.Add(sn,dataRow["id"], dataRow["name"],dataRow["address"],dataRow["photo_path"],"Edit");
                }
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (sql.State == ConnectionState.Open)
                {
                    //close sql connection
                    sql.Close();
                }

            }
        }

        private void Button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                //open sql connection
                sql.Open();
                //for removinf if any of the cells are selected int he row
                //student_list.Rows.RemoveAt(student_list.CurrentRow.Index);
                if (student_list.SelectedRows.Count > 0)
                {
                    //for removing single row
                    //student_list.Rows.RemoveAt(student_list.SelectedRows[0].Index);

                    //for removing multiple rows
                    foreach (DataGridViewRow row in student_list.SelectedRows)
                    {

                        int id = Convert.ToInt32(row.Cells["STDID"].Value);

                        //save data to database
                        string query = "Delete from student_details where id=@parameter_id";
                        SqlCommand cmd = new SqlCommand(query, sql);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        student_list.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed succesfully");
                        //perform save action or select query

                    }
                    int i = 0;
                    foreach (DataGridViewRow row in student_list.Rows)
                    {
                        i++;
                        row.Cells["SN"].Value = i;
                    }
                }
                else
                {
                    MessageBox.Show("select a row to delete");
                }
                
            }


                
            catch (Exception ex)
            {
                   MessageBox.Show(ex.ToString());
            }
            finally
            {
                  //close sql connection
                  sql.Close();
            }
            displaydata();
        }

        private void Data_entry_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        int student_id;
        private void Student_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==student_list.Columns["action"].Index)
            {
                string student_name = student_list.CurrentRow.Cells["naam"].Value.ToString();
                student_id = Convert.ToInt32(student_list.CurrentRow.Cells["STDID"].Value.ToString());
                string student_address = student_list.CurrentRow.Cells["Address"].Value.ToString();
                string photo_path = student_list.CurrentRow.Cells["Filepath"].Value.ToString();

                MessageBox.Show("Id:" + student_id + "\n name:" + student_name);

                textBox_name.Text = student_name;
                textBox_address.Text = student_address;
                photo.Image = Image.FromFile(photo_path);
            }
        }

        private void update_click(object sender, EventArgs e)
        {
            try
            {
                if (student_id != 0)
                { 
                //open sql connection
                sql.Open();

                string st_name = textBox_name.Text;
                string st_add = textBox_address.Text;

                //save data to database
                string query = "Update student_details set name=@parameter_name, address=@parameter_address where id=@parameter_id";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.Parameters.AddWithValue("@parameter_name", st_name);
                cmd.Parameters.AddWithValue("@parameter_address", st_add);
                cmd.Parameters.AddWithValue("@parameter_id", student_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved succesfully");
                textBox_name.Text = "";
                textBox_address.Text = "";
                student_id = 0;

                    //perform save action or select query
                }
                else
                {
                    MessageBox.Show("please edit the data before clicking update");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //close sql connection
                sql.Close();
            }

            displaydata();
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_address.Text = "";
            student_id = 0;
        }

        private void open_calc(object sender, EventArgs e)
        {
            this.Hide();
            Form1 calc = new Form1();
            calc.ShowDialog();
            this.Show();
        }

        OpenFileDialog openfiledialog = new OpenFileDialog();
        private object file;

        private void sel_photo(object sender, EventArgs e)
        {
            openfiledialog.Filter = "Images only. |*jpeg; |*.jpg; |*.png";
            if(openfiledialog.ShowDialog()==DialogResult.OK)
            {
                photo.Image = Image.FromFile(openfiledialog.FileName);
            }
            else
            {
                MessageBox.Show("closed the dialog");
            }
        }
    }
}
