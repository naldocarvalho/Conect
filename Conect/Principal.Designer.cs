namespace Conect
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endpointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milleniumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketPlacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hub2bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            resources.ApplyResources(this.mnuPrincipal, "mnuPrincipal");
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.eRPsToolStripMenuItem,
            this.marketPlacesToolStripMenuItem});
            this.mnuPrincipal.Name = "mnuPrincipal";
            // 
            // configuraçõesToolStripMenuItem
            // 
            resources.ApplyResources(this.configuraçõesToolStripMenuItem, "configuraçõesToolStripMenuItem");
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endpointsToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            // 
            // endpointsToolStripMenuItem
            // 
            resources.ApplyResources(this.endpointsToolStripMenuItem, "endpointsToolStripMenuItem");
            this.endpointsToolStripMenuItem.Name = "endpointsToolStripMenuItem";
            // 
            // serviçosToolStripMenuItem
            // 
            resources.ApplyResources(this.serviçosToolStripMenuItem, "serviçosToolStripMenuItem");
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            // 
            // eRPsToolStripMenuItem
            // 
            resources.ApplyResources(this.eRPsToolStripMenuItem, "eRPsToolStripMenuItem");
            this.eRPsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winthorToolStripMenuItem,
            this.milleniumToolStripMenuItem});
            this.eRPsToolStripMenuItem.Name = "eRPsToolStripMenuItem";
            // 
            // winthorToolStripMenuItem
            // 
            resources.ApplyResources(this.winthorToolStripMenuItem, "winthorToolStripMenuItem");
            this.winthorToolStripMenuItem.Name = "winthorToolStripMenuItem";
            // 
            // milleniumToolStripMenuItem
            // 
            resources.ApplyResources(this.milleniumToolStripMenuItem, "milleniumToolStripMenuItem");
            this.milleniumToolStripMenuItem.Name = "milleniumToolStripMenuItem";
            // 
            // marketPlacesToolStripMenuItem
            // 
            resources.ApplyResources(this.marketPlacesToolStripMenuItem, "marketPlacesToolStripMenuItem");
            this.marketPlacesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleapToolStripMenuItem,
            this.hub2bToolStripMenuItem});
            this.marketPlacesToolStripMenuItem.Name = "marketPlacesToolStripMenuItem";
            // 
            // aleapToolStripMenuItem
            // 
            resources.ApplyResources(this.aleapToolStripMenuItem, "aleapToolStripMenuItem");
            this.aleapToolStripMenuItem.Name = "aleapToolStripMenuItem";
            // 
            // hub2bToolStripMenuItem
            // 
            resources.ApplyResources(this.hub2bToolStripMenuItem, "hub2bToolStripMenuItem");
            this.hub2bToolStripMenuItem.Name = "hub2bToolStripMenuItem";
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endpointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milleniumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketPlacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hub2bToolStripMenuItem;
    }
}

