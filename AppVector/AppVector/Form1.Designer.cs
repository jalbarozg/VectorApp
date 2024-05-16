namespace AppVector
{
    partial class Frmvectores
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
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Location = new System.Drawing.Point(78, 63);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(31, 13);
            this.lbvalor.TabIndex = 0;
            this.lbvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(139, 56);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(265, 52);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(73, 107);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 3;
            this.lbresultado.Text = "Resultado";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(76, 133);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicoToolStripMenuItem,
            this.avanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicoToolStripMenuItem
            // 
            this.basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
            this.basicoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.basicoToolStripMenuItem.Text = "Basico";
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantDeToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            // 
            // cantDeToolStripMenuItem
            // 
            this.cantDeToolStripMenuItem.Name = "cantDeToolStripMenuItem";
            this.cantDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cantDeToolStripMenuItem.Text = "cantDePares";
            this.cantDeToolStripMenuItem.Click += new System.EventHandler(this.cantDeToolStripMenuItem_Click);
            // 
            // Frmvectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frmvectores";
            this.Text = "Vectores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantDeToolStripMenuItem;
    }
}

