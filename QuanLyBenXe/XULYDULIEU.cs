using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                con.ConnectionString = @"Data Source=LAPTOP-4QICIB15\SQLEXPRESS;Initial Catalog=QuanLyBenXeKhach;Integrated Security=True";
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
    }
}
