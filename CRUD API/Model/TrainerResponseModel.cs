using System.Collections.Generic;

namespace CRUD_API.Model
{
    public class TrainerResponseModel
    {
        public Trainer Trainer { get; private set; } = null;
        public List<Trainer> Trainers { get; private set; } = null;
        public List<ErrorModel> Errors { get; private set; } = null;

        public TrainerResponseModel(Trainer trainer, List<ErrorModel> errors)
        {
            Trainer = trainer;
            Errors = errors;
        }

        public TrainerResponseModel(List<Trainer> trainers, ErrorModel error)
        {
            Trainers = trainers;
            if (error != null)
            {
                Errors = new List<ErrorModel>() { error };
            }
            
        }
    }
}
