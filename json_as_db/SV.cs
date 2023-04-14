using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace db_Json
{
    public class SV
    {
        public string ten;
        public int tuoi;
        public List<float> diem;

        private const string JSON_DB = "DB.JSON";
        public SV() { }
        public SV(string ten, int tuoi, List<float> diem)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diem = diem;
        }
        //clone
        public SV(SV sv)
        {
            this.ten = sv.ten;
            this.tuoi = sv.tuoi;
            this.diem = sv.diem;
        }
        public void LoadDB()
        {
            string json = File.ReadAllText(JSON_DB);
            SV t = JsonConvert.DeserializeObject<SV>(json);
            this.ten = t.ten;
            this.tuoi = t.tuoi;
            this.diem = t.diem;
        }

        public static List<float> Gen3Diem(string d1, string d2, string d3)
        {
            List<float> diem = new List<float>();
            diem.Add(float.Parse(d1));
            diem.Add(float.Parse(d2));
            diem.Add(float.Parse(d3));
            return diem;
        }
        public void SaveDB()
        {
            string json = this.ToJson();
            File.WriteAllText(JSON_DB, json);
        }
        public String ToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
