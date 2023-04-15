using System;
using System.Collections.Generic;

public class FieldUnit
{
	public FieldUnit()
	{
		public int Id { get; set; }
		public string Name { get; set; }

        private List<Plant> plants;

        public List<Plant> GetPlants()
        {
            return plants;
        }

        public void SetPlants(List<Plant> value)
        {
            plants = value;
        }
}
}
