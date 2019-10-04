using CRUD_API.DataBase;
using CRUD_API.Model;
using System.Collections.Generic;

namespace CRUD_API.Service
{
    public class TraineeService
    {
        private static readonly TraineeDatabase _traineeDatabase = new TraineeDatabase();
        //private List<ErrorModel> _errors = new List<ErrorModel>();

        public TraineeResponseModel GetTrainees()
        {
            var trainees = _traineeDatabase.GetTrainees();
            if (trainees!=null)
            {
                return new TraineeResponseModel(trainees, null);
            }
            else
            {
                var error = new ErrorModel(ErrorCodes.Unknown, ErrorMessage.Unknown);
                return new TraineeResponseModel(null, error);
            }
        }

        public TraineeResponseModel GetTraineeById(int id)
        {
            var trainee = _traineeDatabase.GetTraineeByID(id);
            if (trainee!=null)
            {
                return new TraineeResponseModel(trainee, null);
            }
            else
            {
                var error = new List<ErrorModel>() { new ErrorModel(ErrorCodes.InvalidId, ErrorMessage.InvalidId) };
                return new TraineeResponseModel(null, error);
            }
        }

        public TraineeResponseModel AddTrainee(Trainee newTrainee)
        {
            List<ErrorModel> _errors = new List<ErrorModel>();
            bool valid = ValidateTraineeDetails.IsValidTrainee(newTrainee,out _errors);
            if (!valid)
            {
                return new TraineeResponseModel(null, _errors);
            }
            else
            {
                _traineeDatabase.Add(newTrainee);
                return new TraineeResponseModel(GetTraineeById(newTrainee.ID).Trainee, null);
            }
        }

        public TraineeResponseModel UpdateTrainee(Trainee trainee,int id)
        {
            if(!_traineeDatabase.IdExists(id))
            {
                var error = new List<ErrorModel>() { new ErrorModel(ErrorCodes.InvalidId, ErrorMessage.InvalidId) };
                return new TraineeResponseModel(null, error);
            }
            List<ErrorModel> _errors = new List<ErrorModel>();
            bool valid = ValidateTraineeDetails.IsValidTrainee(trainee, out _errors);
            if (!valid)
            {
                return new TraineeResponseModel(null, _errors);
            }
            else
            {
                _traineeDatabase.UpdateTrainee(trainee, id);
                return new TraineeResponseModel(GetTraineeById(id).Trainee, null);
            }
        }

        public bool DeleteTraineeById(int id)
        {
            if (!_traineeDatabase.IdExists(id))
            {
                return false;
            }
            else
            {
                return _traineeDatabase.Remove(id);
            }

        }
    }
}
