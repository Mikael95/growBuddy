using BlazorApp1.Data;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Reading
{
		public int Id {  get; set; }
		public FieldUnit Unit { get; set; }
		public Plant plant { get; set; }
		public float Temp { get; set; }
		public float Humidity { get; set; }
		public float Sunlight { get; set; }
		public DateTime Date { get; set; }

	public Reading (FieldUnit fieldUnit, Plant plant, float temp, float humidity, float Sunlight, DateTime date)
	{
		this.Unit = fieldUnit;
		this.plant = plant;
		this.Temp = temp;
		this.Humidity = humidity;
		this.Sunlight = Sunlight;
		this.Date = date;
	}
}
