namespace LibraryDatabase
{
    partial class Main
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
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilm
            // 
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Image = global::LibraryDatabase.Properties.Resources.film;
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilm.Location = new System.Drawing.Point(260, 68);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(85, 85);
            this.btnFilm.TabIndex = 2;
            this.btnFilm.Text = "Film";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilm.UseVisualStyleBackColor = true;
            // 
            // btnMusic
            // 
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.Image = global::LibraryDatabase.Properties.Resources.music;
            this.btnMusic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusic.Location = new System.Drawing.Point(146, 68);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(85, 85);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.Text = "Music";
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Image = global::LibraryDatabase.Properties.Resources.bookshelf;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBook.Location = new System.Drawing.Point(33, 68);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(85, 85);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.libraryToolStripMenuItem.Text = "Biblioteca";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookToolStripMenuItem.Text = "Filmes";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmToolStripMenuItem.Text = "Livros";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musicToolStripMenuItem.Text = "Músicas";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Library Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    }
}

