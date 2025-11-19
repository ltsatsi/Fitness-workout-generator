using FitnessWG.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FitnessWG.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }


        [Display(Name = "Experience Level")]
        [Required(ErrorMessage = "Experience level is required.")]
        public ExperienceLevel ExperienceLevel { get; set; }


        [Display(Name = "Goal")]
        [Required(ErrorMessage = "Goal is required.")]
        public Goal Goal { get; set; }


        [Display(Name = "Days per week")]
        [Required(ErrorMessage = "Days per week are required.")]
        public int DaysPerWeek { get; set; }


        [Display(Name = "Equipment")]
        [Required(ErrorMessage = "Equipment is required.")]
        public bool HasEquipment { get; set; }


        public Workout? Workout { get; set; }
    }
}
