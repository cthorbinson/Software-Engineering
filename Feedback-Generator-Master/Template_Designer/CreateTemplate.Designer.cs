namespace Template_Designer
{
    partial class CreateTemplate
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTemplateName = new System.Windows.Forms.TextBox();
            this.textBoxTemplateReviewer = new System.Windows.Forms.TextBox();
            this.textBoxTemplatePosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectFeedbackTypeBox = new System.Windows.Forms.ComboBox();
            this.createTemplateFeedbackTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackGeneratorDBDataSet = new Template_Designer.feedbackGeneratorDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createTemplateFeedbackTypeTableAdapter = new Template_Designer.feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter();
            this.createTemplateFeedbackTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reviewer:";
            // 
            // textBoxTemplateName
            // 
            this.textBoxTemplateName.Location = new System.Drawing.Point(105, 13);
            this.textBoxTemplateName.Name = "textBoxTemplateName";
            this.textBoxTemplateName.Size = new System.Drawing.Size(219, 20);
            this.textBoxTemplateName.TabIndex = 2;
            this.textBoxTemplateName.TextChanged += new System.EventHandler(this.templateName_TextChanged);
            // 
            // textBoxTemplateReviewer
            // 
            this.textBoxTemplateReviewer.Location = new System.Drawing.Point(105, 40);
            this.textBoxTemplateReviewer.Name = "textBoxTemplateReviewer";
            this.textBoxTemplateReviewer.Size = new System.Drawing.Size(219, 20);
            this.textBoxTemplateReviewer.TabIndex = 3;
            this.textBoxTemplateReviewer.TextChanged += new System.EventHandler(this.reviewerName_TextChanged);
            // 
            // textBoxTemplatePosition
            // 
            this.textBoxTemplatePosition.Location = new System.Drawing.Point(105, 66);
            this.textBoxTemplatePosition.Name = "textBoxTemplatePosition";
            this.textBoxTemplatePosition.Size = new System.Drawing.Size(219, 20);
            this.textBoxTemplatePosition.TabIndex = 4;
            this.textBoxTemplatePosition.TextChanged += new System.EventHandler(this.positionName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position:";
            // 
            // comboBoxSelectFeedbackTypeBox
            // 
            this.comboBoxSelectFeedbackTypeBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.createTemplateFeedbackTypeBindingSource, "feedbackType", true));
            this.comboBoxSelectFeedbackTypeBox.DataSource = this.createTemplateFeedbackTypeBindingSource;
            this.comboBoxSelectFeedbackTypeBox.DisplayMember = "feedbackType";
            this.comboBoxSelectFeedbackTypeBox.FormattingEnabled = true;
            this.comboBoxSelectFeedbackTypeBox.Location = new System.Drawing.Point(105, 93);
            this.comboBoxSelectFeedbackTypeBox.Name = "comboBoxSelectFeedbackTypeBox";
            this.comboBoxSelectFeedbackTypeBox.Size = new System.Drawing.Size(219, 21);
            this.comboBoxSelectFeedbackTypeBox.TabIndex = 6;
            this.comboBoxSelectFeedbackTypeBox.ValueMember = "feedbackType";
            this.comboBoxSelectFeedbackTypeBox.SelectedIndexChanged += new System.EventHandler(this.selectFeedbackTypeBox_SelectedIndexChanged);
            // 
            // createTemplateFeedbackTypeBindingSource
            // 
            this.createTemplateFeedbackTypeBindingSource.DataMember = "createTemplateFeedbackType";
            this.createTemplateFeedbackTypeBindingSource.DataSource = this.feedbackGeneratorDBDataSet;
            // 
            // feedbackGeneratorDBDataSet
            // 
            this.feedbackGeneratorDBDataSet.DataSetName = "feedbackGeneratorDBDataSet";
            this.feedbackGeneratorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Feedback Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // createTemplateFeedbackTypeTableAdapter
            // 
            this.createTemplateFeedbackTypeTableAdapter.ClearBeforeFill = true;
            // 
            // createTemplateFeedbackTypeBindingSource1
            // 
            this.createTemplateFeedbackTypeBindingSource1.DataMember = "createTemplateFeedbackType";
            this.createTemplateFeedbackTypeBindingSource1.DataSource = this.feedbackGeneratorDBDataSet;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 197);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelectFeedbackTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTemplatePosition);
            this.Controls.Add(this.textBoxTemplateReviewer);
            this.Controls.Add(this.textBoxTemplateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTemplateName;
        private System.Windows.Forms.TextBox textBoxTemplateReviewer;
        private System.Windows.Forms.TextBox textBoxTemplatePosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectFeedbackTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private feedbackGeneratorDBDataSet feedbackGeneratorDBDataSet;
        private System.Windows.Forms.BindingSource createTemplateFeedbackTypeBindingSource;
        private feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter createTemplateFeedbackTypeTableAdapter;
        private System.Windows.Forms.BindingSource createTemplateFeedbackTypeBindingSource1;
    }
}