namespace Escola
{
    partial class Notas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            this.txt_valor = new System.Windows.Forms.NumericUpDown();
            this.desc = new System.Windows.Forms.Button();
            this.se = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remover = new System.Windows.Forms.Button();
            this.dgrid_notas = new System.Windows.Forms.DataGridView();
            this.txt_disc = new System.Windows.Forms.ComboBox();
            this.txt_aluno = new System.Windows.Forms.ComboBox();
            this.txt_prof = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_notas)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1163, 77);
            this.label1.TabIndex = 37;
            this.label1.Text = "Notas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_data
            // 
            this.txt_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_data.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_data.Location = new System.Drawing.Point(233, 192);
            this.txt_data.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(289, 37);
            this.txt_data.TabIndex = 53;
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor.Location = new System.Drawing.Point(233, 149);
            this.txt_valor.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(289, 37);
            this.txt_valor.TabIndex = 52;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc.Location = new System.Drawing.Point(356, 390);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(166, 164);
            this.desc.TabIndex = 51;
            this.desc.Text = "Desselecionar";
            this.desc.UseVisualStyleBackColor = false;
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // se
            // 
            this.se.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.se.BackColor = System.Drawing.Color.Transparent;
            this.se.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.se.Location = new System.Drawing.Point(21, 390);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(174, 164);
            this.se.TabIndex = 50;
            this.se.Text = "Salvar / Editar";
            this.se.UseVisualStyleBackColor = false;
            this.se.Click += new System.EventHandler(this.se_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 43;
            this.label7.Text = "Valor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 41;
            this.label5.Text = "Professor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "Aluno";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Disciplina";
            // 
            // remover
            // 
            this.remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remover.BackColor = System.Drawing.Color.Transparent;
            this.remover.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remover.Location = new System.Drawing.Point(201, 390);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(149, 164);
            this.remover.TabIndex = 60;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // dgrid_notas
            // 
            this.dgrid_notas.AllowUserToResizeColumns = false;
            this.dgrid_notas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_notas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_notas.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_notas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrid_notas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_notas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_notas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_notas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrid_notas.Location = new System.Drawing.Point(539, 149);
            this.dgrid_notas.Name = "dgrid_notas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_notas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrid_notas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_notas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgrid_notas.RowTemplate.Height = 25;
            this.dgrid_notas.Size = new System.Drawing.Size(600, 405);
            this.dgrid_notas.TabIndex = 61;
            this.dgrid_notas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_notas_CellContentClick);
            // 
            // txt_disc
            // 
            this.txt_disc.DisplayMember = "Nome";
            this.txt_disc.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_disc.FormattingEnabled = true;
            this.txt_disc.Location = new System.Drawing.Point(233, 232);
            this.txt_disc.Name = "txt_disc";
            this.txt_disc.Size = new System.Drawing.Size(289, 33);
            this.txt_disc.TabIndex = 97;
            this.txt_disc.ValueMember = "Nome";
            // 
            // txt_aluno
            // 
            this.txt_aluno.DisplayMember = "Nome";
            this.txt_aluno.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_aluno.FormattingEnabled = true;
            this.txt_aluno.Location = new System.Drawing.Point(233, 269);
            this.txt_aluno.Name = "txt_aluno";
            this.txt_aluno.Size = new System.Drawing.Size(289, 33);
            this.txt_aluno.TabIndex = 98;
            this.txt_aluno.ValueMember = "Nome";
            // 
            // txt_prof
            // 
            this.txt_prof.DisplayMember = "Nome";
            this.txt_prof.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_prof.FormattingEnabled = true;
            this.txt_prof.Location = new System.Drawing.Point(233, 308);
            this.txt_prof.Name = "txt_prof";
            this.txt_prof.Size = new System.Drawing.Size(289, 33);
            this.txt_prof.TabIndex = 99;
            this.txt_prof.ValueMember = "Nome";
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
            this.button1.TabIndex = 100;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_nome
            // 
            this.search_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_nome.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_nome.Location = new System.Drawing.Point(539, 111);
            this.search_nome.Name = "search_nome";
            this.search_nome.PlaceholderText = "  🔍  Pesquisar por Primeiro e Último Nome do Aluno";
            this.search_nome.Size = new System.Drawing.Size(600, 32);
            this.search_nome.TabIndex = 104;
            this.search_nome.TextChanged += new System.EventHandler(this.search_nome_TextChanged);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1151, 566);
            this.Controls.Add(this.search_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_prof);
            this.Controls.Add(this.txt_aluno);
            this.Controls.Add(this.txt_disc);
            this.Controls.Add(this.dgrid_notas);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.se);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_notas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker txt_data;
        private NumericUpDown txt_valor;
        private Button desc;
        private Button se;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button remover;
        private DataGridView dgrid_notas;
        private ComboBox txt_disc;
        private ComboBox txt_aluno;
        private ComboBox txt_prof;
        private Button button1;
        private TextBox search_nome;
    }
}