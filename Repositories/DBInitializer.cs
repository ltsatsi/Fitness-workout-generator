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
            context.SaveChanges();
        }
    }
}
