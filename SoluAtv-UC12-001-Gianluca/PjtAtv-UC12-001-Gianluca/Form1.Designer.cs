namespace PjtAtv_UC12_001_Gianluca
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblDataNasc = new Label();
            lblRendaMensal = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtRendaMensal = new TextBox();
            btnCadastrar = new Button();
            DtpDataNasc = new DateTimePicker();
            txtId = new TextBox();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(86, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(86, 125);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpf.Location = new Point(86, 172);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(49, 28);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            lblCpf.Click += lblCpf_Click;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataNasc.Location = new Point(86, 225);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(166, 28);
            lblDataNasc.TabIndex = 3;
            lblDataNasc.Text = "Data Nascimento:";
            // 
            // lblRendaMensal
            // 
            lblRendaMensal.AutoSize = true;
            lblRendaMensal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblRendaMensal.Location = new Point(86, 284);
            lblRendaMensal.Name = "lblRendaMensal";
            lblRendaMensal.Size = new Size(177, 28);
            lblRendaMensal.TabIndex = 4;
            lblRendaMensal.Text = "Renda Mensal (R$):";
            lblRendaMensal.Click += label5_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(162, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(324, 25);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(162, 175);
            txtCpf.MaxLength = 11;
            txtCpf.MinimumSize = new Size(11, 11);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(324, 25);
            txtCpf.TabIndex = 7;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaMensal.Location = new Point(269, 289);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(217, 25);
            txtRendaMensal.TabIndex = 9;
            txtRendaMensal.TextChanged += txtRendaMensal_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(360, 335);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(126, 35);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // DtpDataNasc
            // 
            DtpDataNasc.Location = new Point(258, 230);
            DtpDataNasc.Name = "DtpDataNasc";
            DtpDataNasc.Size = new Size(228, 23);
            DtpDataNasc.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Location = new Point(125, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(802, 89);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 37);
            lblWelcome.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 608);
            Controls.Add(lblWelcome);
            Controls.Add(DtpDataNasc);
            Controls.Add(btnCadastrar);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblRendaMensal);
            Controls.Add(lblDataNasc);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblDataNasc;
        private Label lblRendaMensal;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtRendaMensal;
        private Button btnCadastrar;
        private DateTimePicker DtpDataNasc;
        private TextBox txtId;
        private Label lblWelcome;
    }
}