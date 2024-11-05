using ChatBotManager.Models;
using ChatBotManager.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ChatBotManager
{
    public partial class MainForm : Form
    {
        private readonly ApiService apiService;

        public MainForm()
        {
            InitializeComponent();
            apiService = new ApiService();

        }

        private async Task LoadIntents()
        {
            var intents = await apiService.GetIntentsAsync();
            dataGridViewIntents.DataSource = intents;
        }

        private async Task dataGridViewIntents_SelectionChangedAsync(object sender, EventArgs e)
        {
            if (dataGridViewIntents.SelectedRows.Count > 0)
            {
                var selectedIntent = (Intent)dataGridViewIntents.SelectedRows[0].DataBoundItem;
                await LoadResponsesForIntent(selectedIntent.IntentID);
            }
        }

        private async Task LoadResponsesForIntent(int intentId)
        {
            try
            {
                List<Response> responses = await apiService.GetResponsesByIntentAsync(intentId.ToString());
                dataGridViewResponses.DataSource = responses;
                dataGridViewResponses.Columns["ResponseText"].HeaderText = "Nội dung phản hồi"; // Đặt tiêu đề cho cột ResponseText
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefreshIntents_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                List<Intent> intents = await apiService.GetIntentsAsync();
                // Xóa dữ liệu hiện tại trong DataGridView
                dataGridViewIntents.DataSource = null;
                dataGridViewIntents.Rows.Clear();
                // Đặt DataSource cho DataGridView
                dataGridViewIntents.DataSource = intents;
                // Thiết lập tên cột hiển thị (nếu cần)
                dataGridViewIntents.Columns["IntentName"].HeaderText = "Tên Intent"; // Đặt tiêu đề cho cột IntentName
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dataGridViewIntents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được nhấn là cột nút
            if (e.ColumnIndex == dataGridViewIntents.Columns["viewResponsesButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Lấy IntentID của dòng được chọn
                var selectedIntent = (Intent)dataGridViewIntents.Rows[e.RowIndex].DataBoundItem;

                // Gọi phương thức để tải danh sách Responses cho Intent được chọn
                await LoadResponsesForIntent(selectedIntent.IntentID);
            }
        }

        private async void btnAddIntent_Click(object sender, EventArgs e)
        {
            using (var addIntentForm = new AddIntentForm())
            {
                if (addIntentForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên Intent mới từ form vừa đóng
                    string intentName = addIntentForm.IntentName;

                    // Gọi API để thêm Intent mới
                    var success = await apiService.AddIntentAsync(intentName);

                    if (success)
                    {
                        MessageBox.Show("Thêm Intent thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //await LoadIntentsAsync(); // Tải lại danh sách intents
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm Intent.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
