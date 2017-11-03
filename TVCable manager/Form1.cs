
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVCable_manager
{
    public partial class mainForm : Form
    {
        private edit editForm;

        private List<ServiceReference.tvOffer> list = new List<ServiceReference.tvOffer>();
        public ServiceReference.CTVBackendPortClient service = new ServiceReference.CTVBackendPortClient();

        async private void reload()
        {
            reloadButton.Enabled = false;
            loadingLabel.Visible = true;

            try
            {
                
                //list.AddRange(service.getOffers());               

                list.AddRange(await service.getOffersAsync());

                dataGridView1.DataSource = list;
                dataGridView1.Update();
                dataGridView1.ClearSelection();
                reloadButton.Enabled = true;
                loadingLabel.Visible = false;

                ;

                
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd połączenia z serwerem " + e.Message);
                reloadButton.Enabled = true;
                loadingLabel.Visible = false;
            }


        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {

            reloadGridView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            reloadGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference.tvOffer selectedOffer = list.ElementAt(index: dataGridView1.SelectedRows[0].Index);

                editForm = new edit();
                editForm.selectedOffer = selectedOffer;
                editForm.editMode = true;
                editForm.parentForm = this;
                editForm.Show();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            editForm = new edit();
            editForm.parentForm = this;
            editForm.Show();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            editForm.Close();
        }

        public void reloadGridView()
        {
            list.Clear();
            dataGridView1.DataSource = typeof(List<ServiceReference.tvOffer>);
            dataGridView1.Update();
            reload();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Czy jesteś pewien ??",
                                     "Potwierdż usuwanie!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        ServiceReference.tvOffer selectedOffer = list.ElementAt(index: dataGridView1.SelectedRows[0].Index);
                        bool result = service.removeOffer((int)selectedOffer.id);
                        dataGridView1.SelectedRows.Clear();
                        reloadGridView();
                    }
                    catch
                    {
                        MessageBox.Show("Błąd usuwania");
                    }

                }
                else
                {

                }
            }
        }
    }

}
