using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptbinaryFile.dat", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
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
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptbinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptsoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                dept = (Department)sf.Deserialize(fs);
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
