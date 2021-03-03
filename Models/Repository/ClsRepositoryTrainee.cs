using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudInCoreWebApi.Models.Repository
{
    public class ClsRepositoryTrainee : IDataAccessRepository<Trainee>
    {
        readonly CrudInCoreWebApiContext db;

        public ClsRepositoryTrainee(CrudInCoreWebApiContext apiContext)
        {
            db = apiContext;
        }


        public void Add(Trainee entity)
        {
            db.Trainees.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Trainee entity)
        {
            db.Trainees.Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<Trainee> GelAll()
        {
            return db.Trainees.ToList();
        }

        public Trainee Get(long id)
        {
            return db.Trainees.FirstOrDefault(x => x.TraineeID == id);
        }

        public void Update(Trainee dbEntity, Trainee entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.DateOfBirth = entity.DateOfBirth;
            dbEntity.EmailID = entity.EmailID;
            dbEntity.Address = entity.Address;
            dbEntity.CellPhoneNo = entity.CellPhoneNo;
            db.SaveChanges();
        }
    }
}
