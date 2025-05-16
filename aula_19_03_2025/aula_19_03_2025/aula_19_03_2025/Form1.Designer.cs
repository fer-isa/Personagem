namespace aula_19_03_2025
{
    partial class main_form
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
            components = new System.ComponentModel.Container();
            pnl_cabecalho = new Panel();
            pnl_conteudo = new Panel();
            btn_apresentar = new Button();
            nud_Mp = new NumericUpDown();
            nud_Hp = new NumericUpDown();
            nud_level = new NumericUpDown();
            lbl_Mp = new Label();
            cbx_classe = new ComboBox();
            txt_nome = new TextBox();
            lbl_Hp = new Label();
            lbl_level = new Label();
            lbl_classe = new Label();
            lbl_nome = new Label();
            label1 = new Label();
            pnl_menu_lateral = new Panel();
            lbl_rsultado = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnl_conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Mp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Hp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_level).BeginInit();
            pnl_menu_lateral.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_cabecalho
            // 
            pnl_cabecalho.BackColor = Color.FromArgb(211, 171, 211);
            pnl_cabecalho.Dock = DockStyle.Top;
            pnl_cabecalho.Location = new Point(2, 2);
            pnl_cabecalho.Margin = new Padding(0);
            pnl_cabecalho.Name = "pnl_cabecalho";
            pnl_cabecalho.Size = new Size(844, 32);
            pnl_cabecalho.TabIndex = 0;
            // 
            // pnl_conteudo
            // 
            pnl_conteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_conteudo.BackColor = Color.FromArgb(183, 215, 199);
            pnl_conteudo.Controls.Add(btn_apresentar);
            pnl_conteudo.Controls.Add(nud_Mp);
            pnl_conteudo.Controls.Add(nud_Hp);
            pnl_conteudo.Controls.Add(nud_level);
            pnl_conteudo.Controls.Add(lbl_Mp);
            pnl_conteudo.Controls.Add(cbx_classe);
            pnl_conteudo.Controls.Add(txt_nome);
            pnl_conteudo.Controls.Add(lbl_Hp);
            pnl_conteudo.Controls.Add(lbl_level);
            pnl_conteudo.Controls.Add(lbl_classe);
            pnl_conteudo.Controls.Add(lbl_nome);
            pnl_conteudo.Controls.Add(label1);
            pnl_conteudo.Controls.Add(pnl_menu_lateral);
            pnl_conteudo.Location = new Point(2, 34);
            pnl_conteudo.Margin = new Padding(0);
            pnl_conteudo.Name = "pnl_conteudo";
            pnl_conteudo.Size = new Size(844, 409);
            pnl_conteudo.TabIndex = 1;
            // 
            // btn_apresentar
            // 
            btn_apresentar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_apresentar.AutoSize = true;
            btn_apresentar.BackColor = Color.FromArgb(168, 96, 169);
            btn_apresentar.FlatAppearance.BorderSize = 0;
            btn_apresentar.FlatStyle = FlatStyle.Flat;
            btn_apresentar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_apresentar.Location = new Point(402, 357);
            btn_apresentar.Margin = new Padding(16);
            btn_apresentar.Name = "btn_apresentar";
            btn_apresentar.Size = new Size(94, 31);
            btn_apresentar.TabIndex = 12;
            btn_apresentar.Text = "Apresentar";
            btn_apresentar.UseVisualStyleBackColor = false;
            btn_apresentar.Click += btn_apresentar_Click;
            // 
            // nud_Mp
            // 
            nud_Mp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nud_Mp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nud_Mp.Location = new Point(75, 221);
            nud_Mp.Margin = new Padding(8);
            nud_Mp.Name = "nud_Mp";
            nud_Mp.Size = new Size(345, 29);
            nud_Mp.TabIndex = 11;
            // 
            // nud_Hp
            // 
            nud_Hp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nud_Hp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nud_Hp.Location = new Point(75, 186);
            nud_Hp.Margin = new Padding(8);
            nud_Hp.Name = "nud_Hp";
            nud_Hp.Size = new Size(345, 29);
            nud_Hp.TabIndex = 10;
            // 
            // nud_level
            // 
            nud_level.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nud_level.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nud_level.Location = new Point(76, 147);
            nud_level.Margin = new Padding(8);
            nud_level.Name = "nud_level";
            nud_level.Size = new Size(344, 29);
            nud_level.TabIndex = 9;
            // 
            // lbl_Mp
            // 
            lbl_Mp.AutoSize = true;
            lbl_Mp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_Mp.Location = new Point(11, 229);
            lbl_Mp.Margin = new Padding(16, 8, 8, 8);
            lbl_Mp.Name = "lbl_Mp";
            lbl_Mp.Size = new Size(36, 21);
            lbl_Mp.TabIndex = 8;
            lbl_Mp.Text = "MP:";
            // 
            // cbx_classe
            // 
            cbx_classe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbx_classe.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_classe.FormattingEnabled = true;
            cbx_classe.Items.AddRange(new object[] { "Cavaleiro", "Mago", "Vampiro", "Bruxa" });
            cbx_classe.Location = new Point(75, 113);
            cbx_classe.Margin = new Padding(8);
            cbx_classe.Name = "cbx_classe";
            cbx_classe.Size = new Size(345, 29);
            cbx_classe.TabIndex = 7;
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nome.Location = new Point(75, 79);
            txt_nome.Margin = new Padding(8);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(345, 29);
            txt_nome.TabIndex = 6;
            // 
            // lbl_Hp
            // 
            lbl_Hp.AutoSize = true;
            lbl_Hp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_Hp.Location = new Point(11, 192);
            lbl_Hp.Margin = new Padding(16, 8, 8, 8);
            lbl_Hp.Name = "lbl_Hp";
            lbl_Hp.Size = new Size(33, 21);
            lbl_Hp.TabIndex = 5;
            lbl_Hp.Text = "HP:";
            // 
            // lbl_level
            // 
            lbl_level.AutoSize = true;
            lbl_level.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_level.Location = new Point(7, 155);
            lbl_level.Margin = new Padding(16, 8, 8, 8);
            lbl_level.Name = "lbl_level";
            lbl_level.Size = new Size(49, 21);
            lbl_level.TabIndex = 4;
            lbl_level.Text = "Level:";
            // 
            // lbl_classe
            // 
            lbl_classe.AutoSize = true;
            lbl_classe.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_classe.Location = new Point(6, 121);
            lbl_classe.Margin = new Padding(16, 8, 8, 8);
            lbl_classe.Name = "lbl_classe";
            lbl_classe.Size = new Size(57, 21);
            lbl_classe.TabIndex = 3;
            lbl_classe.Text = "Classe:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nome.Location = new Point(7, 84);
            lbl_nome.Margin = new Padding(16, 8, 8, 8);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(56, 21);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(142, 59, 156);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 1;
            label1.Text = "Exemplo Classe:";
            // 
            // pnl_menu_lateral
            // 
            pnl_menu_lateral.BackColor = Color.FromArgb(190, 179, 213);
            pnl_menu_lateral.Controls.Add(lbl_rsultado);
            pnl_menu_lateral.Dock = DockStyle.Right;
            pnl_menu_lateral.Location = new Point(524, 0);
            pnl_menu_lateral.Name = "pnl_menu_lateral";
            pnl_menu_lateral.Size = new Size(320, 409);
            pnl_menu_lateral.TabIndex = 0;
            // 
            // lbl_rsultado
            // 
            lbl_rsultado.AutoSize = true;
            lbl_rsultado.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_rsultado.Location = new Point(18, 18);
            lbl_rsultado.Name = "lbl_rsultado";
            lbl_rsultado.Size = new Size(54, 32);
            lbl_rsultado.TabIndex = 13;
            lbl_rsultado.Text = "[....]";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(848, 441);
            Controls.Add(pnl_conteudo);
            Controls.Add(pnl_cabecalho);
            MinimumSize = new Size(640, 480);
            Name = "main_form";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "aula 19-03-2025 - exemplo Classes";
            pnl_conteudo.ResumeLayout(false);
            pnl_conteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Mp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Hp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_level).EndInit();
            pnl_menu_lateral.ResumeLayout(false);
            pnl_menu_lateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_cabecalho;
        private Panel pnl_conteudo;
        private Panel pnl_menu_lateral;
        private Label lbl_nome;
        private Label label1;
        private Label lbl_classe;
        private Label lbl_Hp;
        private Label lbl_level;
        private ComboBox cbx_classe;
        private TextBox txt_nome;
        private Label lbl_Mp;
        private NumericUpDown nud_Mp;
        private NumericUpDown nud_Hp;
        private NumericUpDown nud_level;
        private Button btn_apresentar;
        private Label lbl_rsultado;
        private ContextMenuStrip contextMenuStrip1;
    }
}
