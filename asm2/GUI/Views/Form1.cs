using asm2.BLL.Services;
using asm2.DAL.DomainClass;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace asm2
{
    public partial class Form1 : Form
    {
        XeMayServices _xeMayservice = new XeMayServices();
        Guid _idCellClick;
        List<XeMay> _listObj = new();
        List<LoaiXm> _listLoaiXm = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGrid(string.Empty);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TenTxt.Clear();
            GiaTxt.Clear();
            HangxeCbo.Text = string.Empty;
        }

        private void LoadGrid(string textSearch)
        {
            lstXeDvg.Rows.Clear();
            lstXeDvg.ColumnCount = 5;
            lstXeDvg.Columns[0].Name = "STT";
            lstXeDvg.Columns[1].Name = "Mã xe";
            lstXeDvg.Columns[2].Name = "Tên Xe";
            lstXeDvg.Columns[3].Name = "Giá bán";
            lstXeDvg.Columns[4].Name = "Hãng xe";

            _listObj = _xeMayservice.GetAll(textSearch);
            foreach (var item in _listObj)
            {
                
                lstXeDvg.Rows.Add((_listObj.IndexOf(item) + 1), item.Ma, item.Ten, item.GiaBan, (item.IdLxm == null ? "Không có dữ liệu" : _xeMayservice.GetloaiXe().Where(x => x.Id == item.IdLxm).Select(x => x.Ten).First()));

            }

        }
        private void LoadComboBox()
        {
            var listType = _xeMayservice.GetloaiXe();
            foreach (var item in listType)
            {
                HangxeCbo.Items.Add(item.Ten);
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!_xeMayservice.CheckGiaNhap(GiaTxt.Text))
            {
                MessageBox.Show("Sai định dạng giá nhập . Hãy nhập lại.");

            }
            else
            {
                if (!_xeMayservice.CheckvalueGia(Convert.ToDecimal(GiaTxt.Text)))
                {
                    MessageBox.Show("Gía nhập phải lớn hơn 0.");
                }
                else
                {
                    string firstCharacter = TenTxt.Text.Substring(0, 1).ToUpper();

                    var XeAdd = new XeMay()
                    {
                        Ten = TenTxt.Text,
                        Ma = firstCharacter+"_"+Guid.NewGuid().ToString().Substring(0,15),
                        GiaBan = Convert.ToDecimal(GiaTxt.Text),
                        IdLxm = CheckLoaiXe(HangxeCbo.SelectedText)
                    };

                    var resultAdd = _xeMayservice.Add(XeAdd);
                    if (resultAdd == true)
                    {
                        MessageBox.Show("Add succeeded.");
                        LoadGrid(string.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Add Failed");
                    }
                }

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var listType = _xeMayservice.GetloaiXe();
            if (_idCellClick != null)
            {
                string firstCharacter = TenTxt.Text.Substring(0, 1).ToUpper();
               
                XeMay newXe = new XeMay()
                {
                    Ten = TenTxt.Text,
                    Ma = firstCharacter + "_" + Guid.NewGuid().ToString().Substring(0, 15),
                    GiaBan = Convert.ToDecimal(GiaTxt.Text),
                    IdLxm = CheckLoaiXe(HangxeCbo.SelectedText)
            };
                var resultUpdate = _xeMayservice.Update(_idCellClick, newXe);
                if (resultUpdate == true)
                {
                    MessageBox.Show("Update succeeded.");
                    LoadGrid(string.Empty);
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (_idCellClick != null)
            {
                var resultDele = _xeMayservice.Delete((Guid)_idCellClick);
                if (resultDele == true)
                {
                    MessageBox.Show("Delete Succeeded");
                    LoadGrid(string.Empty);
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }

            }
        }
       
        private Guid? CheckLoaiXe(string Loai)
        {
            var obj = _xeMayservice.GetloaiXe().FirstOrDefault(x => x.Ten.ToLower().Contains(Loai));
            if (obj == null)
            {
                return null;
            }
            return obj.Id;
        }

        private void lstXeDvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var index = e.RowIndex;
            var objCellClick = _listObj[index];
            _idCellClick = objCellClick.Id;
            TenTxt.Text = objCellClick.Ten;
           GiaTxt.Text = objCellClick.GiaBan.ToString();
            string hangxe = _xeMayservice.GetloaiXe().Where(x => x.Id == objCellClick.IdLxm).Select(x => x.Ten).First();
            if (hangxe != null)
            {
                HangxeCbo.Text= hangxe;
                
            }

        }
    }
}
