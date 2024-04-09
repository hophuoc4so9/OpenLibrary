using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
namespace OpenLibrary.DataAccess
{
    public class QLChuyenNganhDL
    {
        DataTable tblChuyenNganh;
        DataHelper dt = DataHelper.GetInstance();
        public QLChuyenNganhDL()
        {
            tblChuyenNganh = dt.FillDataTable("select * from ChuyenNganh");
        }
        public DataTable Laychuyennganh()
        {
            tblChuyenNganh = dt.FillDataTable("select * from ChuyenNganh");
            return tblChuyenNganh;
        }
        public bool Themmoichuyennganh(String tencn)
        {
            try
            {
                dt.InsertRowtable(tblChuyenNganh, null, tencn);
                dt.UpdateFromDataTableToDataBase("ChuyenNganh", tblChuyenNganh);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                return false;

              }
        }
        public bool XoaChuyenNganh(String macn)
        {
            try
            {
                dt.DeleteRowTable(tblChuyenNganh,  "MaChuyenNganh = " +  macn);
                dt.UpdateFromDataTableToDataBase("ChuyenNganh", tblChuyenNganh);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
        public bool Suachuyennganh(String tencn,String macn)
        {
            try
            {
                String dk = " MaChuyenNganh = " + macn;
                
                dt.UpdateRowTable(tblChuyenNganh, dk, "TenChuyenNganh",tencn);

                dt.UpdateFromDataTableToDataBase("ChuyenNganh", tblChuyenNganh);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
    }
}
