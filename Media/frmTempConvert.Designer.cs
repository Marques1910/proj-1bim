namespace Media
{
    partial class frmTempConvert
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
            this.numOperAumento = new System.Windows.Forms.NumericUpDown();
            this.numOperTemp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lblTempFinal = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOperAumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // numOperAumento
            // 
            this.numOperAumento.Location = new System.Drawing.Point(439, 215);
            this.numOperAumento.Name = "numOperAumento";
            this.numOperAumento.Size = new System.Drawing.Size(168, 20);
            this.numOperAumento.TabIndex = 4;
            // 
            // numOperTemp
            // 
            this.numOperTemp.Location = new System.Drawing.Point(224, 215);
            this.numOperTemp.Name = "numOperTemp";
            this.numOperTemp.Size = new System.Drawing.Size(161, 20);
            this.numOperTemp.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aumento(%)";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(317, 301);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 9;
            this.btConfirm.Text = "confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lblTempFinal
            // 
            this.lblTempFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempFinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTempFinal.Location = new System.Drawing.Point(324, 378);
            this.lblTempFinal.Name = "lblTempFinal";
            this.lblTempFinal.Size = new System.Drawing.Size(168, 36);
            this.lblTempFinal.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(439, 301);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTempConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTempFinal);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOperTemp);
            this.Controls.Add(this.numOperAumento);
            this.Name = "frmTempConvert";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOperAumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numOperAumento;
        private System.Windows.Forms.NumericUpDown numOperTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lblTempFinal;
        private System.Windows.Forms.Button btnSair;
    }
}