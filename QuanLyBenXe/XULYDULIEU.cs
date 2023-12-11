using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-BVPV5HU;Initial Catalog=QuanLyBenXeKhach3;Integrated Security=True";
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        private void MoKetNoi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getTable(String SQL)
        {
            DataTable tb = null;
            try
            {
                this.MoKetNoi();
                SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
                tb = new DataTable();
                adp.Fill(tb);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                this.DongKetNoi();
            }
            return tb;
        }
        public DataTable getTable(String nameprocedurce, SqlParameter[] pr)
        {
            DataTable tb = null;
            try
            {
                this.MoKetNoi();
                tb = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameprocedurce;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(tb);
            }
            catch (Exception ex)
            { }
            finally
            {
                this.DongKetNoi();
            }
            return tb;
        }
        public void getDataSet(ref DataSet ds, String SQL)
        {
            ds.Tables.Add(this.getTable(SQL));
        }
        public void getDataSet(ref DataSet ds, String nameprocedurce, SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedurce, pr));
        }
        /// <summary>
        /// Đối tượng command thực thi lệnh SQL 
        /// </summary>
        /// <param name="SQL">SQL:insert, update, Delete</param>
        /// <returns>K(<>0, =0) trong đó <>0 thành công và =0 lỗi khi thực thi </returns>
        public int ExeCute(string SQL)
        {
            int k = 0; ;
            try
            {
                this.MoKetNoi();
                SqlCommand cmd = new SqlCommand(SQL, this.con);
                k = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                this.DongKetNoi();
            }
            return k;
        }
        public int ExeCute(String nameprocedurce, SqlParameter[] pr)
        {
            int k = 0;
            try
            {
                this.MoKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameprocedurce;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                k = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                this.DongKetNoi();
            }
            return k;
        }

        public void ViewXML(string path)
        {

            // Xem tệp XML, HTML trong trình duyệt 

            var fullpath = Path.GetFullPath(path);
            Process.Start("Explorer.exe", fullpath);

        }

        public void ExeCute2(string SQL)
        {
         
            try
            {
                this.MoKetNoi();
                SqlCommand cmd = new SqlCommand(SQL, this.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                this.DongKetNoi();
            }
        }

        public void capNhatTungBang(string path,string tenBang)
        {
            string duongdan = path;
            DataTable dt = HienThi(duongdan);
            if (dt != null)
            {
                Console.WriteLine(path);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine("FDd");
                    string sql = "insert into " + tenBang + " values(";
                    for (int j = 0; j < dt.Columns.Count - 1; j++)
                    {
                        MessageBox.Show(dt.Rows[i][j].ToString());
                        sql += "N'" + dt.Rows[i][j].ToString().Trim() + "', ";
                    }
                    //sql += "N'" + dt.Rows[i][dt.Columns.Count - 1].ToString().Trim() + "'";
                    sql += "N'" + dt.Rows[i][dt.Columns.Count - 1].ToString().Trim() + "'";
                    sql += ")";
                    MessageBox.Show(sql);
                    int k = ExeCute(sql);
                }
            }
        }

        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = file;
            if (File.Exists(FilePath))
            {
                Console.WriteLine(FilePath);
                DataSet ds = new DataSet();
                System.IO.FileStream fsReadXML = new System.IO.FileStream(FilePath, System.IO.FileMode.Open);
                ds.ReadXml(fsReadXML);
                DataView dv = new DataView(ds.Tables[0]);
                dt = dv.Table;
                fsReadXML.Close();
                Console.WriteLine(dt.Rows.Count);
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
                return null;
            }

            return dt;
        }

    }
}
