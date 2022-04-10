
namespace lesson5_08._04
{
    partial class Rating
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTiming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.clmnScores,
            this.clmnTiming});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Ник";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // clmnScores
            // 
            this.clmnScores.HeaderText = "Очки ";
            this.clmnScores.MinimumWidth = 6;
            this.clmnScores.Name = "clmnScores";
            this.clmnScores.ReadOnly = true;
            // 
            // clmnTiming
            // 
            this.clmnTiming.HeaderText = "Время";
            this.clmnTiming.MinimumWidth = 6;
            this.clmnTiming.Name = "clmnTiming";
            this.clmnTiming.ReadOnly = true;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(631, 390);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(168, 59);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Отстортировать по времени";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSort2
            // 
            this.btnSort2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSort2.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort2.Location = new System.Drawing.Point(456, 390);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(169, 59);
            this.btnSort2.TabIndex = 2;
            this.btnSort2.Text = "Отсортировать по очкам";
            this.btnSort2.UseVisualStyleBackColor = false;
            this.btnSort2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rating";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.Rating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTiming;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSort2;
    }
}