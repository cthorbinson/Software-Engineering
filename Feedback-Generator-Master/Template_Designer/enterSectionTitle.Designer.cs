namespace Template_Designer
{
    partial class enterSectionTitle
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
            this.label1 = new System.Windows.Forms.Label();
            this.sectionTitleTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmSectionTitleButton = new System.Windows.Forms.Button();
            this.CancelSectionTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new section title:";
            // 
            // sectionTitleTextbox
            // 
            this.sectionTitleTextbox.Location = new System.Drawing.Point(12, 53);
            this.sectionTitleTextbox.Name = "sectionTitleTextbox";
            this.sectionTitleTextbox.Size = new System.Drawing.Size(334, 20);
            this.sectionTitleTextbox.TabIndex = 1;
            this.sectionTitleTextbox.TextChanged += new System.EventHandler(this.sectionTitleTextbox_TextChanged);
            // 
            // ConfirmSectionTitleButton
            // 
            this.ConfirmSectionTitleButton.Location = new System.Drawing.Point(271, 167);
            this.ConfirmSectionTitleButton.Name = "ConfirmSectionTitleButton";
            this.ConfirmSectionTitleButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmSectionTitleButton.TabIndex = 2;
            this.ConfirmSectionTitleButton.Text = "Confirm";
            this.ConfirmSectionTitleButton.UseVisualStyleBackColor = true;
            this.ConfirmSectionTitleButton.Click += new System.EventHandler(this.ConfirmSectionTitleButton_Click);
            // 
            // CancelSectionTitleButton
            // 
            this.CancelSectionTitleButton.Location = new System.Drawing.Point(13, 167);
            this.CancelSectionTitleButton.Name = "CancelSectionTitleButton";
            this.CancelSectionTitleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSectionTitleButton.TabIndex = 3;
            this.CancelSectionTitleButton.Text = "Cancel";
            this.CancelSectionTitleButton.UseVisualStyleBackColor = true;
            this.CancelSectionTitleButton.Click += new System.EventHandler(this.CancelSectionTitleButton_Click);
            // 
            // enterSectionTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 202);
            this.Controls.Add(this.CancelSectionTitleButton);
            this.Controls.Add(this.ConfirmSectionTitleButton);
            this.Controls.Add(this.sectionTitleTextbox);
            this.Controls.Add(this.label1);
            this.Name = "enterSectionTitle";
            this.Text = "enterSectionTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sectionTitleTextbox;
        private System.Windows.Forms.Button ConfirmSectionTitleButton;
        private System.Windows.Forms.Button CancelSectionTitleButton;
    }
}