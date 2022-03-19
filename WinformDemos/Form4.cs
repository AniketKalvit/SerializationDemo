using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;
namespace WinformDemos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
             FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Open, FileAccess.Read);
              dept= JsonSerializer.Deserialize<Department>(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
