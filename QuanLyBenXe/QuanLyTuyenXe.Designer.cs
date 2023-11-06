
namespace QuanLyBenXe
{
    partial class QuanLyTuyenXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTuyenXe = new System.Windows.Forms.TextBox();
            this.txtDiemDi = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.dgvQuanLyTuyenXe = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbQuanLyTuyenXe = new System.Windows.Forms.ComboBox();
            this.btnDbToXml = new System.Windows.Forms.Button();
            this.btnXmlToDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTuyenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tuyến xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tuyến xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm đi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm đến:";
            // 
            // txtMaTuyenXe
            // 
            this.txtMaTuyenXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTuyenXe.Location = new System.Drawing.Point(220, 90);
            this.txtMaTuyenXe.Name = "txtMaTuyenXe";
            this.txtMaTuyenXe.Size = new System.Drawing.Size(228, 40);
            this.txtMaTuyenXe.TabIndex = 4;
            this.txtMaTuyenXe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDi.Location = new System.Drawing.Point(220, 144);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.Size = new System.Drawing.Size(228, 40);
            this.txtDiemDi.TabIndex = 5;
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDen.Location = new System.Drawing.Point(220, 198);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(228, 40);
            this.txtDiemDen.TabIndex = 6;
            // 
            // dgvQuanLyTuyenXe
            // 
            this.dgvQuanLyTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyTuyenXe.Location = new System.Drawing.Point(50, 278);
            this.dgvQuanLyTuyenXe.Name = "dgvQuanLyTuyenXe";
            this.dgvQuanLyTuyenXe.RowHeadersWidth = 62;
            this.dgvQuanLyTuyenXe.RowTemplate.Height = 28;
            this.dgvQuanLyTuyenXe.Size = new System.Drawing.Size(522, 210);
            this.dgvQuanLyTuyenXe.TabIndex = 7;
            this.dgvQuanLyTuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyTuyenXe_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(748, 86);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 44);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(552, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(136, 44);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(748, 141);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 44);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(552, 86);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(136, 44);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(615, 290);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 40);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(852, 277);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 41);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbQuanLyTuyenXe
            // 
            this.cbQuanLyTuyenXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuanLyTuyenXe.FormattingEnabled = true;
            this.cbQuanLyTuyenXe.Location = new System.Drawing.Point(615, 372);
            this.cbQuanLyTuyenXe.Name = "cbQuanLyTuyenXe";
            this.cbQuanLyTuyenXe.Size = new System.Drawing.Size(200, 40);
            this.cbQuanLyTuyenXe.TabIndex = 14;
            this.cbQuanLyTuyenXe.SelectedIndexChanged += new System.EventHandler(this.cbQuanLyTuyenXe_SelectedIndexChanged);
            // 
            // btnDbToXml
            // 
            this.btnDbToXml.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbToXml.Location = new System.Drawing.Point(552, 206);
            this.btnDbToXml.Name = "btnDbToXml";
            this.btnDbToXml.Size = new System.Drawing.Size(149, 44);
            this.btnDbToXml.TabIndex = 15;
            this.btnDbToXml.Text = "DbToXml";
            this.btnDbToXml.UseVisualStyleBackColor = true;
            this.btnDbToXml.Click += new System.EventHandler(this.btnDbToXml_Click);
            // 
            // btnXmlToDb
            // 
            this.btnXmlToDb.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlToDb.Location = new System.Drawing.Point(748, 206);
            this.btnXmlToDb.Name = "btnXmlToDb";
            this.btnXmlToDb.Size = new System.Drawing.Size(160, 44);
            this.btnXmlToDb.TabIndex = 16;
            this.btnXmlToDb.Text = "XmlToDB";
            this.btnXmlToDb.UseVisualStyleBackColor = true;
            this.btnXmlToDb.Click += new System.EventHandler(this.btnXmlToDb_Click);
            // 
            // QuanLyTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1019, 500);
            this.Controls.Add(this.btnXmlToDb);
            this.Controls.Add(this.btnDbToXml);
            this.Controls.Add(this.cbQuanLyTuyenXe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQuanLyTuyenXe);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.txtDiemDi);
            this.Controls.Add(this.txtMaTuyenXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyTuyenXe";
            this.Text = "QuanLyTuyenXe";
            this.Load += new System.EventHandler(this.QuanLyTuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTuyenXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTuyenXe;
        private System.Windows.Forms.TextBox txtDiemDi;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.DataGridView dgvQuanLyTuyenXe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbQuanLyTuyenXe;
        private System.Windows.Forms.Button btnDbToXml;
        private System.Windows.Forms.Button btnXmlToDb;
    }
}