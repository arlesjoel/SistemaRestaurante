namespace SistemaRestaurante
{
    partial class FRM_Menu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            LblMenu = new Label();
            GridMenu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(GridMenu);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 644);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblMenu);
            panel2.Location = new Point(10, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1403, 131);
            panel2.TabIndex = 1;
            // 
            // LblMenu
            // 
            LblMenu.AutoSize = true;
            LblMenu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMenu.Location = new Point(345, 13);
            LblMenu.Name = "LblMenu";
            LblMenu.Size = new Size(685, 96);
            LblMenu.TabIndex = 0;
            LblMenu.Text = "Menú en Ambrosía";
            // 
            // GridMenu
            // 
            GridMenu.BorderStyle = BorderStyle.Fixed3D;
            GridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            GridMenu.DefaultCellStyle = dataGridViewCellStyle1;
            GridMenu.Location = new Point(10, 156);
            GridMenu.Name = "GridMenu";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gold;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            GridMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GridMenu.RowHeadersWidth = 62;
            GridMenu.Size = new Size(521, 408);
            GridMenu.TabIndex = 0;
            GridMenu.CellContentClick += GridMenu_CellContentClick;
            // 
            // FRM_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 656);
            Controls.Add(panel1);
            Name = "FRM_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Menu";
            Load += FRM_Menu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView GridMenu;
        private Panel panel2;
        private Label LblMenu;
    }
}