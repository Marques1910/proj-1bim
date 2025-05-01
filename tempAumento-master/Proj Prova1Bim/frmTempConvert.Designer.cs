namespace Proj_Prova1Bim
{
    partial class tmpConvet
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
            this.label2 = new System.Windows.Forms.Label();
            this.numOperAumento = new System.Windows.Forms.NumericUpDown();
            this.lblTempFinal = new System.Windows.Forms.Label();
            this.numOperTemp = new System.Windows.Forms.NumericUpDown();
            this.btConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOperAumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aumento(%)";
            // 
            // numOperAumento
            // 
            this.numOperAumento.Location = new System.Drawing.Point(334, 83);
            this.numOperAumento.Name = "numOperAumento";
            this.numOperAumento.Size = new System.Drawing.Size(168, 20);
            this.numOperAumento.TabIndex = 3;
            // 
            // lblTempFinal
            // 
            this.lblTempFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempFinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTempFinal.Location = new System.Drawing.Point(233, 200);
            this.lblTempFinal.Name = "lblTempFinal";
            this.lblTempFinal.Size = new System.Drawing.Size(168, 36);
            this.lblTempFinal.TabIndex = 4;
            this.lblTempFinal.Click += new System.EventHandler(this.lblTempFinal_Click);
            // 
            // numOperTemp
            // 
            this.numOperTemp.Location = new System.Drawing.Point(70, 83);
            this.numOperTemp.Name = "numOperTemp";
            this.numOperTemp.Size = new System.Drawing.Size(161, 20);
            this.numOperTemp.TabIndex = 5;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(239, 139);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tmpConvet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 283);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.numOperTemp);
            this.Controls.Add(this.lblTempFinal);
            this.Controls.Add(this.numOperAumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tmpConvet";
            this.Text = "Temperatura Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOperAumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOperAumento;
        private System.Windows.Forms.Label lblTempFinal;
        private System.Windows.Forms.NumericUpDown numOperTemp;
        private System.Windows.Forms.Button btConfirm;
    }
}

