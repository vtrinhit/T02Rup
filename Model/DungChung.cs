﻿
namespace T02_Source_Code.Model
{
    public class DungChung
    {
        public static string HoTen,MaChucVu,MaNguoiDung;
        public static DataClasses1DataContext Db;

        public DungChung()
        {
            Db = new DataClasses1DataContext();
        }
    }
}