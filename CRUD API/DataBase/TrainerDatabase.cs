#define DEBUG

using CRUD_API.Model;
using System;
using System.Collections.Generic;

namespace CRUD_API.DataBase
{
    public class TrainerDatabase
    {
        private static List<Trainer> _trainers = new List<Trainer>();
        public static int TrainerIdCounter = 0;
#if DEBUG
        public TrainerDatabase()
        {
            _trainers = new List<Trainer>() { new Trainer(++TrainerIdCounter,"John Doe","johndoe@xyz.com","9876543210","Software Developer", "C#", "Flights"),
                                            new Trainer(++TrainerIdCounter,"Jane", "janedoe@xyz.com", "9876542451", "Software Developer", "C#", "Flights") };
        }
#endif
        public List<Trainer> GetTrainers()
        {
            return _trainers;
        }

        public void Add(Trainer trainer)
        {
            trainer.ID = ++TrainerIdCounter;
            _trainers.Add(trainer);
        }

        public bool Remove(int id)
        {
            return _trainers.Remove(GetTrainerByID(id));
        }

        public Trainer GetTrainerByID(int id)
        {
            return _trainers.Find(trainer => trainer.ID == id);
        }

        public Trainer GetTrainerByName(string name)
        {
            return _trainers.Find(trainer => trainer.Name == name);
        }

        public void UpdateTrainer(Trainer trainer, int id)
        {
            var updateTrainer = GetTrainerByID(id);
            updateTrainer.Name = trainer.Name;
            updateTrainer.PhoneNumber = trainer.PhoneNumber;
            updateTrainer.Technology = trainer.Technology;
            updateTrainer.Tribe = trainer.Tribe;
            updateTrainer.Email = trainer.Email;
            updateTrainer.Designation = trainer.Designation;
        }

        public bool IdExists(int id)
        {
            if (_trainers.Find(trainer => trainer.ID == id) != null)
                return true;
            else
                return false;
        }
    }
}
