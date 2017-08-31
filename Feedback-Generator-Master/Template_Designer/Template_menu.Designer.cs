namespace Template_Designer
{
    partial class TemplateSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.createTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templateNameDataSet = new Template_Designer.templateNameDataSet();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.createNewTemplate_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.createTemplateTableAdapter = new Template_Designer.templateNameDataSetTableAdapters.createTemplateTableAdapter();
            this.templateNameDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateNameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateNameDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create/Modify templates";
            // 
            // createTemplateBindingSource
            // 
            this.createTemplateBindingSource.DataMember = "createTemplate";
            this.createTemplateBindingSource.DataSource = this.templateNameDataSet;
            // 
            // templateNameDataSet
            // 
            this.templateNameDataSet.DataSetName = "templateNameDataSet";
            this.templateNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(21, 76);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 2;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(158, 76);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // createNewTemplate_button
            // 
            this.createNewTemplate_button.Location = new System.Drawing.Point(262, 153);
            this.createNewTemplate_button.Name = "createNewTemplate_button";
            this.createNewTemplate_button.Size = new System.Drawing.Size(75, 23);
            this.createNewTemplate_button.TabIndex = 4;
            this.createNewTemplate_button.Text = "Create new";
            this.createNewTemplate_button.UseVisualStyleBackColor = true;
            this.createNewTemplate_button.Click += new System.EventHandler(this.createNewTemplate_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(21, 149);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // createTemplateTableAdapter
            // 
            this.createTemplateTableAdapter.ClearBeforeFill = true;
            // 
            // templateNameDataSetBindingSource
            // 
            this.templateNameDataSetBindingSource.DataSource = this.templateNameDataSet;
            this.templateNameDataSetBindingSource.Position = 0;
            // 
            // cbCl
            // 
            this.cbCl.FormattingEnabled = true;
            this.cbCl.Location = new System.Drawing.Point(13, 49);
            this.cbCl.Name = "cbCl";
            this.cbCl.Size = new System.Drawing.Size(277, 21);
            this.cbCl.TabIndex = 6;
            // 
            // TemplateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 188);
            this.Controls.Add(this.cbCl);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.createNewTemplate_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.label1);
            this.Name = "TemplateSelector";
            this.Load += new System.EventHandler(this.TemplateSelector_Load);
            this.Click += new System.EventHandler(this.TemplateSelector_GotFocus);
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateNameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateNameDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button createNewTemplate_button;
        private System.Windows.Forms.Button back_button;
        private templateNameDataSet templateNameDataSet;
        public System.Windows.Forms.BindingSource createTemplateBindingSource;
        private templateNameDataSetTableAdapters.createTemplateTableAdapter createTemplateTableAdapter;
        private System.Windows.Forms.BindingSource templateNameDataSetBindingSource;
        public System.Windows.Forms.ComboBox cbCl;
    }
}

