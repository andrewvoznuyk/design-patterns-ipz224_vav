namespace ShopClassLibrary
{
    public class Dolar : IMoney
    {
        public int Fullprice { get; set; }
        public int Partprice { get; set; }

        public Dolar(int dolar, int cent)
        {
            Fullprice = dolar;
            Partprice = cent;
        }

        public string ShowInfo()
        {
            return $"{Fullprice}.{Partprice} $";
        }
    }
}
