using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyNhap
    {
        public static List<PhieuHH> KiemTraDSNhap(List<PhieuHH> DSHH)
        {
            List<PhieuHH> DSKiemTra = new List<PhieuHH>();
            foreach (PhieuHH h in DSHH)
            {
                if (h.MaMH != null && h.SoLuong != 0)
                {
                    DSKiemTra.Add(h);
                }
            }
            return DSKiemTra;
        }
        public static int TinhThanhTien(List<PhieuHH> DSHH)
        {
            int kq = 0;
            foreach (PhieuHH h in DSHH)
            {
                kq += h.Gia * h.SoLuong;
            }
            return kq;
        }
        public static string NhapHD(HDnhap h)
        {
            //Kiem tra trung ma hoa don
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap hd in DSHD)
            {
                if (hd.MaHD == h.MaHD)
                {
                    return "Trung ma hoa don, nhap that bai";
                }
            }
            //kiem tra hang hoa loi du lieu
            List<PhieuHH> hh = KiemTraDSNhap(h.DSNhapHang);
            if (hh.Count() == 0)
            {
                return "Dữ liệu nhập hàng sai, vui lòng nhập lại";    
            } else
            {
                h.DSNhapHang = hh;
                //Buoc 3: Luu 
                h.ThanhTien = TinhThanhTien(h.DSNhapHang);
                LuuTruHDNhap.LuuHDNhap(h);
                return "Tạo thành công hóa đơn nhập với "+ hh.Count() + " mặt hàng";
            }
            
        }
        public static List<HDnhap> TimKiemHD(string keyword, string keydate)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            if (keydate == null)
            {
                keydate = string.Empty;
            }
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            List<HDnhap> kq = new List<HDnhap>();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD.IndexOf(keyword) != -1 && h.NgayNhap.IndexOf(keydate) != -1)
                {
                    kq.Add(h);
                }
            }
            return kq;
        }
        public static bool KiemTraID(string id)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool KiemTraTonKho(List<PhieuHH> DSHH, string id)
        {
            List<TonkhoMH> DSTK = XuLyTonKho.TaiDSTonKhoMH(null, false);
            if (id != null) //Nếu ko có id -> đang là Xóa HD nhập: goi T là số tồn, A là số nhập sẽ xóa, T < A thì không dc xóa; nếu có id -> đang sửa hd nhập, gọi T là số tồn, B là số nhập ban đâù, A là số nhập sẽ sửa, T-B+A < 0 thì không được sửa
            {
                HDnhap hd = ThongTinHD(id);
                foreach (PhieuHH hh in hd.DSNhapHang)
                {
                    bool check = false;
                    for (int i = 0; i < DSTK.Count(); i++)
                    {
                        if (DSTK[i].MaMH == hh.MaMH)
                        {
                            DSTK[i].SL -= hh.SoLuong;
                            check = true;
                        }
                        
                    }
                    if (check==false)
                    {
                        TonkhoMH tm = new TonkhoMH();
                        tm.MaMH = hh.MaMH;
                        tm.SL = hh.SoLuong;
                        DSTK.Add(tm);
                    }
                }
            }
            foreach (PhieuHH hh in DSHH)
            {
                var target = DSTK.FirstOrDefault(t => t.MaMH == hh.MaMH);
                if (target != null) //null tức là mặt hàng này ko có tồn kho => có thể nhập mà ko cần kiểm tra nữa
                {
                    if (id != null) //giải thích tương tự như trên, với mỗi trường hợp sửa và xóa sẽ có công thức khác nhay
                    {
                        if (target.SL + hh.SoLuong < 0) {
                            return false;
                        }
                    } else
                    {
                        if (target.SL - hh.SoLuong < 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static string XoaHD(string id)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            for (int i=0; i<DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    if (KiemTraTonKho(DSHD[i].DSNhapHang, null)) //Kiểm tra có phù hợp tồn kho hay không
                    {
                        DSHD.RemoveAt(i);
                        LuuTruHDNhap.LuuDSNhap(DSHD);
                        return "Xóa thành công";
                    } else
                    {
                        return "Không thể xóa do khiến tồn kho bị âm";
                    }
                    
                }
            }
            return "Xóa thất bại, không tìm thấy mã hóa đơn";

        }
        public static HDnhap ThongTinHD(string id)
        {
            HDnhap hf = new HDnhap();
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD == id)
                {
                    return h;
                }
            }
            return hf;
        }

        public static string SuaHD(string id, HDnhap h)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            for (int i = 0; i < DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id) //Tim vi tri cua HD
                {
                    for (int j = 0; j < DSHD.Count(); j++)
                    {
                        if (i != j && DSHD[j].MaHD == h.MaHD) //Kiem tra HD moi co trung id voi cac hoa don khac khong
                        {
                            return "Trùng mã hóa đơn, chỉnh sửa thất bại";
                        }
                    }
                    //kiem tra hang hoa loi du lieu
                    List<PhieuHH> hh = KiemTraDSNhap(h.DSNhapHang);
                    if (hh.Count() == 0)
                    {
                        return "Dữ liệu nhập hàng sai, vui lòng nhập lại";
                    }
                    else
                    {
                        h.DSNhapHang = hh;
                        if (KiemTraTonKho(h.DSNhapHang,id)) //Kiểm tra có phù hợp tồn kho hay không
                        {
                            h.ThanhTien = TinhThanhTien(h.DSNhapHang);
                            DSHD[i] = h;
                            LuuTruHDNhap.LuuDSNhap(DSHD);
                            return "Chỉnh sửa thành công";
                        }
                        else
                        {
                            return "Không thể sửa do khiến tồn kho bị âm";
                        }

                    }
                        
                }
            }

            return "Chỉnh sửa thất bại, dữ liệu không phù hợp";
        }
    }
}
