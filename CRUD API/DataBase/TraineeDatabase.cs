#define DEBUG

using CRUD_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.DataBase
{
    public class TraineeDatabase
    {
        private static List<Trainee> _trainees = new List<Trainee>();
        public static int TraineeIdCounter = 0;
#if DEBUG
        public TraineeDatabase()
        {
            _trainees = new List<Trainee>() { new Trainee(++TraineeIdCounter,"John Doe","johndoe@xyz.com","9876543210","Software Developer",1),
                                            new Trainee(++TraineeIdCounter,"Jane Doe", "janedoe@xyz.com", "9876542451", "Software Developer", 1) };
        }
#endif

        public List<Trainee> GetTrainees()
        {
            return _trainees;
        }

        public void Add(Trainee trainee)
        {
            trainee.ID = ++TraineeIdCounter;
            _trainees.Add(trainee);
        }

        public bool Remove(int id)
        {
            return _trainees.Remove(GetTraineeByID(id));
        }

        public Trainee GetTraineeByID(int id)
        {
            return _trainees.Find(trainee => trainee.ID == id);
        }

        public Trainee GetTraineeByName(string name)
        {
            return _trainees.Find(trainee => trainee.Name == name);
        }

        public void UpdateTrainee(Trainee trainee, int id)
        {
            var updateTrainee = GetTraineeByID(id);
            updateTrainee.Name = trainee.Name;
            updateTrainee.PhoneNumber = trainee.PhoneNumber;
            updateTrainee.Email = trainee.Email;
            updateTrainee.Designation = trainee.Designation;
            updateTrainee.BatchNumber = trainee.BatchNumber;
        }

        public bool IdExists(int id)
        {
            try
            {
                _trainees.Find(trainee => trainee.ID == id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
