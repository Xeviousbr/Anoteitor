namespace Anoteitor
{
    partial class SubAtividade
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
            this.txSub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAtividade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txSub
            // 
            this.txSub.Location = new System.Drawing.Point(15, 51);
            this.txSub.Name = "txSub";
            this.txSub.Size = new System.Drawing.Size(209, 20);
            this.txSub.TabIndex = 4;
            this.txSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSub_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Sub-Atividade";
            // 
            // lbAtividade
            // 
            this.lbAtividade.AutoSize = true;
            this.lbAtividade.Location = new System.Drawing.Point(12, 9);
            this.lbAtividade.Name = "lbAtividade";
            this.lbAtividade.Size = new System.Drawing.Size(54, 13);
            this.lbAtividade.TabIndex = 5;
            this.lbAtividade.Text = "Atividade:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(149, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SubAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 112);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbAtividade);
            this.Controls.Add(this.txSub);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SubAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubAtividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAtividade;
        private System.Windows.Forms.Button button2;
    }
}