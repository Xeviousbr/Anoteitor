namespace Anoteitor
{
    partial class Tempos
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
            this.btZerar = new System.Windows.Forms.Button();
            this.lvTempos = new System.Windows.Forms.ListView();
            this.Projeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempos gastos nos Atividades";
            // 
            // btZerar
            // 
            this.btZerar.Location = new System.Drawing.Point(68, 389);
            this.btZerar.Name = "btZerar";
            this.btZerar.Size = new System.Drawing.Size(75, 23);
            this.btZerar.TabIndex = 2;
            this.btZerar.Text = "Zerar";
            this.btZerar.UseVisualStyleBackColor = true;
            this.btZerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvTempos
            // 
            this.lvTempos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvTempos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lvTempos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Projeto,
            this.Tempo});
            this.lvTempos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvTempos.FullRowSelect = true;
            this.lvTempos.HideSelection = false;
            this.lvTempos.HotTracking = true;
            this.lvTempos.HoverSelection = true;
            this.lvTempos.Location = new System.Drawing.Point(3, 38);
            this.lvTempos.Name = "lvTempos";
            this.lvTempos.Size = new System.Drawing.Size(189, 305);
            this.lvTempos.TabIndex = 3;
            this.lvTempos.UseCompatibleStateImageBehavior = false;
            this.lvTempos.View = System.Windows.Forms.View.Details;
            // 
            // Projeto
            // 
            this.Projeto.Text = "Nome";
            this.Projeto.Width = 80;
            // 
            // Tempo
            // 
            this.Tempo.Text = "Lugar";
            this.Tempo.Width = 80;
            // 
            // Tempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 424);
            this.Controls.Add(this.lvTempos);
            this.Controls.Add(this.btZerar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Tempos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempos";
            this.Load += new System.EventHandler(this.Tempos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZerar;
        private System.Windows.Forms.ListView lvTempos;
        private System.Windows.Forms.ColumnHeader Projeto;
        private System.Windows.Forms.ColumnHeader Tempo;
    }
}