using System.Collections.Generic;

namespace CRUD_API.Model
{
    public class TraineeResponseModel
    {
        public Trainee Trainee { get; private set; } = null;
        public List<Trainee> Trainees { get; private set; } = null;
        public List<ErrorModel> Errors { get; private set; } = null;

        public TraineeResponseModel(Trainee trainee, List<ErrorModel> errors)
        {
            Trainee = trainee;
            Errors = errors;
        }

        public TraineeResponseModel(List<Trainee> trainees, ErrorModel error)
        {
            Trainees = trainees;
            if (error != null)
            {
                Errors = new List<ErrorModel>() { error };
            }

        }
    }
}
