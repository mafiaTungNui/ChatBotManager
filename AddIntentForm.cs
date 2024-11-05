using ChatBotManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotManager
{
    public partial class AddIntentForm : Form
    {
        private readonly ApiService apiService;

        public AddIntentForm()
        {
            InitializeComponent(); 
            apiService = new ApiService();

        }

        public string IntentName { get; internal set; }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            lblStatus.Text = ""; // Xóa trạng thái cũ
            string intentName = txtIntentName.Text.Trim();

            if (string.IsNullOrEmpty(intentName))
            {
                lblStatus.Text = "Intent name is required!";
                return;
            }

            try
            {
                bool isSuccess = await apiService.AddIntentAsync(intentName);
                if (isSuccess)
                {
                    lblStatus.Text = "Intent added successfully!";
                    txtIntentName.Clear(); // Xóa TextBox sau khi thêm thành công
                }
                else
                {
                    lblStatus.Text = "Failed to add intent.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }
    }
}
