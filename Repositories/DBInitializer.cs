using FitnessWG.Data;
using FitnessWG.Interfaces;
using FitnessWG.Models;

namespace FitnessWG.Repositories
{
    public class DBInitializer : IDBInitializer
    {
        public void Initialize(SQLiteDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User() { 
                    UserId = 1, 
                    UserName = "Kelvin", 
                    ExperienceLevel = Models.Enums.ExperienceLevel.Beginner, 
                    Goal = Models.Enums.Goal.Strength, 
                    HasEquipment = false, 
                    DaysPerWeek = 4, 
                    Workout = new Workout() 
                    { 
                        WorkoutId = 1,
                        WorkoutName = "Arms",
                        WorkoutDescription = "Focuses on biceps forearms and shoulders",
                        Reps = 4,
                        Sets = 2,
                        UserId = 1,
                        Exercises = new List<Exercise>()
                        {
                            new Exercise() 
                            { 
                                ExerciseId = 1, 
                                ExerciseName = "Bicep curl", 
                                ExerciseDescription = "Train biceps", 
                                Equipment = null, 
                                WorkoutId = 1 
                            }
                        }
                    } 
                },
            };

            foreach (User user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}
