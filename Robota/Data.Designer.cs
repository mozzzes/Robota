
namespace Robota
{
    partial class Data
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.obnova = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forMagazin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVugotov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Redactor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 88);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(831, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Закрить";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Cyrl 700", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form";
            // 
            // obnova
            // 
            this.obnova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.obnova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obnova.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.obnova.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obnova.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obnova.Location = new System.Drawing.Point(743, 151);
            this.obnova.Name = "obnova";
            this.obnova.Size = new System.Drawing.Size(161, 51);
            this.obnova.TabIndex = 8;
            this.obnova.Text = "Обновить";
            this.obnova.UseVisualStyleBackColor = false;
            this.obnova.Click += new System.EventHandler(this.obnova_Click);
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.download.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.download.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.download.Location = new System.Drawing.Point(743, 94);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(161, 51);
            this.download.TabIndex = 7;
            this.download.Text = "Загрузить";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.partTovar,
            this.forMagazin,
            this.dataVugotov});
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 75;
            // 
            // partTovar
            // 
            this.partTovar.HeaderText = "ПартіяТовару";
            this.partTovar.Name = "partTovar";
            this.partTovar.Width = 200;
            // 
            // forMagazin
            // 
            this.forMagazin.HeaderText = "ДляМагазину";
            this.forMagazin.Name = "forMagazin";
            this.forMagazin.Width = 200;
            // 
            // dataVugotov
            // 
            this.dataVugotov.HeaderText = "ДатаВииготовлення";
            this.dataVugotov.Name = "dataVugotov";
            this.dataVugotov.Width = 200;
            // 
            // Redactor
            // 
            this.Redactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.Redactor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Redactor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.Redactor.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redactor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Redactor.Location = new System.Drawing.Point(743, 209);
            this.Redactor.Name = "Redactor";
            this.Redactor.Size = new System.Drawing.Size(161, 51);
            this.Redactor.TabIndex = 9;
            this.Redactor.Text = "Редагувать";
            this.Redactor.UseVisualStyleBackColor = false;
            this.Redactor.Click += new System.EventHandler(this.Redactor_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 402);
            this.Controls.Add(this.Redactor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.obnova);
            this.Controls.Add(this.download);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data";
            this.Text = "Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obnova;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn partTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn forMagazin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVugotov;
        private System.Windows.Forms.Button Redactor;
    }
}