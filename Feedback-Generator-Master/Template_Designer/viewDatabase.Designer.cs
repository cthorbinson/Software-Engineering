namespace Template_Designer
{
    partial class viewDatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.templateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateReviewerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templatePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackGeneratorDBDataSet1 = new Template_Designer.feedbackGeneratorDBDataSet1();
            this.feedbackGeneratorDBDataSet = new Template_Designer.feedbackGeneratorDBDataSet();
            this.createTemplateFeedbackTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createTemplateFeedbackTypeTableAdapter = new Template_Designer.feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter();
            this.createTemplateTableAdapter = new Template_Designer.feedbackGeneratorDBDataSet1TableAdapters.createTemplateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.templateIDDataGridViewTextBoxColumn,
            this.templateNameDataGridViewTextBoxColumn,
            this.templateReviewerDataGridViewTextBoxColumn,
            this.templatePositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.createTemplateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1__Load);
            // 
            // templateIDDataGridViewTextBoxColumn
            // 
            this.templateIDDataGridViewTextBoxColumn.DataPropertyName = "templateID";
            this.templateIDDataGridViewTextBoxColumn.HeaderText = "templateID";
            this.templateIDDataGridViewTextBoxColumn.Name = "templateIDDataGridViewTextBoxColumn";
            this.templateIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // templateNameDataGridViewTextBoxColumn
            // 
            this.templateNameDataGridViewTextBoxColumn.DataPropertyName = "templateName";
            this.templateNameDataGridViewTextBoxColumn.HeaderText = "templateName";
            this.templateNameDataGridViewTextBoxColumn.Name = "templateNameDataGridViewTextBoxColumn";
            // 
            // templateReviewerDataGridViewTextBoxColumn
            // 
            this.templateReviewerDataGridViewTextBoxColumn.DataPropertyName = "templateReviewer";
            this.templateReviewerDataGridViewTextBoxColumn.HeaderText = "templateReviewer";
            this.templateReviewerDataGridViewTextBoxColumn.Name = "templateReviewerDataGridViewTextBoxColumn";
            // 
            // templatePositionDataGridViewTextBoxColumn
            // 
            this.templatePositionDataGridViewTextBoxColumn.DataPropertyName = "templatePosition";
            this.templatePositionDataGridViewTextBoxColumn.HeaderText = "templatePosition";
            this.templatePositionDataGridViewTextBoxColumn.Name = "templatePositionDataGridViewTextBoxColumn";
            // 
            // createTemplateBindingSource
            // 
            this.createTemplateBindingSource.DataMember = "createTemplate";
            this.createTemplateBindingSource.DataSource = this.feedbackGeneratorDBDataSet1;
            // 
            // feedbackGeneratorDBDataSet1
            // 
            this.feedbackGeneratorDBDataSet1.DataSetName = "feedbackGeneratorDBDataSet1";
            this.feedbackGeneratorDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackGeneratorDBDataSet
            // 
            this.feedbackGeneratorDBDataSet.DataSetName = "feedbackGeneratorDBDataSet";
            this.feedbackGeneratorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createTemplateFeedbackTypeBindingSource
            // 
            this.createTemplateFeedbackTypeBindingSource.DataMember = "createTemplateFeedbackType";
            this.createTemplateFeedbackTypeBindingSource.DataSource = this.feedbackGeneratorDBDataSet;
            // 
            // createTemplateFeedbackTypeTableAdapter
            // 
            this.createTemplateFeedbackTypeTableAdapter.ClearBeforeFill = true;
            // 
            // createTemplateTableAdapter
            // 
            this.createTemplateTableAdapter.ClearBeforeFill = true;
            // 
            // viewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewDatabase";
            this.Text = "viewDatabase";
            this.Load += new System.EventHandler(this.viewDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackGeneratorDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTemplateFeedbackTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private feedbackGeneratorDBDataSet feedbackGeneratorDBDataSet;
        private System.Windows.Forms.BindingSource createTemplateFeedbackTypeBindingSource;
        private feedbackGeneratorDBDataSetTableAdapters.createTemplateFeedbackTypeTableAdapter createTemplateFeedbackTypeTableAdapter;
        private feedbackGeneratorDBDataSet1 feedbackGeneratorDBDataSet1;
        private System.Windows.Forms.BindingSource createTemplateBindingSource;
        private feedbackGeneratorDBDataSet1TableAdapters.createTemplateTableAdapter createTemplateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateReviewerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templatePositionDataGridViewTextBoxColumn;
    }
}