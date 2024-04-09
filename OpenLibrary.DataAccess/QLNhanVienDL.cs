using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class QLNhanVienDL
    {
        DataTable nhanvien;
        DataTable nhanvienkethop;
        DataHelper dt = DataHelper.GetInstance();
        public QLNhanVienDL()
        {
            nhanvienkethop = dt.FillDataTable("select * from \r\n(ChiNhanh inner join NhanVien on ChiNhanh.MachiNhanh=NhanVien.MaCN) \r\ninner join LoaiNhanvien on NhanVien.Maloainv=LoaiNhanvien.Maloai");
            nhanvien = dt.FillDataTable("select * from NhanVien");
        }
        public DataTable LayNhanvien()
        {
            nhanvienkethop = dt.FillDataTable("select * from \r\n(ChiNhanh inner join NhanVien on ChiNhanh.MachiNhanh=NhanVien.MaCN) \r\ninner join LoaiNhanvien on NhanVien.Maloainv=LoaiNhanvien.Maloai");
            nhanvien = dt.FillDataTable("select * from NhanVien");
            return nhanvienkethop;
        }
        public DataTable LayNhanvienbt()
        {
            nhanvienkethop = dt.FillDataTable("select * from \r\n(ChiNhanh inner join NhanVien on ChiNhanh.MachiNhanh=NhanVien.MaCN) \r\ninner join LoaiNhanvien on NhanVien.Maloainv=LoaiNhanvien.Maloai");
            nhanvien = dt.FillDataTable("select * from NhanVien");
            return nhanvien;
        }
        public bool ThemmoiNhanVien(DataRow dr)
        {
            try
            {
               
                dt.InsertRowtable(nhanvien, dr.ItemArray);
                dt.UpdateFromDataTableToDataBase("NhanVien", nhanvien);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;

            }
        }
        public bool XoaNhanvien(int MaNV)
        {
            try
            {
                dt.DeleteRowTable(nhanvien, "MaNV = " + MaNV);
                dt.UpdateFromDataTableToDataBase("NhanVien", nhanvien);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
        public bool SuaNhanVien(DataRow dr)
        {
            try
            {
                var s = dr.ItemArray;
                String dk = " MaNV = " + dr["MaNV"];

               dt.UpdateRowTableDungThuTuCot(nhanvien, dk, s);

                dt.UpdateFromDataTableToDataBase("NhanVien", nhanvien);
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
