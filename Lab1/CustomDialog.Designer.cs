namespace Lab1
{
    partial class CustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog));
            this.Change_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreValue_textBox = new System.Windows.Forms.TextBox();
            this.NewValue_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Change_button
            // 
            this.Change_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.Change_button, "Change_button");
            this.Change_button.Name = "Change_button";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // PreValue_textBox
            // 
            resources.ApplyResources(this.PreValue_textBox, "PreValue_textBox");
            this.PreValue_textBox.Name = "PreValue_textBox";
            // 
            // NewValue_textBox
            // 
            resources.ApplyResources(this.NewValue_textBox, "NewValue_textBox");
            this.NewValue_textBox.Name = "NewValue_textBox";
            // 
            // CustomDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewValue_textBox);
            this.Controls.Add(this.PreValue_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialog";
            this.Load += new System.EventHandler(this.CustomDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreValue_textBox;
        private System.Windows.Forms.TextBox NewValue_textBox;
    }
}