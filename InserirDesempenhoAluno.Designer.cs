
namespace Escola
{
    partial class InserirDesempenhoAluno
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbResultado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMF1 = new System.Windows.Forms.ComboBox();
            this.cbMI1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMF2 = new System.Windows.Forms.ComboBox();
            this.cbMI2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbResultado);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtFaltas);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 82);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // cbResultado
            // 
            this.cbResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResultado.FormattingEnabled = true;
            this.cbResultado.Items.AddRange(new object[] {
            "Aprovado",
            "Reprovado"});
            this.cbResultado.Location = new System.Drawing.Point(71, 45);
            this.cbResultado.Name = "cbResultado";
            this.cbResultado.Size = new System.Drawing.Size(100, 23);
            this.cbResultado.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Faltas";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(71, 16);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 23);
            this.txtFaltas.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMF1);
            this.groupBox2.Controls.Add(this.cbMI1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(203, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primeiro Semestre";
            // 
            // cbMF1
            // 
            this.cbMF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMF1.FormattingEnabled = true;
            this.cbMF1.Items.AddRange(new object[] {
            "MB",
            "B",
            "R",
            "I"});
            this.cbMF1.Location = new System.Drawing.Point(135, 45);
            this.cbMF1.Name = "cbMF1";
            this.cbMF1.Size = new System.Drawing.Size(62, 23);
            this.cbMF1.TabIndex = 12;
            // 
            // cbMI1
            // 
            this.cbMI1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMI1.FormattingEnabled = true;
            this.cbMI1.Items.AddRange(new object[] {
            "MB",
            "B",
            "R",
            "I"});
            this.cbMI1.Location = new System.Drawing.Point(135, 16);
            this.cbMI1.Name = "cbMI1";
            this.cbMI1.Size = new System.Drawing.Size(62, 23);
            this.cbMI1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Menção Intermediária";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Menção Final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRM);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RM";
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(71, 45);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(100, 23);
            this.txtRM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dados de Desempenho de Aluno";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMF2);
            this.groupBox4.Controls.Add(this.cbMI2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(203, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 82);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Segundo Semestre";
            // 
            // cbMF2
            // 
            this.cbMF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMF2.FormattingEnabled = true;
            this.cbMF2.Items.AddRange(new object[] {
            "MB",
            "B",
            "R",
            "I"});
            this.cbMF2.Location = new System.Drawing.Point(135, 45);
            this.cbMF2.Name = "cbMF2";
            this.cbMF2.Size = new System.Drawing.Size(62, 23);
            this.cbMF2.TabIndex = 12;
            // 
            // cbMI2
            // 
            this.cbMI2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMI2.FormattingEnabled = true;
            this.cbMI2.Items.AddRange(new object[] {
            "MB",
            "B",
            "R",
            "I"});
            this.cbMI2.Location = new System.Drawing.Point(135, 16);
            this.cbMI2.Name = "cbMI2";
            this.cbMI2.Size = new System.Drawing.Size(62, 23);
            this.cbMI2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Menção Intermediária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Menção Final";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 223);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // InserirDesempenhoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "InserirDesempenhoAluno";
            this.Text = "InserirDesempenhoAluno";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbMF1;
        private System.Windows.Forms.ComboBox cbMI1;
        private System.Windows.Forms.ComboBox cbMF2;
        private System.Windows.Forms.ComboBox cbMI2;
        private System.Windows.Forms.ComboBox cbResultado;
    }
}