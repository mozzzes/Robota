
namespace Robota
{
    partial class RedactorData
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forMagazin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVugotov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.Button();
            this.dobav = new System.Windows.Forms.Button();
            this.obnova = new System.Windows.Forms.Button();
            this.dell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(928, 88);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(840, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Закрить";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.Enter += new System.EventHandler(this.label2_Enter);
            this.label2.Leave += new System.EventHandler(this.label2_Leave);
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.download.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.download.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.download.Location = new System.Drawing.Point(751, 110);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(161, 51);
            this.download.TabIndex = 2;
            this.download.Text = "Загрузить";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // dobav
            // 
            this.dobav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.dobav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dobav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.dobav.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobav.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dobav.Location = new System.Drawing.Point(751, 167);
            this.dobav.Name = "dobav";
            this.dobav.Size = new System.Drawing.Size(161, 51);
            this.dobav.TabIndex = 3;
            this.dobav.Text = "Добавить";
            this.dobav.UseVisualStyleBackColor = false;
            this.dobav.Click += new System.EventHandler(this.dobav_Click);
            // 
            // obnova
            // 
            this.obnova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.obnova.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obnova.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.obnova.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obnova.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obnova.Location = new System.Drawing.Point(751, 224);
            this.obnova.Name = "obnova";
            this.obnova.Size = new System.Drawing.Size(161, 51);
            this.obnova.TabIndex = 4;
            this.obnova.Text = "Обновить";
            this.obnova.UseVisualStyleBackColor = false;
            this.obnova.Click += new System.EventHandler(this.obnova_Click);
            // 
            // dell
            // 
            this.dell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.dell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.dell.Font = new System.Drawing.Font("Museo Cyrl 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dell.Location = new System.Drawing.Point(751, 283);
            this.dell.Name = "dell";
            this.dell.Size = new System.Drawing.Size(161, 51);
            this.dell.TabIndex = 5;
            this.dell.Text = "Удалить";
            this.dell.UseVisualStyleBackColor = false;
            this.dell.Click += new System.EventHandler(this.dell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повернутися назад";
            // 
            // RedactorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dell);
            this.Controls.Add(this.obnova);
            this.Controls.Add(this.dobav);
            this.Controls.Add(this.download);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RedactorData";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button dobav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn partTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn forMagazin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVugotov;
        private System.Windows.Forms.Button obnova;
        private System.Windows.Forms.Button dell;
        private System.Windows.Forms.Label label4;
    }
}

