using CRUD_API.DataBase;
using CRUD_API.Model;
using System.Collections.Generic;

namespace CRUD_API.Service
{
    public class ValidateTrainerDetails
    {
        public static bool IsValidTrainer(Trainer newTrainer,out List<ErrorModel> errors)
        {
            errors = null;
            List<ErrorModel> _errors = new List<ErrorModel>();
            
            bool valid = true;

            if (newTrainer.Name.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingName, ErrorMessage.MissingName));
                valid = false;
            }
            if (newTrainer.Name.ContainsNumbers())
            {
                _errors.Add(new ErrorModel(ErrorCodes.NameViolation, ErrorMessage.NameViolation));
                valid = false;
            }
            if (!newTrainer.Email.IsEmail())
            {
                _errors.Add(new ErrorModel(ErrorCodes.EmailViolation, ErrorMessage.EmailViolation));
                valid = false;
            }
            if (!newTrainer.PhoneNumber.IsPhoneNumber())
            {
                _errors.Add(new ErrorModel(ErrorCodes.PhoneNumberViolation, ErrorMessage.PhoneNumberViolation));
                valid = false;
            }
            if (newTrainer.Designation.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingDesignation, ErrorMessage.MissingDesignation));
                valid = false;
            }
            if (newTrainer.Technology.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingTechnology, ErrorMessage.MissingTechnology));
            }
            if (newTrainer.Tribe.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingTribe, ErrorMessage.MissingTribe));
            }
            if (_errors != null)
                errors = _errors;
            return valid;
        }

        public static bool IsValidUpdateTrainer(Trainer newTrainer, out List<ErrorModel> errors)
        {
            errors = null;
            List<ErrorModel> _errors = new List<ErrorModel>();
            
            bool valid = true;

            if (newTrainer.Name.IsBlankOrWhiteSpace() && newTrainer.Name!=null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingName, ErrorMessage.MissingName));
                valid = false;
            }
            if (newTrainer.Name.ContainsNumbers() && newTrainer.Name != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.NameViolation, ErrorMessage.NameViolation));
                valid = false;
            }
            if (!newTrainer.Email.IsEmail() && newTrainer.Email != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.EmailViolation, ErrorMessage.EmailViolation));
                valid = false;
            }
            if (!newTrainer.PhoneNumber.IsPhoneNumber() && newTrainer.PhoneNumber != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.PhoneNumberViolation, ErrorMessage.PhoneNumberViolation));
                valid = false;
            }
            if (newTrainer.Designation.IsBlankOrWhiteSpace() && newTrainer.Designation != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingDesignation, ErrorMessage.MissingDesignation));
                valid = false;
            }
            if (newTrainer.Technology.IsBlankOrWhiteSpace() && newTrainer.Technology != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingTechnology, ErrorMessage.MissingTechnology));
            }
            if (newTrainer.Tribe.IsBlankOrWhiteSpace() && newTrainer.Tribe != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingTribe, ErrorMessage.MissingTribe));
            }
            if (_errors != null)
                errors = _errors;
            return valid;
        }
    }
}
