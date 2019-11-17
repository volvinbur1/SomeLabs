namespace Lab1
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
            this.AirplaneTimetable_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneTimetable_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AirplaneTimetable_dataGridView
            // 
            this.AirplaneTimetable_dataGridView.AllowUserToAddRows = false;
            this.AirplaneTimetable_dataGridView.AllowUserToDeleteRows = false;
            this.AirplaneTimetable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AirplaneTimetable_dataGridView.Location = new System.Drawing.Point(12, 44);
            this.AirplaneTimetable_dataGridView.Name = "AirplaneTimetable_dataGridView";
            this.AirplaneTimetable_dataGridView.ReadOnly = true;
            this.AirplaneTimetable_dataGridView.Size = new System.Drawing.Size(467, 265);
            this.AirplaneTimetable_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airplane Timetable";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AirplaneTimetable_dataGridView);
            this.Name = "MainForm";
            this.Text = "Timetable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneTimetable_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AirplaneTimetable_dataGridView;
        private System.Windows.Forms.Label label1;
    }
}