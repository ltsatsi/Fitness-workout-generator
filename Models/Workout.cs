using System.ComponentModel.DataAnnotations;

namespace FitnessWG.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }
        public string WorkoutName { get; set; }
        public string WorkoutDescription { get; set; }


        public int Reps { get; set; }
        public int Sets { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
