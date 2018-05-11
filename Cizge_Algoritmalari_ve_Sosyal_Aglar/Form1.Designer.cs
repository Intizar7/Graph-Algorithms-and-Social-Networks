namespace Cizge_Algoritmalari_ve_Sosyal_Aglar
{
    partial class Form1
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
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btnGenislikOncelikli = new System.Windows.Forms.Button();
            this.btnPrimAlgoritmasi = new System.Windows.Forms.Button();
            this.btnKruskalAlgoritmasi = new System.Windows.Forms.Button();
            this.btnEdvordKarpAlgoritmasi = new System.Windows.Forms.Button();
            this.btnForkFulkersonAlgoritmasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(12, 42);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(156, 23);
            this.btnDijkstra.TabIndex = 0;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btnGenislikOncelikli
            // 
            this.btnGenislikOncelikli.Location = new System.Drawing.Point(12, 71);
            this.btnGenislikOncelikli.Name = "btnGenislikOncelikli";
            this.btnGenislikOncelikli.Size = new System.Drawing.Size(156, 23);
            this.btnGenislikOncelikli.TabIndex = 1;
            this.btnGenislikOncelikli.Text = "Genişlik Öncelikli";
            this.btnGenislikOncelikli.UseVisualStyleBackColor = true;
            this.btnGenislikOncelikli.Click += new System.EventHandler(this.btnGenislikOncelikli_Click);
            // 
            // btnPrimAlgoritmasi
            // 
            this.btnPrimAlgoritmasi.Location = new System.Drawing.Point(13, 101);
            this.btnPrimAlgoritmasi.Name = "btnPrimAlgoritmasi";
            this.btnPrimAlgoritmasi.Size = new System.Drawing.Size(155, 23);
            this.btnPrimAlgoritmasi.TabIndex = 2;
            this.btnPrimAlgoritmasi.Text = "Prim Algoritmasi";
            this.btnPrimAlgoritmasi.UseVisualStyleBackColor = true;
            this.btnPrimAlgoritmasi.Click += new System.EventHandler(this.btnPrimAlgoritmasi_Click);
            // 
            // btnKruskalAlgoritmasi
            // 
            this.btnKruskalAlgoritmasi.Location = new System.Drawing.Point(13, 131);
            this.btnKruskalAlgoritmasi.Name = "btnKruskalAlgoritmasi";
            this.btnKruskalAlgoritmasi.Size = new System.Drawing.Size(155, 23);
            this.btnKruskalAlgoritmasi.TabIndex = 3;
            this.btnKruskalAlgoritmasi.Text = "Kruskal Algoritması";
            this.btnKruskalAlgoritmasi.UseVisualStyleBackColor = true;
            // 
            // btnEdvordKarpAlgoritmasi
            // 
            this.btnEdvordKarpAlgoritmasi.Location = new System.Drawing.Point(13, 161);
            this.btnEdvordKarpAlgoritmasi.Name = "btnEdvordKarpAlgoritmasi";
            this.btnEdvordKarpAlgoritmasi.Size = new System.Drawing.Size(155, 23);
            this.btnEdvordKarpAlgoritmasi.TabIndex = 4;
            this.btnEdvordKarpAlgoritmasi.Text = "Edmonds Karp Algoritmasi";
            this.btnEdvordKarpAlgoritmasi.UseVisualStyleBackColor = true;
            // 
            // btnForkFulkersonAlgoritmasi
            // 
            this.btnForkFulkersonAlgoritmasi.Location = new System.Drawing.Point(13, 191);
            this.btnForkFulkersonAlgoritmasi.Name = "btnForkFulkersonAlgoritmasi";
            this.btnForkFulkersonAlgoritmasi.Size = new System.Drawing.Size(155, 23);
            this.btnForkFulkersonAlgoritmasi.TabIndex = 5;
            this.btnForkFulkersonAlgoritmasi.Text = "Fork Fulkerson Algoritmasi";
            this.btnForkFulkersonAlgoritmasi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 473);
            this.Controls.Add(this.btnForkFulkersonAlgoritmasi);
            this.Controls.Add(this.btnEdvordKarpAlgoritmasi);
            this.Controls.Add(this.btnKruskalAlgoritmasi);
            this.Controls.Add(this.btnPrimAlgoritmasi);
            this.Controls.Add(this.btnGenislikOncelikli);
            this.Controls.Add(this.btnDijkstra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnGenislikOncelikli;
        private System.Windows.Forms.Button btnPrimAlgoritmasi;
        private System.Windows.Forms.Button btnKruskalAlgoritmasi;
        private System.Windows.Forms.Button btnEdvordKarpAlgoritmasi;
        private System.Windows.Forms.Button btnForkFulkersonAlgoritmasi;
    }
}

