namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnUpDS2DB = new System.Windows.Forms.Button();
            this.btnParameters = new System.Windows.Forms.Button();
            this.btnSELECTWhSP = new System.Windows.Forms.Button();
            this.btnSelectTableWhSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(79, 277);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 228);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 228);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(343, 228);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFamily.TabIndex = 5;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(474, 228);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 6;
            // 
            // btnUpDS2DB
            // 
            this.btnUpDS2DB.Location = new System.Drawing.Point(79, 316);
            this.btnUpDS2DB.Name = "btnUpDS2DB";
            this.btnUpDS2DB.Size = new System.Drawing.Size(170, 23);
            this.btnUpDS2DB.TabIndex = 7;
            this.btnUpDS2DB.Text = "UPDATE FROM DS 2 DB";
            this.btnUpDS2DB.UseVisualStyleBackColor = true;
            this.btnUpDS2DB.Click += new System.EventHandler(this.btnUpDS2DB_Click);
            // 
            // btnParameters
            // 
            this.btnParameters.Location = new System.Drawing.Point(79, 354);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(170, 23);
            this.btnParameters.TabIndex = 8;
            this.btnParameters.Text = "SELECT Wh Parameters";
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // btnSELECTWhSP
            // 
            this.btnSELECTWhSP.Location = new System.Drawing.Point(79, 393);
            this.btnSELECTWhSP.Name = "btnSELECTWhSP";
            this.btnSELECTWhSP.Size = new System.Drawing.Size(170, 23);
            this.btnSELECTWhSP.TabIndex = 9;
            this.btnSELECTWhSP.Text = "SELECT Wh SP";
            this.btnSELECTWhSP.UseVisualStyleBackColor = true;
            this.btnSELECTWhSP.Click += new System.EventHandler(this.btnSELECTWhSP_Click);
            // 
            // btnSelectTableWhSP
            // 
            this.btnSelectTableWhSP.Location = new System.Drawing.Point(79, 436);
            this.btnSelectTableWhSP.Name = "btnSelectTableWhSP";
            this.btnSelectTableWhSP.Size = new System.Drawing.Size(170, 23);
            this.btnSelectTableWhSP.TabIndex = 10;
            this.btnSelectTableWhSP.Text = "SELECT TABLE Wh SP";
            this.btnSelectTableWhSP.UseVisualStyleBackColor = true;
            this.btnSelectTableWhSP.Click += new System.EventHandler(this.btnSelectTableWhSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnSelectTableWhSP);
            this.Controls.Add(this.btnSELECTWhSP);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.btnUpDS2DB);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnUpDS2DB;
        private System.Windows.Forms.Button btnParameters;
        private System.Windows.Forms.Button btnSELECTWhSP;
        private System.Windows.Forms.Button btnSelectTableWhSP;
    }
}

