using BlazorApp1.Data;
using System;
using System.Collections.Generic;

public class FieldUnit
{
	public int Id { get; set; }
	public string Name { get; set; }
    private List<Plant> plants { get; set; }

    public FieldUnit( string name, List<Plant> plants) 
    {
        this.Name = name;
        this.plants = plants;
    }

}
