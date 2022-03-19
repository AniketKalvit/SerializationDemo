using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WinformDemos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo";
            DirectoryInfo df = new DirectoryInfo(path);
            if (df.Exists) // check that folder is already exists or not
            {
                MessageBox.Show("Folder already exists");
            }
            else
            {
                df.Create();
                MessageBox.Show("Created");
            }
        }
        // System.IO
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\TestDemo\TestFile.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                fi.Create();
                MessageBox.Show("Created");
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 create a file & open in write mode FileStream
         FileStream fs = new FileStream(@"D:\TestDemo\Dept.txt", FileMode.Create, FileAccess.Write);
                //2 write to file  - BinaryWriter object
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(txtLocation.Text);
                //3 close the BinaryWriter & FileStream
                bw.Close();
                fs.Close();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
          FileStream fs = new FileStream(@"D:\TestDemo\Dept.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
               txtId.Text= br.ReadInt32().ToString(); // DeptId
               txtName.Text= br.ReadString(); //name
               txtLocation.Text= br.ReadString();//loc
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
