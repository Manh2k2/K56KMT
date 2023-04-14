using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

/* 
 * code by Đỗ Duy Cốp
 * cho lớp: 56kmt
 * ngày: 14.04.2023
 * -------------------
 * class SV
 *   có 3 trường thông tin, trường thứ 3 là mảng
 * dùng thư viện: Newtonsoft.Json.dll
 * tham khảo tại trang: https://www.newtonsoft.com/json
 * cài đặt thư viện: vào Menu Tools / Nuget Package Panager / Package Panager Console
 * chọn đúng proect ở trong cửa sổ Package Panager Console rồi gõ lệnh:
 * Install-Package Newtonsoft.Json
 * 
 * thư viện giúp chuyển 1 đối tượng (đã khai báo class) thành json string
 * và ngược lại: từ json string thành đối tượng với đầy đủ giá trị các thuộc tính
 * 
 * class này sử dụng text file để lưu trữ chuỗi json
 * thêm hàm để đưa các trường thông tin của đối tượng 'this' -> string json
 * và đưa json string trong text file thành object
 */

namespace db_Json
{
    public class SV
    {
        public string ten;
        public int tuoi;
        public List<float> diem;

        //đường dẫn text file dùng để lưu chuỗi json
        private const string JSON_DB = "DB.JSON";
        public SV() { } //hàm tạo ko tham số

        //hàm tạo 3 tham số
        public SV(string ten, int tuoi, List<float> diem)
        {
            Copy(ten, tuoi, diem);  
        }

        //hàm copy nội dung
        public void Copy(string ten, int tuoi, List<float> diem)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diem = diem;
        }

        //hàm clone đối tượng
        public SV Clone(SV sv)
        {
            //clone là tạo bản sao, giống value nhưng là obj khác -> nên phải dùng NEW
            return new SV(sv.ten, sv.tuoi, sv.diem);
        }
        public void LoadDB()
        {
            string json = File.ReadAllText(JSON_DB);        //đọc được chuỗi json trong text file
            SV t = JsonConvert.DeserializeObject<SV>(json); //chuyển json này thành đối tượng t
            Clone(t); //copy các giá trị đọc được từ json -> t -> this
        }
        private static float GetFloat(string fstr)
        {
            try
            {
                //chuyển chuỗi biểu diễn số thực sang số thực
                return float.Parse(fstr);
            }
            catch
            {
                //khi có lỗi thì quy ra số 0
                return 0.0f;
            }
        }
        //hàm chuyển 3 chuỗi vào mảng có 3 điểm
        public static List<float> Gen3Diem(string f1, string f2, string f3)
        {
            //tạo list  mới
            List<float> listFloat = new List<float>();
            listFloat.Add(GetFloat(f1)); //chuyển đổi f1 str -> float rồi add vào list
            listFloat.Add(GetFloat(f2));
            listFloat.Add(GetFloat(f3));
            return listFloat;
        }
        public void SaveDB()
        {
            string json = this.ToJson();  //this -> json string
            File.WriteAllText(JSON_DB, json); //save string json to text file
        }
        public String ToJson()
        {
            //chuyển đối tượng hiện tại thành json string
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
