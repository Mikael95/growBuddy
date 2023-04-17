namespace BlazorApp1.Data
{
    public class DataPoint
    {
        public float Data { get; set; }
        public Severety Severety { get; set; }

        public DataPoint (float data, Severety severety)
        {
            Data = data;
            Severety = severety;
        }
    }

    public enum Severety
    {
        Nothingburger = 0,
        Okey = 1,
        Moderate = 2,
        Important = 3,
        Severe = 4,
    }
}
