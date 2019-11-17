namespace Lab1
{
    partial class MainFormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.AirplaneTimetable_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RaceNumber_textBox = new System.Windows.Forms.TextBox();
            this.AirplaneType_textBox = new System.Windows.Forms.TextBox();
            this.TravelDirection_textBox = new System.Windows.Forms.TextBox();
            this.DepaturePeriod_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.Edit_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneTimetable_dataGridView)).BeginInit();
            this.Edit_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirplaneTimetable_dataGridView
            // 
            this.AirplaneTimetable_dataGridView.AllowUserToAddRows = false;
            this.AirplaneTimetable_dataGridView.AllowUserToDeleteRows = false;
            this.AirplaneTimetable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AirplaneTimetable_dataGridView.Location = new System.Drawing.Point(216, 47);
            this.AirplaneTimetable_dataGridView.Name = "AirplaneTimetable_dataGridView";
            this.AirplaneTimetable_dataGridView.ReadOnly = true;
            this.AirplaneTimetable_dataGridView.Size = new System.Drawing.Size(513, 265);
            this.AirplaneTimetable_dataGridView.TabIndex = 0;
            this.AirplaneTimetable_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirplaneTimetable_dataGridView_CellClick);
            this.AirplaneTimetable_dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AirplaneTimetable_dataGridView_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airplane Timetable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Race Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Airplane type";
            // 
            // RaceNumber_textBox
            // 
            this.RaceNumber_textBox.Location = new System.Drawing.Point(91, 47);
            this.RaceNumber_textBox.Name = "RaceNumber_textBox";
            this.RaceNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.RaceNumber_textBox.TabIndex = 4;
            // 
            // AirplaneType_textBox
            // 
            this.AirplaneType_textBox.Location = new System.Drawing.Point(91, 82);
            this.AirplaneType_textBox.Name = "AirplaneType_textBox";
            this.AirplaneType_textBox.Size = new System.Drawing.Size(100, 20);
            this.AirplaneType_textBox.TabIndex = 5;
            // 
            // TravelDirection_textBox
            // 
            this.TravelDirection_textBox.Location = new System.Drawing.Point(91, 118);
            this.TravelDirection_textBox.Name = "TravelDirection_textBox";
            this.TravelDirection_textBox.Size = new System.Drawing.Size(100, 20);
            this.TravelDirection_textBox.TabIndex = 6;
            // 
            // DepaturePeriod_textBox
            // 
            this.DepaturePeriod_textBox.Location = new System.Drawing.Point(91, 151);
            this.DepaturePeriod_textBox.Name = "DepaturePeriod_textBox";
            this.DepaturePeriod_textBox.Size = new System.Drawing.Size(100, 20);
            this.DepaturePeriod_textBox.TabIndex = 7;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(99, 187);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 8;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Travel direction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Depature period";
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(10, 289);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 11;
            this.Back_button.Text = "Go back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Edit_contextMenuStrip
            // 
            this.Edit_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.Edit_contextMenuStrip.Name = "Edit_contextMenuStrip";
            this.Edit_contextMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(116, 289);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 12;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 321);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.DepaturePeriod_textBox);
            this.Controls.Add(this.TravelDirection_textBox);
            this.Controls.Add(this.AirplaneType_textBox);
            this.Controls.Add(this.RaceNumber_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AirplaneTimetable_dataGridView);
            this.Name = "MainFormAdmin";
            this.Text = "Timetable (admin)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AirplaneTimetable_dataGridView)).EndInit();
            this.Edit_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AirplaneTimetable_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RaceNumber_textBox;
        private System.Windows.Forms.TextBox AirplaneType_textBox;
        private System.Windows.Forms.TextBox TravelDirection_textBox;
        private System.Windows.Forms.TextBox DepaturePeriod_textBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ContextMenuStrip Edit_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button Search_button;
    }
}