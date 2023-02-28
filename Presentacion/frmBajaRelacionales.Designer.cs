
namespace Presentacion
{
    partial class frmBajaRelacionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajaRelacionales));
            this.lblRelacional = new System.Windows.Forms.Label();
            this.cboRelacional = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRelacional
            // 
            this.lblRelacional.AutoSize = true;
            this.lblRelacional.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRelacional.Location = new System.Drawing.Point(12, 50);
            this.lblRelacional.Name = "lblRelacional";
            this.lblRelacional.Size = new System.Drawing.Size(0, 13);
            this.lblRelacional.TabIndex = 4;
            // 
            // cboRelacional
            // 
            this.cboRelacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRelacional.FormattingEnabled = true;
            this.cboRelacional.Location = new System.Drawing.Point(86, 47);
            this.cboRelacional.Name = "cboRelacional";
            this.cboRelacional.Size = new System.Drawing.Size(167, 21);
            this.cboRelacional.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBajaRelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(273, 155);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboRelacional);
            this.Controls.Add(this.lblRelacional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBajaRelacionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.frmBajaRelacionales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRelacional;
        private System.Windows.Forms.ComboBox cboRelacional;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}