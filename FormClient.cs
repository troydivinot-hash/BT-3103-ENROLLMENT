using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Data;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{

    public partial class FormClient : Form
    {
        private DateTime legalAge = DateTime.Parse($"01/01/{DateTime.Now.Year - 18}");
        private bool isAdd = true;
        private List<AccountModel> accountList = new List<AccountModel>();
        private ClientAccountController clientAccountController;
        public FormClient()
        {
            InitializeComponent();
            clientAccountController = new ClientAccountController();
        }
        private void LoadData()
        {
            accountList = clientAccountController.GetAll();
            var clientList = accountList.Select(a => a.ClientModel).ToList();
            dgridView.DataSource = null;
            dgridView.DataSource = clientList;
            ExpandColumns(dgridView, true);
        }

        public void ExpandColumns(DataGridView source, bool sizable = true)
        {
            foreach (DataGridViewColumn col in source.Columns)
            {
                if (col.ValueType.Name != "ICollection`1")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            if (!sizable) return;

            for (int index = 0; index <= source.Columns.Count - 1; index++)
            {
                int columnWidth = source.Columns[index].Width;

                source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                source.Columns[index].Width = columnWidth;
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableControls(true);
            ClearFields();
            isAdd = true;
        }

        private void enableControls(bool enabled)
        {
            btnAdd.Enabled = btnDel.Enabled = btnUpdate.Enabled = btnRefresh.Enabled = !enabled;
            btnSave.Enabled = btnCancel.Enabled = enabled;
            foreach (var control in this.grpClient.Controls)
            {
                var textBox = control as TextBox;
                if (textBox != null) textBox.ReadOnly = !enabled;

                var maskTextBox = control as MaskedTextBox;
                if (maskTextBox != null) maskTextBox.ReadOnly = !enabled;

                var comboBox = control as ComboBox;
                if (comboBox != null) comboBox.Enabled = enabled;

                var datePicker = control as DateTimePicker;
                if (datePicker != null) datePicker.Enabled = enabled;
            }

            foreach (var control in this.grpAccount.Controls)
            {
                var textBox = control as TextBox;
                if (textBox != null) textBox.ReadOnly = !enabled;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enableControls(true);
            isAdd = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int selectedRowIndex = dgridView.SelectedCells[0].RowIndex;
                var selectedClient = accountList[selectedRowIndex];
                clientAccountController.Delete(selectedClient.ClientModel.Id);
                LoadData();
            }

        }

        private void dgridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            getSelectedItem(selectedRowIndex);
        }

        private void getSelectedItem(int selectedRowIndex)
        {
            if (selectedRowIndex >= 0)
            {
                var selectedAccount = accountList[selectedRowIndex];

                var selectedClient = selectedAccount.ClientModel;
                txtFirstname.Text = selectedClient.Firstname;
                txtLastname.Text = selectedClient.Lastname;
                txtMobileNumber.Text = selectedClient.MobileNumber;
                txtGender.Text = selectedClient.Gender;
                txtAddress.Text = selectedClient.Address;
                dtpBirthdate.Value = selectedClient.Birthdate;
                lblAccountId.Text = $"Account Id: {selectedAccount.Id.ToString()}";
                txtBalance.Text = String.Format("{0:C}", selectedAccount.Balance);
                lblModified.Text = $"Modified Date: {selectedAccount.ModifiedDate.ToString()}";
            }
        }
        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMobileNumber.Clear();
            txtGender.Text = "";
            txtAddress.Clear();
            dtpBirthdate.Value = legalAge;
            txtBalance.Text = "0.00";
            lblModified.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initialState();
        }

        private void initialState()
        {

            LoadData();
            enableControls(false);
            if (dgridView.Rows != null && dgridView.Rows.Count != 0)
            {
                dgridView.Rows[0].Selected = true;
                getSelectedItem(0);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int yPos = 10;
            Font font = new Font("Arial", 10);

            string header = "Firstname | Lastname | Mobile Number | Gender | Address | Birthdate";
            e.Graphics.DrawString(header, font, Brushes.Black, 10, yPos);
            yPos += 20;


            foreach (AccountModel account in accountList)
            {
                var client = account.ClientModel;
                string line = $"{client.Firstname,-20} {client.Lastname,-20} {client.MobileNumber,-20} {client.Gender,-10} {client.Address,-30} {Convert.ToDateTime(client.Birthdate).ToShortDateString()}";
                e.Graphics.DrawString(line, font, Brushes.Black, 10, yPos);
                yPos += 20; // Move to next line
            }

            if (yPos > e.MarginBounds.Bottom)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize('Client List')
            printPreviewDialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (isAdd)
                {
                    var client = new ClientModel
                    {
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        MobileNumber = txtMobileNumber.Text,
                        Gender = txtGender.Text,
                        Address = txtAddress.Text,
                        Birthdate = dtpBirthdate.Value
                    };
                    var account = new AccountModel
                    {
                        Balance = decimal.Parse(txtBalance.Text.Replace("₱", "").Replace(",", "")),
                        ClientModel = client
                    };

                    clientAccountController.Add(account);

                }
                else
                {
                    int selectedRowIndex = dgridView.SelectedCells[0].RowIndex;
                    var selectedClient = accountList[selectedRowIndex];

                    var client = new ClientModel
                    {
                        Id = selectedClient.ClientModel.Id,
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        MobileNumber = txtMobileNumber.Text,
                        Gender = txtGender.Text,
                        Address = txtAddress.Text,
                        Birthdate = dtpBirthdate.Value
                    };
                    var account = new AccountModel
                    {
                        Id = selectedClient.Id,
                        Balance = decimal.Parse(txtBalance.Text.Replace("₱", "").Replace(",", "")),
                        ClientModel = client
                    };

                    clientAccountController.Update(account);

                }
                initialState();
                MessageBox.Show("Save Successfully","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            initialState();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

            initialState();
            dtpBirthdate.MaxDate = legalAge;
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = allowNumberTextbox(sender, e.KeyChar);
        }

        private bool allowNumberTextbox(object sender, char keyKhar)
        {
            if (!char.IsControl(keyKhar) && !char.IsDigit(keyKhar) && (keyKhar != '.')) return true;

            if ((keyKhar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) return true;

            return false;
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = allowNumberTextbox(sender, e.KeyChar);
        }
    }
}
