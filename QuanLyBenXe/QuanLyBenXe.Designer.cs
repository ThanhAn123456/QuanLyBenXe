
namespace QuanLyBenXe
{
    partial class QuanLyBenXe
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
            this.cbQuanLyBenXe = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQuanLyBenXe = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenBenXe = new System.Windows.Forms.TextBox();
            this.txtMaBenXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDbToXML = new System.Windows.Forms.Button();
            this.btnXmlToDb = new System.Windows.Forms.Button();
            this.showFileXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyBenXe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbQuanLyBenXe
            // 
            this.cbQuanLyBenXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuanLyBenXe.FormattingEnabled = true;
            this.cbQuanLyBenXe.Location = new System.Drawing.Point(532, 330);
            this.cbQuanLyBenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbQuanLyBenXe.Name = "cbQuanLyBenXe";
            this.cbQuanLyBenXe.Size = new System.Drawing.Size(178, 33);
            this.cbQuanLyBenXe.TabIndex = 29;
            this.cbQuanLyBenXe.SelectedIndexChanged += new System.EventHandler(this.cbQuanLyBenXe_SelectedIndexChanged);
            this.cbQuanLyBenXe.SelectedValueChanged += new System.EventHandler(this.cbQuanLyBenXe_SelectedValueChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(740, 267);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 33);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(532, 268);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(178, 34);
            this.txtTimKiem.TabIndex = 27;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(468, 62);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 35);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(643, 123);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 35);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(468, 123);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 35);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(643, 62);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 35);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQuanLyBenXe
            // 
            this.dgvQuanLyBenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyBenXe.Location = new System.Drawing.Point(37, 256);
            this.dgvQuanLyBenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLyBenXe.Name = "dgvQuanLyBenXe";
            this.dgvQuanLyBenXe.RowHeadersWidth = 62;
            this.dgvQuanLyBenXe.RowTemplate.Height = 28;
            this.dgvQuanLyBenXe.Size = new System.Drawing.Size(464, 168);
            this.dgvQuanLyBenXe.TabIndex = 22;
            this.dgvQuanLyBenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyBenXe_CellClick);
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(173, 151);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(203, 34);
            this.txtDiaChi.TabIndex = 21;
            // 
            // txtTenBenXe
            // 
            this.txtTenBenXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenXe.Location = new System.Drawing.Point(173, 108);
            this.txtTenBenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBenXe.Name = "txtTenBenXe";
            this.txtTenBenXe.Size = new System.Drawing.Size(203, 34);
            this.txtTenBenXe.TabIndex = 20;
            // 
            // txtMaBenXe
            // 
            this.txtMaBenXe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenXe.Location = new System.Drawing.Point(173, 65);
            this.txtMaBenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBenXe.Name = "txtMaBenXe";
            this.txtMaBenXe.Size = new System.Drawing.Size(203, 34);
            this.txtMaBenXe.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên bến xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã bến xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(323, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý bến xe";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(173, 200);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(203, 34);
            this.txtSDT.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số điện thoại:";
            // 
            // btnDbToXML
            // 
            this.btnDbToXML.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbToXML.Location = new System.Drawing.Point(468, 193);
            this.btnDbToXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDbToXML.Name = "btnDbToXML";
            this.btnDbToXML.Size = new System.Drawing.Size(121, 35);
            this.btnDbToXML.TabIndex = 32;
            this.btnDbToXML.Text = "DbToXml";
            this.btnDbToXML.UseVisualStyleBackColor = true;
            this.btnDbToXML.Click += new System.EventHandler(this.btnDbToXML_Click);
            // 
            // btnXmlToDb
            // 
            this.btnXmlToDb.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlToDb.Location = new System.Drawing.Point(643, 193);
            this.btnXmlToDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXmlToDb.Name = "btnXmlToDb";
            this.btnXmlToDb.Size = new System.Drawing.Size(134, 35);
            this.btnXmlToDb.TabIndex = 33;
            this.btnXmlToDb.Text = "XmlToDb";
            this.btnXmlToDb.UseVisualStyleBackColor = true;
            this.btnXmlToDb.Click += new System.EventHandler(this.btnXmlToDb_Click);
            // 
            // showFileXml
            // 
            this.showFileXml.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFileXml.Location = new System.Drawing.Point(532, 389);
            this.showFileXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showFileXml.Name = "showFileXml";
            this.showFileXml.Size = new System.Drawing.Size(178, 35);
            this.showFileXml.TabIndex = 34;
            this.showFileXml.Text = "Xem file Xml";
            this.showFileXml.UseVisualStyleBackColor = true;
            this.showFileXml.Click += new System.EventHandler(this.showFileXml_Click);
            // 
            // QuanLyBenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(872, 446);
            this.Controls.Add(this.showFileXml);
            this.Controls.Add(this.btnXmlToDb);
            this.Controls.Add(this.btnDbToXML);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbQuanLyBenXe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQuanLyBenXe);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenBenXe);
            this.Controls.Add(this.txtMaBenXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyBenXe";
            this.Text = "QuanLyBenXe";
            this.Load += new System.EventHandler(this.QuanLyBenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyBenXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuanLyBenXe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQuanLyBenXe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenBenXe;
        private System.Windows.Forms.TextBox txtMaBenXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDbToXML;
        private System.Windows.Forms.Button btnXmlToDb;
        private System.Windows.Forms.Button showFileXml;
    }
}