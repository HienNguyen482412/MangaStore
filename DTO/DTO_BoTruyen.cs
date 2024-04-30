namespace DTO
{
    public class DTOBoTruyen
    {
        private string MaBoTruyen;
        private string TenBoTruyen;
        private string MaTacGia;
        private string MaNXB;
        private int DoTuoi;


        public DTOBoTruyen()
        {

        }
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
