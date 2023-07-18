namespace FrontEscritorio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1=new DataGridView();
            comboBox1=new ComboBox();
            label1=new Label();
            label2=new Label();
            dataGridView3=new DataGridView();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.AllowUserToDeleteRows=false;
            dataGridViewCellStyle1.BackColor=SystemColors.ControlLight;
            dataGridViewCellStyle1.Font=new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor=Color.Black;
            dataGridViewCellStyle1.SelectionBackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle1.SelectionForeColor=Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle1;
            dataGridView1.Anchor=AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor=Color.White;
            dataGridView1.CellBorderStyle=DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle2.Font=new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor=Color.White;
            dataGridViewCellStyle2.SelectionBackColor=Color.White;
            dataGridViewCellStyle2.SelectionForeColor=SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles=false;
            dataGridView1.GridColor=SystemColors.WindowText;
            dataGridView1.Location=new Point(1, 285);
            dataGridView1.Name="dataGridView1";
            dataGridView1.ReadOnly=true;
            dataGridView1.RowHeadersBorderStyle=DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible=false;
            dataGridViewCellStyle3.BackColor=Color.White;
            dataGridViewCellStyle3.Font=new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor=Color.Black;
            dataGridViewCellStyle3.SelectionBackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle3.SelectionForeColor=Color.White;
            dataGridView1.RowsDefaultCellStyle=dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size=new Size(1088, 250);
            dataGridView1.TabIndex=0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
            comboBox1.Font=new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(12, 177);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(308, 31);
            comboBox1.TabIndex=1;
            comboBox1.Text="Selecciona una opcion";
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            label1.AutoSize=true;
            label1.BackColor=Color.FromArgb(35, 78, 129);
            label1.Font=new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=Color.White;
            label1.Location=new Point(12, 132);
            label1.Name="label1";
            label1.Size=new Size(144, 27);
            label1.TabIndex=2;
            label1.Text="Orderar por:";
            // 
            // label2
            // 
            label2.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            label2.AutoSize=true;
            label2.Font=new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(12, 77);
            label2.Name="label2";
            label2.Size=new Size(0, 31);
            label2.TabIndex=3;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows=false;
            dataGridView3.AllowUserToDeleteRows=false;
            dataGridViewCellStyle4.BackColor=SystemColors.ControlLight;
            dataGridViewCellStyle4.Font=new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor=Color.Black;
            dataGridViewCellStyle4.SelectionBackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle4.SelectionForeColor=Color.White;
            dataGridView3.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle4;
            dataGridView3.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor=Color.White;
            dataGridView3.BorderStyle=BorderStyle.None;
            dataGridView3.CellBorderStyle=DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment=DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle5.Font=new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor=Color.White;
            dataGridViewCellStyle5.SelectionBackColor=Color.White;
            dataGridViewCellStyle5.SelectionForeColor=SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode=DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle5;
            dataGridView3.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EnableHeadersVisualStyles=false;
            dataGridView3.GridColor=SystemColors.WindowText;
            dataGridView3.Location=new Point(541, 110);
            dataGridView3.Name="dataGridView3";
            dataGridView3.ReadOnly=true;
            dataGridView3.RowHeadersBorderStyle=DataGridViewHeaderBorderStyle.Single;
            dataGridView3.RowHeadersVisible=false;
            dataGridViewCellStyle6.BackColor=Color.White;
            dataGridViewCellStyle6.Font=new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor=Color.Black;
            dataGridViewCellStyle6.SelectionBackColor=Color.FromArgb(35, 78, 129);
            dataGridViewCellStyle6.SelectionForeColor=Color.White;
            dataGridView3.RowsDefaultCellStyle=dataGridViewCellStyle6;
            dataGridView3.RowTemplate.Height=25;
            dataGridView3.SelectionMode=DataGridViewSelectionMode.CellSelect;
            dataGridView3.Size=new Size(548, 162);
            dataGridView3.TabIndex=5;
            // 
            // label3
            // 
            label3.Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
            label3.AutoSize=true;
            label3.Font=new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(12, 235);
            label3.Name="label3";
            label3.Size=new Size(0, 31);
            label3.TabIndex=6;
            // 
            // label4
            // 
            label4.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            label4.AutoSize=true;
            label4.Font=new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(541, 66);
            label4.Name="label4";
            label4.Size=new Size(0, 31);
            label4.TabIndex=7;
            // 
            // label5
            // 
            label5.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            label5.AutoSize=true;
            label5.BackColor=Color.FromArgb(35, 78, 129);
            label5.Font=new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor=Color.White;
            label5.Location=new Point(381, 0);
            label5.Name="label5";
            label5.RightToLeft=RightToLeft.No;
            label5.Size=new Size(316, 42);
            label5.TabIndex=8;
            label5.Text="Gestion de las ventas";
            label5.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(1091, 533);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView3;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}