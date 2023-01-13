using System;
using System.Data;
using System.Windows.Forms;

namespace DENTAL_SYSTEM_PROTOTYPE
{
    public partial class FrmTreatment : Form
    {
        public FrmTreatment()
        {
            InitializeComponent();
        }

        private void btnTtSave_Click(object sender, EventArgs e)
        {
            {
                string query = "insert into TreatTable Values" +
                "('" + txbTtName.Text + "','" + txtTtCost.Text + "','" + txbTtDiscrip.Text +"')";

                MYPatient patient = new MYPatient();
                try
                {
                    patient.AddPatient(query);
                    MessageBox.Show("Treatment Successfully Added");
                    populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        void populate()
        {
            MYPatient pat = new MYPatient();
            string query = "select * from TreatTable";
            DataSet dataSet = pat.ShowPatient(query);
            TreatmentDGV.DataSource = dataSet.Tables[0];

        }

        private void FrmTreatment_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void btnTtUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTtDelete_Click(object sender, EventArgs e)
        {

           
        }

      

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
    }

