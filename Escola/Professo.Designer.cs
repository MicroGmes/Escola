namespace Escola
{
    partial class Professo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_emailerr = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.ComboBox();
            this.dgrid_prof = new System.Windows.Forms.DataGridView();
            this.remover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dnasc = new System.Windows.Forms.DateTimePicker();
            this.se = new System.Windows.Forms.Button();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ncomp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Button();
            this.disciplinaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.disciplinaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_disc = new System.Windows.Forms.CheckedListBox();
            this.txt_turmas = new System.Windows.Forms.CheckedListBox();
            this.search_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_prof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 77);
            this.button1.TabIndex = 63;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txt_emailerr
            // 
            this.txt_emailerr.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_emailerr.ForeColor = System.Drawing.Color.Red;
            this.txt_emailerr.Location = new System.Drawing.Point(12, 453);
            this.txt_emailerr.Name = "txt_emailerr";
            this.txt_emailerr.Size = new System.Drawing.Size(544, 36);
            this.txt_emailerr.TabIndex = 62;
            this.txt_emailerr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_genero
            // 
            this.txt_genero.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_genero.FormattingEnabled = true;
            this.txt_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txt_genero.Location = new System.Drawing.Point(279, 177);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(277, 33);
            this.txt_genero.TabIndex = 61;
            // 
            // dgrid_prof
            // 
            this.dgrid_prof.AllowUserToResizeColumns = false;
            this.dgrid_prof.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_prof.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid_prof.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_prof.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrid_prof.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_prof.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrid_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_prof.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgrid_prof.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrid_prof.Location = new System.Drawing.Point(580, 154);
            this.dgrid_prof.Name = "dgrid_prof";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_prof.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrid_prof.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgrid_prof.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_prof.RowTemplate.Height = 25;
            this.dgrid_prof.Size = new System.Drawing.Size(859, 463);
            this.dgrid_prof.TabIndex = 60;
            this.dgrid_prof.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_prof_CellContentClick);
            // 
            // remover
            // 
            this.remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remover.BackColor = System.Drawing.Color.Transparent;
            this.remover.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remover.Location = new System.Drawing.Point(208, 498);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(178, 126);
            this.remover.TabIndex = 59;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1427, 77);
            this.label1.TabIndex = 43;
            this.label1.Text = "Professores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dnasc
            // 
            this.txt_dnasc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dnasc.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dnasc.Location = new System.Drawing.Point(279, 138);
            this.txt_dnasc.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txt_dnasc.Name = "txt_dnasc";
            this.txt_dnasc.Size = new System.Drawing.Size(277, 33);
            this.txt_dnasc.TabIndex = 58;
            // 
            // se
            // 
            this.se.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.se.BackColor = System.Drawing.Color.Transparent;
            this.se.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.se.Location = new System.Drawing.Point(12, 498);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(190, 126);
            this.se.TabIndex = 55;
            this.se.Text = "Salvar / Editar";
            this.se.UseVisualStyleBackColor = false;
            this.se.Click += new System.EventHandler(this.se_Click);
            // 
            // txt_end
            // 
            this.txt_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_end.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_end.Location = new System.Drawing.Point(279, 291);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(277, 32);
            this.txt_end.TabIndex = 53;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(279, 215);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(277, 32);
            this.txt_email.TabIndex = 52;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_ncomp
            // 
            this.txt_ncomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ncomp.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ncomp.Location = new System.Drawing.Point(279, 100);
            this.txt_ncomp.Name = "txt_ncomp";
            this.txt_ncomp.Size = new System.Drawing.Size(277, 32);
            this.txt_ncomp.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 38);
            this.label8.TabIndex = 50;
            this.label8.Text = "Turmas";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 38);
            this.label7.TabIndex = 49;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 38);
            this.label6.TabIndex = 48;
            this.label6.Text = "Morada";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 38);
            this.label5.TabIndex = 47;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 38);
            this.label4.TabIndex = 46;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 38);
            this.label3.TabIndex = 45;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome completo";
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc.Location = new System.Drawing.Point(392, 498);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(164, 126);
            this.desc.TabIndex = 56;
            this.desc.TabStop = false;
            this.desc.Text = "Desselecionar";
            this.desc.UseMnemonic = false;
            this.desc.UseVisualStyleBackColor = false;
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // disciplinaBindingSource2
            // 
            this.disciplinaBindingSource2.DataSource = typeof(Escola.Modules.Disciplina);
            // 
            // disciplinaBindingSource1
            // 
            this.disciplinaBindingSource1.DataSource = typeof(Escola.Modules.Disciplina);
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataSource = typeof(Escola.Modules.Disciplina);
            this.disciplinaBindingSource.CurrentChanged += new System.EventHandler(this.disciplinaBindingSource_CurrentChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(279, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 38);
            this.label9.TabIndex = 65;
            this.label9.Text = "Disciplinas";
            // 
            // disciplinaBindingSource3
            // 
            this.disciplinaBindingSource3.DataSource = typeof(Escola.Modules.Disciplina);
            // 
            // txt_tel
            // 
            this.txt_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tel.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tel.Location = new System.Drawing.Point(279, 253);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(277, 32);
            this.txt_tel.TabIndex = 97;
            // 
            // txt_disc
            // 
            this.txt_disc.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.disciplinaBindingSource, "Nome", true));
            this.txt_disc.FormattingEnabled = true;
            this.txt_disc.Location = new System.Drawing.Point(279, 380);
            this.txt_disc.Name = "txt_disc";
            this.txt_disc.Size = new System.Drawing.Size(277, 76);
            this.txt_disc.TabIndex = 98;
            // 
            // txt_turmas
            // 
            this.txt_turmas.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", this.disciplinaBindingSource, "Nome", true));
            this.txt_turmas.FormattingEnabled = true;
            this.txt_turmas.Location = new System.Drawing.Point(15, 380);
            this.txt_turmas.Name = "txt_turmas";
            this.txt_turmas.Size = new System.Drawing.Size(258, 76);
            this.txt_turmas.TabIndex = 99;
            // 
            // search_nome
            // 
            this.search_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_nome.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_nome.Location = new System.Drawing.Point(580, 116);
            this.search_nome.Name = "search_nome";
            this.search_nome.PlaceholderText = "  🔍  Pesquisar por Apelido do Professor";
            this.search_nome.Size = new System.Drawing.Size(859, 32);
            this.search_nome.TabIndex = 102;
            this.search_nome.TextChanged += new System.EventHandler(this.search_nome_TextChanged);
            // 
            // Professo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1451, 636);
            this.Controls.Add(this.search_nome);
            this.Controls.Add(this.txt_turmas);
            this.Controls.Add(this.txt_disc);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_emailerr);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.dgrid_prof);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dnasc);
            this.Controls.Add(this.se);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_ncomp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Professo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.Professores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_prof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lst_turm;
        private Label label17;
        private ListBox lst_ender;
        private Label label16;
        private ListBox lst_tel;
        private Label label15;
        private ListBox lst_email;
        private Label label14;
        private ListBox lst_gen;
        private Label label13;
        private ListBox lst_idade;
        private Label label12;
        private ListBox lst_apel;
        private Label label11;
        private ListBox lst_nmeio;
        private Label label10;
        private ListBox lst_pnome;
        private Label label9;
        private ListBox lst_disc;
        private Label label19;
        private Button button1;
        private Label txt_emailerr;
        private ComboBox txt_genero;
        private DataGridView dgrid_alunos;
        private Button remover;
        private Label label1;
        private DateTimePicker txt_dnasc;
        private Button se;
        private TextBox txt_end;
        private TextBox txt_email;
        private TextBox txt_ncomp;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button desc;
        private DataGridView dgrid_prof;
        private BindingSource disciplinaBindingSource;
        private BindingSource disciplinaBindingSource1;
        private BindingSource disciplinaBindingSource3;
        public BindingSource disciplinaBindingSource2;
        private TextBox txt_tel;
        private CheckedListBox txt_turmas;
        private CheckedListBox txt_disc;
        private TextBox search_nome;
    }
}