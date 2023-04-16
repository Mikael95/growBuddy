namespace BlazorApp1.Data
{
    public class Preferences
    {
        public int Id { get; set; }
        public DataPoint MinimumTemp { get; set; }
        public DataPoint MaximumTemp { get; set; }
        public DataPoint MinimumHumidity { get; set; }
        public DataPoint MaximumHumidity { get; set; }
        public DataPoint MinimumSunligtHours { get; set; }
        public DataPoint MaximumSunligtHours { get; set; }
        public DataPoint MaximumSunlightStrenght { get; set; }
        public List<DataPoint> Wateringcycle { get; set; }
    }
}
