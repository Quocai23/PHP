using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DemoNET_VS2022.Models;

namespace DemoNET_VS2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QlbanHangContext db = new QlbanHangContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var sp = from p in db.SanPhams
            //         select p;
            //dgvLoaiSanPham.ItemsSource = sp.ToList();

            //var sp = db.SanPhams
            //    .Select(p => new { p.MaSp, p.TenSp, p.MaLoai });

            //var sp = (from p in db.SanPhams select p).Skip(0).Take(1);

            //var query = from sp in db.SanPhams
            //            group sp by sp.MaLoai into LspGroup
            //            select new
            //            {
            //                MaLoai = LspGroup.Key,
            //                TongTien = LspGroup.Sum(t => t.DonGia * t.SoLuong)
            //            };

            //var query1 = from sp in db.SanPhams
            //             group sp by sp.MaLoai into LspGroup
            //             select new
            //             {
            //                 MaLoai = LspGroup.Key,
            //                 TongTien = LspGroup.Sum(t => t.DonGia * t.SoLuong)
            //             };
            //var query2 = from t in query1
            //             join lsp in db.LoaiSanPhams on t.MaLoai equals lsp.MaLoai
            //             select new
            //             {
            //                 lsp.MaLoai,
            //                 lsp.TenLoai,
            //                 t.TongTien
            //             };

            //    var sp = from p in db.SanPhams
            //             join k in db.LoaiSanPhams
            //             on p.MaLoai equals k.MaLoai
            //             select new { p.MaSp, p.TenSp, k.TenLoai };
            var sp = from p in db.SanPhams
                     where p.MaLoai == "L01"
                     select new { p.MaSp, p.TenSp, p.MaLoai };
        }

    }
}
