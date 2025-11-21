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


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", 
            ErrorMessage = "Email format invalid")]
        public string Email { get; set; }


        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is required.")]
        [Range(13, 80, ErrorMessage = "You must be between the ages of 13 - 80")]
        public int Age { get; set; }


        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }


        [Display(Name = "Height (in cm)")]
        [Required(ErrorMessage = "Height is required.")]
        [Range(150, int.MaxValue, ErrorMessage = "Height must be at least 150 cm.")]
        public int Height { get; set; }


        [Display(Name = "Weight (in kg)")]
        [Required(ErrorMessage = "Weight is required.")]
        [Range(40, int.MaxValue, ErrorMessage = "Weight must be at least 40 kg.")]
        public double Weight { get; set; }


        [Display(Name = "Location")]
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }


        [Display(Name = "Experience Level")]
        [Required(ErrorMessage = "Experience level is required.")]
        public ExperienceLevel ExperienceLevel { get; set; }


        [Display(Name = "Goal")]
        [Required(ErrorMessage = "Goal is required.")]
        public Goal Goal { get; set; }


        [Display(Name = "Days per week")]
        [Required(ErrorMessage = "Days per week are required.")]
        [Range(2, 5, ErrorMessage = "A minimum of 2 to 5 days is required.")]
        public int DaysPerWeek { get; set; }


        [Display(Name = "Equipment")]
        [Required(ErrorMessage = "Equipment is required.")]
        public bool HasEquipment { get; set; } = false;


        public Workout? Workout { get; set; }
    }
}
