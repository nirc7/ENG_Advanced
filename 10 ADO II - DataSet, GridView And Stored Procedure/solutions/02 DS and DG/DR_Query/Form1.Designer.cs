namespace DR_NoneQuery
{
    partial class Form1
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
            this.rbt_ID = new System.Windows.Forms.RadioButton();
            this.rbt_Name = new System.Windows.Forms.RadioButton();
            this.rbt_Family = new System.Windows.Forms.RadioButton();
            this.Select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnParam = new System.Windows.Forms.Button();
            this.txtSel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_ID
            // 
            this.rbt_ID.AutoSize = true;
            this.rbt_ID.Location = new System.Drawing.Point(83, 37);
            this.rbt_ID.Name = "rbt_ID";
            this.rbt_ID.Size = new System.Drawing.Size(70, 17);
            this.rbt_ID.TabIndex = 9;
            this.rbt_ID.TabStop = true;
            this.rbt_ID.Text = "sort by ID";
            this.rbt_ID.UseVisualStyleBackColor = true;
            // 
            // rbt_Name
            // 
            this.rbt_Name.AutoSize = true;
            this.rbt_Name.Location = new System.Drawing.Point(83, 61);
            this.rbt_Name.Name = "rbt_Name";
            this.rbt_Name.Size = new System.Drawing.Size(87, 17);
            this.rbt_Name.TabIndex = 10;
            this.rbt_Name.TabStop = true;
            this.rbt_Name.Text = "sort by Name";
            this.rbt_Name.UseVisualStyleBackColor = true;
            // 
            // rbt_Family
            // 
            this.rbt_Family.AutoSize = true;
            this.rbt_Family.Location = new System.Drawing.Point(83, 84);
            this.rbt_Family.Name = "rbt_Family";
            this.rbt_Family.Size = new System.Drawing.Size(88, 17);
            this.rbt_Family.TabIndex = 11;
            this.rbt_Family.TabStop = true;
            this.rbt_Family.Text = "sort by Family";
            this.rbt_Family.UseVisualStyleBackColor = true;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(83, 113);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 12;
            this.Select.Text = "Show Table";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(83, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(290, 274);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // btnCapital
            // 
            this.btnCapital.Location = new System.Drawing.Point(83, 197);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(123, 23);
            this.btnCapital.TabIndex = 15;
            this.btnCapital.Text = "Edit Name to Capital";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.Click += new System.EventHandler(this.btnCapital_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(83, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update DB";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnParam
            // 
            this.btnParam.Location = new System.Drawing.Point(189, 140);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(109, 23);
            this.btnParam.TabIndex = 17;
            this.btnParam.Text = "Select By Param";
            this.btnParam.UseVisualStyleBackColor = true;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // txtSel
            // 
            this.txtSel.Location = new System.Drawing.Point(83, 142);
            this.txtSel.Name = "txtSel";
            this.txtSel.Size = new System.Drawing.Size(100, 20);
            this.txtSel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 593);
            this.Controls.Add(this.txtSel);
            this.Controls.Add(this.btnParam);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCapital);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbt_Name);
            this.Controls.Add(this.rbt_ID);
            this.Controls.Add(this.rbt_Family);
            this.Controls.Add(this.Select);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_ID;
        private System.Windows.Forms.RadioButton rbt_Name;
        private System.Windows.Forms.RadioButton rbt_Family;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.TextBox txtSel;

    }
}

