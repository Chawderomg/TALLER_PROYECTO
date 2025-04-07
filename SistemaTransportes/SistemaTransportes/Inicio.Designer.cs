namespace SistemaTransportes
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuadmin = new FontAwesome.Sharp.IconMenuItem();
            this.manuchofer = new FontAwesome.Sharp.IconMenuItem();
            this.menusupervisor = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuchofer,
            this.menuadmin,
            this.menusupervisor,
            this.menureportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 71);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(800, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Transporte";
            // 
            // menuadmin
            // 
            this.menuadmin.AutoSize = false;
            this.menuadmin.IconChar = FontAwesome.Sharp.IconChar.Bolt;
            this.menuadmin.IconColor = System.Drawing.Color.Black;
            this.menuadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuadmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuadmin.Name = "menuadmin";
            this.menuadmin.Size = new System.Drawing.Size(122, 67);
            this.menuadmin.Text = "Administrador";
            this.menuadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // manuchofer
            // 
            this.manuchofer.AutoSize = false;
            this.manuchofer.IconChar = FontAwesome.Sharp.IconChar.AddressCard ;
            this.manuchofer.IconColor = System.Drawing.Color.Black;
            this.manuchofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manuchofer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manuchofer.Name = "manuchofer";
            this.manuchofer.Size = new System.Drawing.Size(122, 67);
            this.manuchofer.Text = "Chofer/Ayudante";
            this.manuchofer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menusupervisor
            // 
            this.menusupervisor.AutoSize = false;
            this.menusupervisor.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.menusupervisor.IconColor = System.Drawing.Color.Black;
            this.menusupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusupervisor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusupervisor.Name = "menusupervisor";
            this.menusupervisor.Size = new System.Drawing.Size(122, 67);
            this.menusupervisor.Text = "Supervisor";
            this.menusupervisor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menusupervisor.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(122, 67);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem manuchofer;
        private FontAwesome.Sharp.IconMenuItem menuadmin;
        private FontAwesome.Sharp.IconMenuItem menusupervisor;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
    }
}

