namespace Escola
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Alunos = new System.Windows.Forms.Button();
            this.Professore = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Turmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que quer gerir?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alunos
            // 
            this.Alunos.BackColor = System.Drawing.SystemColors.Window;
            this.Alunos.BackgroundImage = global::Escola.Properties.Resources.al;
            this.Alunos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alunos.Image = ((System.Drawing.Image)(resources.GetObject("Alunos.Image")));
            this.Alunos.Location = new System.Drawing.Point(12, 142);
            this.Alunos.Name = "Alunos";
            this.Alunos.Size = new System.Drawing.Size(786, 109);
            this.Alunos.TabIndex = 1;
            this.Alunos.UseVisualStyleBackColor = false;
            this.Alunos.Click += new System.EventHandler(this.Alunos_Click_1);
            // 
            // Professore
            // 
            this.Professore.BackgroundImage = global::Escola.Properties.Resources.al;
            this.Professore.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Professore.Image = ((System.Drawing.Image)(resources.GetObject("Professore.Image")));
            this.Professore.Location = new System.Drawing.Point(12, 257);
            this.Professore.Name = "Professore";
            this.Professore.Size = new System.Drawing.Size(786, 125);
            this.Professore.TabIndex = 2;
            this.Professore.UseVisualStyleBackColor = true;
            this.Professore.Click += new System.EventHandler(this.Professores_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Escola.Properties.Resources.al;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(786, 133);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Escola.Properties.Resources.al;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(786, 128);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(786, 77);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Turmas
            // 
            this.Turmas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Turmas.BackgroundImage = global::Escola.Properties.Resources.al;
            this.Turmas.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turmas.Image = ((System.Drawing.Image)(resources.GetObject("Turmas.Image")));
            this.Turmas.Location = new System.Drawing.Point(12, 661);
            this.Turmas.Name = "Turmas";
            this.Turmas.Size = new System.Drawing.Size(786, 129);
            this.Turmas.TabIndex = 6;
            this.Turmas.UseVisualStyleBackColor = true;
            this.Turmas.Click += new System.EventHandler(this.Turmas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(810, 802);
            this.Controls.Add(this.Turmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Professore);
            this.Controls.Add(this.Alunos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button Alunos;
        private Button Professores;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button Turmas;
        private Button Professore;
    }
}