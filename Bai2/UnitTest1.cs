using System.Text.RegularExpressions;

namespace Bai2
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
           
        }
        //1<=id<=20
        //4<=MaSV.length<=6
        //2<=HoTen.length<=20
        //4<=MaLop<=6
        //4<=TenLop<=20
        public List<SinhVien> _sinhVienPolys = new List<SinhVien>();
        [Test]
        [TestCase("1","Ph01","Trang","SD01","Net104")]
        [TestCase("20", "Ph02", "Cuong", "SD11", "Net1041@")]
        [TestCase("0", "Ph03", "My", "SD01", "Net104")]
        [TestCase("21", "Ph02157", "Cuong", "SD11", "Net1041")]
        [TestCase("2", "Ph03", "Cuong", "SD11", "Net1041")]
        [TestCase("5", "Ph05", "Hung", "SD01", "Net104")]
        [TestCase("6", "Ph06", "Hai5", "SD3", "Net1041")]
        [TestCase("7", "Ph07", "Tuan", "SD01", "Net104")]
        [TestCase("8", "Ph08", "Mai", "SD11", "Net1041")]
        [TestCase("8", "Ph09", "Huy", "SD11", "Net1041")]

        public void Test1_Add(string id, string maSV, string hoTen, string maLop, string tenLop)
        {
            var kt = true;
            var errorMessage = string.Empty;
            if (!RegexKiTuDacBiet(tenLop))
            {
                throw new Exception("Tên lớp không được có kí tự đặc biệt. ");

            }
            if (maSV.Length < 4 || maSV.Length > 6)
            {
                kt = false;
                errorMessage += "Mã sinh viên chỉ được từ 4 đến 6 kí tự. ";
            }
            if (Convert.ToInt32(id)<1 || Convert.ToInt32(id) > 20)
            {
                kt = false;
                errorMessage += "Id chỉ được từ 1 đến 20. ";
            }
            if (maLop.Length < 4 || maLop.Length > 6)
            {
                kt = false;
                errorMessage += "Mã lớp chỉ được từ 4 đến 7 kí tự. ";
            }
            if (CheckExist(id) != null)
            {
                kt = false;
                errorMessage += "Trùng Id. ";
            }
            if (CheckExistMa(maSV) != null)
            {
                kt = false;
                errorMessage += "Trùng mã sinh viên. ";
            }
            if (!RegexHoTen(hoTen))
            {
                kt = false;
                errorMessage += "Họ tên sai định dạng. ";
            }
            if (kt)
            {
                _sinhVienPolys.Add(new SinhVien(id, maSV, hoTen, maLop, tenLop));
            }
            else
                Console.WriteLine(errorMessage);
            Assert.That(kt,Is.EqualTo(true));
        }
        [Test]
        [TestCase("Ph1")]
        [TestCase("Ph05")]
        [TestCase("ph05")]
        [TestCase("ph006")]
        [TestCase("PH07")]
        public void Test2_FindByMsv(string maSV) { 
            var obj = _sinhVienPolys.FirstOrDefault(x => x.MaSV.ToLower() == maSV.ToLower());
            Assert.That(obj!=null, Is.EqualTo(true));
        }
               
        private bool RegexKiTuDacBiet(string str)
        {
            string regex = @"^[a-zA-Z0-9]*$";
            return Regex.IsMatch(str, regex);
        }
        private SinhVien? CheckExist(string id)
        {
            return _sinhVienPolys.FirstOrDefault(x => x.Id == id);

        }
        private bool RegexHoTen(string str) {
            string regex = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(str, regex);
        }
        private SinhVien? CheckExistMa(string maSV)
        {
            return _sinhVienPolys.FirstOrDefault(x => x.MaSV.ToLower() == maSV.ToLower());

        }
    }
}