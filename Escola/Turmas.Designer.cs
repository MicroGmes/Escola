namespace Escola
{
    partial class Turmas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turmas));
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Button();
            this.se = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgrid_turmas = new System.Windows.Forms.DataGridView();
            this.remover = new System.Windows.Forms.Button();
            this.txt_disc = new System.Windows.Forms.CheckedListBox();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_dt = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.search_ano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1330, 77);
            this.label1.TabIndex = 64;
            this.label1.Text = "Turmas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc.Location = new System.Drawing.Point(376, 306);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(174, 164);
            this.desc.TabIndex = 74;
            this.desc.Text = "Desselecionar";
            this.desc.UseVisualStyleBackColor = false;
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // se
            // 
            this.se.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.se.BackColor = System.Drawing.Color.Transparent;
            this.se.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.se.Location = new System.Drawing.Point(12, 306);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(171, 164);
            this.se.TabIndex = 73;
            this.se.Text = "Salvar / Editar";
            this.se.UseVisualStyleBackColor = false;
            this.se.Click += new System.EventHandler(this.se_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(263, 106);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(287, 32);
            this.txt_nome.TabIndex = 71;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Disciplinas";
            // 
            // txt_ano
            // 
            this.txt_ano.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_ano.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ano.Location = new System.Drawing.Point(263, 144);
            this.txt_ano.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(287, 37);
            this.txt_ano.TabIndex = 88;
            this.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 37);
            this.label3.TabIndex = 87;
            this.label3.Text = "Ano Escolar";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 89;
            this.label5.Text = "Diretor de turma";
            // 
            // dgrid_turmas
            // 
            this.dgrid_turmas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_turmas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_turmas.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_turmas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrid_turmas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "-/-/-/-/-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_turmas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_turmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrid_turmas.Location = new System.Drawing.Point(579, 138);
            this.dgrid_turmas.Name = "dgrid_turmas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrid_turmas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_turmas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_turmas.RowTemplate.Height = 25;
            this.dgrid_turmas.Size = new System.Drawing.Size(713, 332);
            this.dgrid_turmas.TabIndex = 91;
            this.dgrid_turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_disc_CellContentClick);
            // 
            // remover
            // 
            this.remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remover.BackColor = System.Drawing.Color.Transparent;
            this.remover.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remover.Location = new System.Drawing.Point(189, 306);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(181, 164);
            this.remover.TabIndex = 92;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // txt_disc
            // 
            this.txt_disc.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.disciplinaBindingSource, "Nome", true));
            this.txt_disc.FormattingEnabled = true;
            this.txt_disc.Location = new System.Drawing.Point(263, 225);
            this.txt_disc.Name = "txt_disc";
            this.txt_disc.Size = new System.Drawing.Size(287, 76);
            this.txt_disc.TabIndex = 93;
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataSource = typeof(Escola.Modules.Disciplina);
            // 
            // txt_dt
            // 
            this.txt_dt.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dt.FormattingEnabled = true;
            this.txt_dt.Location = new System.Drawing.Point(263, 186);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(287, 33);
            this.txt_dt.TabIndex = 94;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(Escola.Modules.Professor);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 74);
            this.button3.TabIndex = 95;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search_ano
            // 
            this.search_ano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_ano.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_ano.Location = new System.Drawing.Point(579, 101);
            this.search_ano.Name = "search_ano";
            this.search_ano.PlaceholderText = "  🔍  Pesquisar por Ano de Escolaridade";
            this.search_ano.Size = new System.Drawing.Size(713, 32);
            this.search_ano.TabIndex = 104;
            this.search_ano.TextChanged += new System.EventHandler(this.search_ano_TextChanged);
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1318, 482);
            this.Controls.Add(this.search_ano);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.txt_disc);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.dgrid_turmas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.se);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Turmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Turmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lst_nalu;
        private Label label13;
        private ListBox lst_disc;
        private Label label12;
        private ListBox lst_dt;
        private Label label11;
        private ListBox lst_ano;
        private Label label10;
        private ListBox lst_nome;
        private Label label9;
        private Button desc;
        private Button se;
        private TextBox txt_nome;
        private Label label4;
        private Label label2;
        private NumericUpDown txt_ano;
        private Label label3;
        private Label label5;
        private DataGridView dgrid_turmas;
        private Button remover;
        private CheckedListBox txt_disc;
        private BindingSource disciplinaBindingSource;
        private ComboBox txt_dt;
        private BindingSource professorBindingSource;
        private Button button3;
        private TextBox search_ano;
    }
}