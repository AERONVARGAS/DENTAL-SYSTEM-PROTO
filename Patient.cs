using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DENTAL_SYSTEM_PROTOTYPE
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string query = "insert into PatientTable Values" +
                "('" + txbPatientName.Text + "','" + txbPhoneNum.Text + "','" + txbPatientAddresss.Text + "','"
                 + dateTimePickerPatient.Value.Date + "','"+ cmbPgender.SelectedItem.ToString() + "','" + txbAllergies.Text + "')";

            MYPatient patient= new MYPatient();
            try
            {
                patient.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
                populate();
            }

           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void populate() 
        {
            MYPatient pat = new MYPatient();
            string query = "select * from PatientTable";
            DataSet dataSet = pat.ShowPatient(query);
            guna2DataGridViewPatient.DataSource = dataSet.Tables[0];
        }
        private void FrmPatient_Load(object sender, EventArgs e)
        {
            cmbPgender.Items.Add("Male");
            cmbPgender.Items.Add("Female");

            populate();
        }
        int key = 0;
        private void guna2DataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPatientName.Text = guna2DataGridViewPatient.SelectedRows[0].Cells[1].Value.ToString();
            txbPhoneNum.Text = guna2DataGridViewPatient.SelectedRows[0].Cells[2].Value.ToString();
            txbPatientAddresss.Text = guna2DataGridViewPatient.SelectedRows[0].Cells[3].Value.ToString();
            cmbPgender.Text = guna2DataGridViewPatient.SelectedRows[0].Cells[5].Value.ToString();
            txbAllergies.Text = guna2DataGridViewPatient.SelectedRows[0].Cells[6].Value.ToString();

            if (txbPatientName.Text == "")
            {
                key = 0;
            }
            else 
            {
                key = Convert.ToInt32(guna2DataGridViewPatient.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MYPatient pat = new MYPatient();
            if(key == 0) 
            {
                MessageBox.Show("Selected the Patient");

            }
            else
            {
                try 
                {
                    string query = "Delete from PatientTable where PatId=" + key + "";
                    pat.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Deleted");
                    populate();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MYPatient pat = new MYPatient();
            if (key == 0)
            {
                MessageBox.Show("Selected the Patient");

            }
            else
            {
                try
                {
                    string query = "Update PatientTable set PatName='" + txbPatientName.Text + "',PatPhonenumber='" + txbPhoneNum.Text + "',PatAddress='" + txbPatientAddresss.Text + "',PatDOB='"
                        + dateTimePickerPatient.Value.Date + "',PatGender='" + cmbPgender.SelectedItem.ToString() + "',PatAllergies='" + txbAllergies.Text + "'where PatId=" + key + "";
                    pat.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Updated");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
