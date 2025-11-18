using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWG.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }


        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }


        public List<string>? Equipment { get; set; }
        public DateTime? TimeStamp { get; } = DateTime.Now;


        [Column("WorkoutId")]
        public int WorkoutId { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        public Workout Workout { get; set; }
    }
}
