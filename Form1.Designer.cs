namespace javitozhgyakorlas
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            jaratIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legitarsasagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indulasiHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utasokSzamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idotartamOraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repcsikBindingSource = new BindingSource(components);
            mentésButton = new Button();
            betöltésButton = new Button();
            érdekességekButton = new Button();
            újsorButton = new Button();
            törlésButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repcsikBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jaratIDDataGridViewTextBoxColumn, legitarsasagDataGridViewTextBoxColumn, indulasiHelyDataGridViewTextBoxColumn, celHelyDataGridViewTextBoxColumn, utasokSzamaDataGridViewTextBoxColumn, idotartamOraDataGridViewTextBoxColumn });
            dataGridView1.DataSource = repcsikBindingSource;
            dataGridView1.Location = new Point(82, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(653, 295);
            dataGridView1.TabIndex = 0;
            // 
            // jaratIDDataGridViewTextBoxColumn
            // 
            jaratIDDataGridViewTextBoxColumn.DataPropertyName = "JaratID";
            jaratIDDataGridViewTextBoxColumn.HeaderText = "JaratID";
            jaratIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            jaratIDDataGridViewTextBoxColumn.Name = "jaratIDDataGridViewTextBoxColumn";
            jaratIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // legitarsasagDataGridViewTextBoxColumn
            // 
            legitarsasagDataGridViewTextBoxColumn.DataPropertyName = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.HeaderText = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.MinimumWidth = 6;
            legitarsasagDataGridViewTextBoxColumn.Name = "legitarsasagDataGridViewTextBoxColumn";
            legitarsasagDataGridViewTextBoxColumn.Width = 125;
            // 
            // indulasiHelyDataGridViewTextBoxColumn
            // 
            indulasiHelyDataGridViewTextBoxColumn.DataPropertyName = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.HeaderText = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.MinimumWidth = 6;
            indulasiHelyDataGridViewTextBoxColumn.Name = "indulasiHelyDataGridViewTextBoxColumn";
            indulasiHelyDataGridViewTextBoxColumn.Width = 125;
            // 
            // celHelyDataGridViewTextBoxColumn
            // 
            celHelyDataGridViewTextBoxColumn.DataPropertyName = "CelHely";
            celHelyDataGridViewTextBoxColumn.HeaderText = "CelHely";
            celHelyDataGridViewTextBoxColumn.MinimumWidth = 6;
            celHelyDataGridViewTextBoxColumn.Name = "celHelyDataGridViewTextBoxColumn";
            celHelyDataGridViewTextBoxColumn.Width = 125;
            // 
            // utasokSzamaDataGridViewTextBoxColumn
            // 
            utasokSzamaDataGridViewTextBoxColumn.DataPropertyName = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.HeaderText = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            utasokSzamaDataGridViewTextBoxColumn.Name = "utasokSzamaDataGridViewTextBoxColumn";
            utasokSzamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idotartamOraDataGridViewTextBoxColumn
            // 
            idotartamOraDataGridViewTextBoxColumn.DataPropertyName = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.HeaderText = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.MinimumWidth = 6;
            idotartamOraDataGridViewTextBoxColumn.Name = "idotartamOraDataGridViewTextBoxColumn";
            idotartamOraDataGridViewTextBoxColumn.Width = 125;
            // 
            // repcsikBindingSource
            // 
            repcsikBindingSource.DataSource = typeof(Repcsik);
            // 
            // mentésButton
            // 
            mentésButton.Location = new Point(526, 35);
            mentésButton.Name = "mentésButton";
            mentésButton.Size = new Size(94, 29);
            mentésButton.TabIndex = 1;
            mentésButton.Text = "Mentés";
            mentésButton.UseVisualStyleBackColor = true;
            mentésButton.Click += mentésButton_Click;
            // 
            // betöltésButton
            // 
            betöltésButton.Location = new Point(652, 35);
            betöltésButton.Name = "betöltésButton";
            betöltésButton.Size = new Size(94, 29);
            betöltésButton.TabIndex = 2;
            betöltésButton.Text = "Betöltés";
            betöltésButton.UseVisualStyleBackColor = true;
            betöltésButton.Click += betöltésButton_Click;
            // 
            // érdekességekButton
            // 
            érdekességekButton.Location = new Point(84, 28);
            érdekességekButton.Name = "érdekességekButton";
            érdekességekButton.Size = new Size(94, 29);
            érdekességekButton.TabIndex = 3;
            érdekességekButton.Text = "Érdekességek";
            érdekességekButton.UseVisualStyleBackColor = true;
            érdekességekButton.Click += érdekességekButton_Click;
            // 
            // újsorButton
            // 
            újsorButton.Location = new Point(673, 409);
            újsorButton.Name = "újsorButton";
            újsorButton.Size = new Size(94, 29);
            újsorButton.TabIndex = 4;
            újsorButton.Text = "Új sor";
            újsorButton.UseVisualStyleBackColor = true;
            újsorButton.Click += újsorButton_Click;
            // 
            // törlésButton
            // 
            törlésButton.Location = new Point(560, 409);
            törlésButton.Name = "törlésButton";
            törlésButton.Size = new Size(94, 29);
            törlésButton.TabIndex = 5;
            törlésButton.Text = "Törlés";
            törlésButton.UseVisualStyleBackColor = true;
            törlésButton.Click += törlésButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(törlésButton);
            Controls.Add(újsorButton);
            Controls.Add(érdekességekButton);
            Controls.Add(betöltésButton);
            Controls.Add(mentésButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repcsikBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button mentésButton;
        private Button betöltésButton;
        private Button érdekességekButton;
        private Button újsorButton;
        private Button törlésButton;
        private DataGridViewTextBoxColumn jaratIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legitarsasagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indulasiHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn utasokSzamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idotartamOraDataGridViewTextBoxColumn;
        private BindingSource repcsikBindingSource;
    }
}
