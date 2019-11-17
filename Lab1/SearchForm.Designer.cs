namespace Lab1
{
    partial class SearchForm
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
            this.Search_button = new System.Windows.Forms.Button();
            this.Timetable_comboBox = new System.Windows.Forms.ComboBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.SearchResult_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(409, 10);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Timetable_comboBox
            // 
            this.Timetable_comboBox.FormattingEnabled = true;
            this.Timetable_comboBox.Location = new System.Drawing.Point(12, 12);
            this.Timetable_comboBox.Name = "Timetable_comboBox";
            this.Timetable_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Timetable_comboBox.TabIndex = 1;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(149, 13);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(245, 20);
            this.Search_textBox.TabIndex = 2;
            // 
            // SearchResult_dataGridView
            // 
            this.SearchResult_dataGridView.AllowUserToAddRows = false;
            this.SearchResult_dataGridView.AllowUserToDeleteRows = false;
            this.SearchResult_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResult_dataGridView.Location = new System.Drawing.Point(12, 46);
            this.SearchResult_dataGridView.Name = "SearchResult_dataGridView";
            this.SearchResult_dataGridView.ReadOnly = true;
            this.SearchResult_dataGridView.Size = new System.Drawing.Size(475, 319);
            this.SearchResult_dataGridView.TabIndex = 3;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 377);
            this.Controls.Add(this.SearchResult_dataGridView);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Timetable_comboBox);
            this.Controls.Add(this.Search_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Searching";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ComboBox Timetable_comboBox;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.DataGridView SearchResult_dataGridView;
    }
}