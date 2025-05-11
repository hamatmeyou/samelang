namespace MERCURY_SYSTEM
{
    partial class frmMainMenu
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
            this.txtPleasechoosewanttodo = new System.Windows.Forms.Label();
            this.btnADDMEDICINE = new System.Windows.Forms.Button();
            this.btnVIEWMEDICINE = new System.Windows.Forms.Button();
            this.btnSELLMEDICINE = new System.Windows.Forms.Button();
            this.btnYOUMAYADD = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPleasechoosewanttodo
            // 
            this.txtPleasechoosewanttodo.AutoSize = true;
            this.txtPleasechoosewanttodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPleasechoosewanttodo.Location = new System.Drawing.Point(311, 31);
            this.txtPleasechoosewanttodo.Name = "txtPleasechoosewanttodo";
            this.txtPleasechoosewanttodo.Size = new System.Drawing.Size(150, 13);
            this.txtPleasechoosewanttodo.TabIndex = 0;
            this.txtPleasechoosewanttodo.Text = "Please choose want to do";
            this.txtPleasechoosewanttodo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnADDMEDICINE
            // 
            this.btnADDMEDICINE.AccessibleName = "";
            this.btnADDMEDICINE.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDMEDICINE.Location = new System.Drawing.Point(85, 94);
            this.btnADDMEDICINE.Name = "btnADDMEDICINE";
            this.btnADDMEDICINE.Size = new System.Drawing.Size(214, 32);
            this.btnADDMEDICINE.TabIndex = 1;
            this.btnADDMEDICINE.Text = "ADD MEDICINE";
            this.btnADDMEDICINE.UseVisualStyleBackColor = true;
            // 
            // btnVIEWMEDICINE
            // 
            this.btnVIEWMEDICINE.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIEWMEDICINE.Location = new System.Drawing.Point(85, 146);
            this.btnVIEWMEDICINE.Name = "btnVIEWMEDICINE";
            this.btnVIEWMEDICINE.Size = new System.Drawing.Size(214, 31);
            this.btnVIEWMEDICINE.TabIndex = 2;
            this.btnVIEWMEDICINE.Text = "VIEW MEDICINE";
            this.btnVIEWMEDICINE.UseVisualStyleBackColor = true;
            // 
            // btnSELLMEDICINE
            // 
            this.btnSELLMEDICINE.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSELLMEDICINE.Location = new System.Drawing.Point(85, 197);
            this.btnSELLMEDICINE.Name = "btnSELLMEDICINE";
            this.btnSELLMEDICINE.Size = new System.Drawing.Size(214, 31);
            this.btnSELLMEDICINE.TabIndex = 3;
            this.btnSELLMEDICINE.Text = "SELL MEDICINE";
            this.btnSELLMEDICINE.UseVisualStyleBackColor = true;
            // 
            // btnYOUMAYADD
            // 
            this.btnYOUMAYADD.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYOUMAYADD.Location = new System.Drawing.Point(393, 95);
            this.btnYOUMAYADD.Name = "btnYOUMAYADD";
            this.btnYOUMAYADD.Size = new System.Drawing.Size(214, 31);
            this.btnYOUMAYADD.TabIndex = 4;
            this.btnYOUMAYADD.Text = "YOU MAY ADD...";
            this.btnYOUMAYADD.UseVisualStyleBackColor = true;
            this.btnYOUMAYADD.Click += new System.EventHandler(this.btnYOUMAYADD_Click);
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(393, 146);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(214, 31);
            this.b.TabIndex = 5;
            this.b.Text = "YOU MAY ADD....";
            this.b.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b);
            this.Controls.Add(this.btnYOUMAYADD);
            this.Controls.Add(this.btnSELLMEDICINE);
            this.Controls.Add(this.btnVIEWMEDICINE);
            this.Controls.Add(this.btnADDMEDICINE);
            this.Controls.Add(this.txtPleasechoosewanttodo);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPleasechoosewanttodo;
        private System.Windows.Forms.Button btnADDMEDICINE;
        private System.Windows.Forms.Button btnVIEWMEDICINE;
        private System.Windows.Forms.Button btnSELLMEDICINE;
        private System.Windows.Forms.Button btnYOUMAYADD;
        private System.Windows.Forms.Button b;
    }
}