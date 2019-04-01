namespace TimedQueueProj
{
    partial class TeamForm
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
            this.btnArriaved = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnDeparted = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArriaved
            // 
            this.btnArriaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnArriaved.Location = new System.Drawing.Point(169, 103);
            this.btnArriaved.Name = "btnArriaved";
            this.btnArriaved.Size = new System.Drawing.Size(80, 35);
            this.btnArriaved.TabIndex = 0;
            this.btnArriaved.Text = "arrived";
            this.btnArriaved.UseVisualStyleBackColor = true;
            this.btnArriaved.Click += new System.EventHandler(this.btnArriaved_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRes.Location = new System.Drawing.Point(169, 163);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(21, 20);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "...";
            // 
            // btnDeparted
            // 
            this.btnDeparted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeparted.Location = new System.Drawing.Point(334, 103);
            this.btnDeparted.Name = "btnDeparted";
            this.btnDeparted.Size = new System.Drawing.Size(100, 35);
            this.btnDeparted.TabIndex = 2;
            this.btnDeparted.Text = "departed";
            this.btnDeparted.UseVisualStyleBackColor = true;
            this.btnDeparted.Click += new System.EventHandler(this.btnDeparted_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblComp.Location = new System.Drawing.Point(502, 163);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(21, 20);
            this.lblComp.TabIndex = 3;
            this.lblComp.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.btnDeparted);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnArriaved);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArriaved;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnDeparted;
        private System.Windows.Forms.Label lblComp;
    }
}

