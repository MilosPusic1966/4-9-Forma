
namespace _4_9_Forma
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetvrtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formeToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.obradeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formeToolStripMenuItem
            // 
            this.formeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prvaToolStripMenuItem,
            this.saFKToolStripMenuItem,
            this.grid1ToolStripMenuItem,
            this.ocenaToolStripMenuItem});
            this.formeToolStripMenuItem.Name = "formeToolStripMenuItem";
            this.formeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.formeToolStripMenuItem.Text = "Forme";
            // 
            // prvaToolStripMenuItem
            // 
            this.prvaToolStripMenuItem.Name = "prvaToolStripMenuItem";
            this.prvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prvaToolStripMenuItem.Text = "Bez FK";
            this.prvaToolStripMenuItem.Click += new System.EventHandler(this.prvaToolStripMenuItem_Click);
            // 
            // saFKToolStripMenuItem
            // 
            this.saFKToolStripMenuItem.Name = "saFKToolStripMenuItem";
            this.saFKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saFKToolStripMenuItem.Text = "Sa FK";
            this.saFKToolStripMenuItem.Click += new System.EventHandler(this.saFKToolStripMenuItem_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prviToolStripMenuItem,
            this.drugiToolStripMenuItem,
            this.treciToolStripMenuItem,
            this.cetvrtiToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // prviToolStripMenuItem
            // 
            this.prviToolStripMenuItem.Name = "prviToolStripMenuItem";
            this.prviToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.prviToolStripMenuItem.Text = "prvi";
            // 
            // drugiToolStripMenuItem
            // 
            this.drugiToolStripMenuItem.Name = "drugiToolStripMenuItem";
            this.drugiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.drugiToolStripMenuItem.Text = "drugi";
            // 
            // treciToolStripMenuItem
            // 
            this.treciToolStripMenuItem.Name = "treciToolStripMenuItem";
            this.treciToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.treciToolStripMenuItem.Text = "treci";
            // 
            // cetvrtiToolStripMenuItem
            // 
            this.cetvrtiToolStripMenuItem.Name = "cetvrtiToolStripMenuItem";
            this.cetvrtiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cetvrtiToolStripMenuItem.Text = "cetvrti";
            // 
            // obradeToolStripMenuItem
            // 
            this.obradeToolStripMenuItem.Name = "obradeToolStripMenuItem";
            this.obradeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.obradeToolStripMenuItem.Text = "Obrade";
            // 
            // grid1ToolStripMenuItem
            // 
            this.grid1ToolStripMenuItem.Name = "grid1ToolStripMenuItem";
            this.grid1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grid1ToolStripMenuItem.Text = "Grid 1";
            this.grid1ToolStripMenuItem.Click += new System.EventHandler(this.grid1ToolStripMenuItem_Click);
            // 
            // ocenaToolStripMenuItem
            // 
            this.ocenaToolStripMenuItem.Name = "ocenaToolStripMenuItem";
            this.ocenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ocenaToolStripMenuItem.Text = "Godina";
            this.ocenaToolStripMenuItem.Click += new System.EventHandler(this.ocenaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetvrtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grid1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocenaToolStripMenuItem;
    }
}