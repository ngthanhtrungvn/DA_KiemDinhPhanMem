using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE03_DanhHoangSon_Code
{
    public class TinhTienBaoHiem
    {
       private const double luongCoSo = 1800000;
        private const double giam = 0.15;

        public double TinhBHYT(double tongChiPhiYTe, bool laNgheo, bool laThamGiaLienTuc, int soNamThamGiaLienTuc, int tuoi)
        {
            double tyLeGiamMien = 0;

            if (tuoi < 6 || tongChiPhiYTe < luongCoSo * giam || (laThamGiaLienTuc && soNamThamGiaLienTuc >= 5))
            {
                tyLeGiamMien = 1.0; // Miễn 100%
            }
            else if (laNgheo)
            {
                tyLeGiamMien = 0.95; // Miễn 95%
            }
            else
            {
                tyLeGiamMien = 0.8; // Miễn 80%
            }

            double tongMienGiam = tongChiPhiYTe * (1.0 - tyLeGiamMien);
            return tongMienGiam;
        }
    }
}
