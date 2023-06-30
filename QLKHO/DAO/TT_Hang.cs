namespace QLKHO.DAO
{
    class TT_Hang
    {
        private string _ma;
        private string _ten;
        private string _loai;
        private int _sl;

        public string Ma { get => _ma; set => _ma = value; }// get lay gia tri cua thuoc tinh, set gan gia tri cho thuoc tinh
        public string Ten { get => _ten; set => _ten = value; }
        public string Loai { get => _loai; set => _loai = value; }
        public int Sl { get => _sl; set => _sl = value; }

        public TT_Hang(string ma, string ten, string loai, int sl)
        {
            Ma = ma;
            Ten = ten;
            Loai = loai;
            Sl = sl;
        }

        public TT_Hang()
        {
            Ma = " ";
            Ten = " ";
            Loai = " ";
            Sl = 0;
        }
    }
}
