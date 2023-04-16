using System;

namespace BlazorApp1.Data
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Preferences Preferences { get; set; }
        public Mood Mood { get; set; }
        public DateTime DateOfPlanting { get; set; }
    }

    public enum Mood
    {
        Dead = 0,
        Not_happy = 1,
        Hanging_by = 2,
        Good = 3,
        Exelent = 4
    }
}