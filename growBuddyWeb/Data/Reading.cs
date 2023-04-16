using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Reading
{
	public Reading()
	{
		public int Id {  get; set; }
		public FieldUnit Unit { get; set; }
		public Plant plant { get; set; }
		public float Temp { get; set; }
		public float Humidity { get; set; }
		public float Sunlight { get; set; }
		public DateTime Date { get; set; }
	}
}
