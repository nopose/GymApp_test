using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Models
{
    public class Result<T>
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<T> results { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Exercise
    {
        public int id { get; set; }
        public string license_author { get; set; }
        public int status { get; set; }
        public string name { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public int category { get; set; }
        public int language { get; set; }
        [NotMapped]
        public List<int> muscles { get; set; }
        [NotMapped]
        public List<int> muscles_secondary { get; set; }
        [NotMapped]
        public List<int> equipment { get; set; }
        public List<Muscle> muscles_db { get; set; }
    }

    public class ExerciseImage
    {
        public int id { get; set; }
        public string image { get; set; }
        public bool is_main { get; set; }
        public int exercise { get; set; }
    }

    public class ExerciseInfo
    {
        public string name { get; set; }
        public Category category { get; set; }
        public string description { get; set; }
        public List<Muscle> muscles { get; set; }
        public List<Muscle> muscles_secondary { get; set; }
        public List<Equipment> equipment { get; set; }
    }

    public class Muscle
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_front { get; set; }
    }
}