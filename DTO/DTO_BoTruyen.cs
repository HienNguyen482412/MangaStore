namespace DTO
{
    /// <summary>
    /// Mục đích: lưu thông tin của một bộ truyện gồm: mã bộ truyện, tên bộ truyện, mã tác giả, mã nhà xuất bản và độ tuổi.
    /// <br>Người lập: Nguyễn Minh Hiền</br>
    /// </summary>

    public class DTOBoTruyen
    {
        private string MaBoTruyen;
        private string TenBoTruyen;
        private string MaTacGia;
        private string MaNXB;
        private int DoTuoi;

        /// <summary>
        /// Constructor mặc định của DTOBoTruyen
        /// </summary>
        public DTOBoTruyen()
        {

        }
        /// <summary>
        /// Constructor có tham số của DTOBoTruyen
        /// </summary>
        /// <param name="maBT">Mã bộ truyện</param>
        /// <param name="tenBT">Tên bộ truyện</param>
        /// <param name="maTG">Mã tác giả</param>
        /// <param name="maNXB">Mã nhà xuất bản</param>
        /// <param name="doTuoi">Độ tuổi</param>
        public DTOBoTruyen(string maBT, string tenBT, string maTG, string maNXB, int doTuoi)
        {
            this.MaBoTruyen = maBT;
            this.TenBoTruyen = tenBT;
            this.MaTacGia = maTG; this.MaNXB = maNXB; this.DoTuoi = doTuoi;
        }

        public string MaBoTruyen1 { get => MaBoTruyen; set => MaBoTruyen = value; }
        public string TenBoTruyen1 { get => TenBoTruyen; set => TenBoTruyen = value; }
        public string MaTacGia1 { get => MaTacGia; set => MaTacGia = value; }
        public string MaNXB1 { get => MaNXB; set => MaNXB = value; }
        public int DoTuoi1 { get => DoTuoi; set => DoTuoi = value; }
    }
}
