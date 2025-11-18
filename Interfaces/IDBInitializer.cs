using FitnessWG.Data;

namespace FitnessWG.Interfaces
{
    public interface IDBInitializer
    {
        void Initialize(SQLiteDBContext context);
    }
}
