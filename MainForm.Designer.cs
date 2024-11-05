namespace ChatBotManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewIntents = new System.Windows.Forms.DataGridView();
            this.dataGridViewResponses = new System.Windows.Forms.DataGridView();
            this.btnRefreshIntents = new System.Windows.Forms.Button();
            this.viewResponsesButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddIntent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIntents
            // 
            this.dataGridViewIntents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewResponsesButtonColumn});
            this.dataGridViewIntents.Location = new System.Drawing.Point(13, 64);
            this.dataGridViewIntents.Name = "dataGridViewIntents";
            this.dataGridViewIntents.RowHeadersWidth = 51;
            this.dataGridViewIntents.RowTemplate.Height = 27;
            this.dataGridViewIntents.Size = new System.Drawing.Size(600, 352);
            this.dataGridViewIntents.TabIndex = 0;
            this.dataGridViewIntents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIntents_CellClick);
            // 
            // dataGridViewResponses
            // 
            this.dataGridViewResponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResponses.Location = new System.Drawing.Point(619, 64);
            this.dataGridViewResponses.Name = "dataGridViewResponses";
            this.dataGridViewResponses.RowHeadersWidth = 51;
            this.dataGridViewResponses.RowTemplate.Height = 27;
            this.dataGridViewResponses.Size = new System.Drawing.Size(767, 352);
            this.dataGridViewResponses.TabIndex = 1;
            // 
            // btnRefreshIntents
            // 
            this.btnRefreshIntents.Location = new System.Drawing.Point(1310, 23);
            this.btnRefreshIntents.Name = "btnRefreshIntents";
            this.btnRefreshIntents.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshIntents.TabIndex = 2;
            this.btnRefreshIntents.Text = "Reset";
            this.btnRefreshIntents.UseVisualStyleBackColor = true;
            this.btnRefreshIntents.Click += new System.EventHandler(this.btnRefreshIntents_ClickAsync);
            // 
            // viewResponsesButtonColumn
            // 
            this.viewResponsesButtonColumn.HeaderText = "View";
            this.viewResponsesButtonColumn.MinimumWidth = 6;
            this.viewResponsesButtonColumn.Name = "viewResponsesButtonColumn";
            this.viewResponsesButtonColumn.UseColumnTextForButtonValue = true;
            this.viewResponsesButtonColumn.Width = 125;
            // 
            // btnAddIntent
            // 
            this.btnAddIntent.Location = new System.Drawing.Point(13, 35);
            this.btnAddIntent.Name = "btnAddIntent";
            this.btnAddIntent.Size = new System.Drawing.Size(75, 23);
            this.btnAddIntent.TabIndex = 3;
            this.btnAddIntent.Text = "Add";
            this.btnAddIntent.UseVisualStyleBackColor = true;
            this.btnAddIntent.Click += new System.EventHandler(this.btnAddIntent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 450);
            this.Controls.Add(this.btnAddIntent);
            this.Controls.Add(this.btnRefreshIntents);
            this.Controls.Add(this.dataGridViewResponses);
            this.Controls.Add(this.dataGridViewIntents);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIntents;
        private System.Windows.Forms.DataGridView dataGridViewResponses;
        private System.Windows.Forms.Button btnRefreshIntents;
        private System.Windows.Forms.DataGridViewButtonColumn viewResponsesButtonColumn;
        private System.Windows.Forms.Button btnAddIntent;
    }
}