using CRUD_API.DataBase;
using CRUD_API.Model;
using System.Collections.Generic;

namespace CRUD_API.Service
{
    public class TrainerService
    {
        private static readonly TrainerDatabase _trainerDatabase = new TrainerDatabase();
        //private static List<ErrorModel> _errors = new List<ErrorModel>();

        public TrainerResponseModel GetTrainers()
        {
            var trainers = _trainerDatabase.GetTrainers();
            if (trainers!=null)
            {
                return new TrainerResponseModel(trainers, null);
            }
            else
            {
                var error = new ErrorModel(ErrorCodes.Unknown, ErrorMessage.Unknown);
                return new TrainerResponseModel(null, error);
            }
        }

        public TrainerResponseModel GetTrainerById(int id)
        {
            var trainer = _trainerDatabase.GetTrainerByID(id);
            if (trainer!=null)
            {
                return new TrainerResponseModel(trainer, null);
            }
            else
            {
                var error = new List<ErrorModel>() { new ErrorModel(ErrorCodes.InvalidId, ErrorMessage.InvalidId) };
                return new TrainerResponseModel(null, error);
            }
        }

        public TrainerResponseModel AddTrainer(Trainer newTrainer)
        {
            List<ErrorModel> _errors = new List<ErrorModel>();
            bool valid = ValidateTrainerDetails.IsValidTrainer(newTrainer,out _errors);
            if (!valid)
            {
                return new TrainerResponseModel(null, _errors);
            }
            else
            {
                //newTrainer.ID = Employee.employeeIdCounter;
                _trainerDatabase.Add(newTrainer);
                return new TrainerResponseModel(GetTrainerById(newTrainer.ID).Trainer, null);
            }
        }

        public TrainerResponseModel UpdateTrainer(Trainer trainer,int id)
        {
            if(!_trainerDatabase.IdExists(id))
            {
                var error = new List<ErrorModel>() { new ErrorModel(ErrorCodes.InvalidId, ErrorMessage.InvalidId) };
                return new TrainerResponseModel(null, error);
            }
            List<ErrorModel> _errors = new List<ErrorModel>();
            bool valid = ValidateTrainerDetails.IsValidTrainer(trainer, out _errors);
            if (!valid)
            {
                return new TrainerResponseModel(null, _errors);
            }
            else
            {
                _trainerDatabase.UpdateTrainer(trainer, id);
                return new TrainerResponseModel(GetTrainerById(id).Trainer, null);
            }
        }

        public bool DeleteTrainerById(int id)
        {
            if (!_trainerDatabase.IdExists(id))
            {
                return false;
            }
            else
            {
                return _trainerDatabase.Remove(id);
            }

        }
    }
}
