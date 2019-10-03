using System.Collections.Generic;
using CRUD_API.DataBase;
using CRUD_API.Model;

namespace CRUD_API.Service
{
    public class ValidateTraineeDetails
    {
        public static bool IsValidTrainee(Trainee newTrainee, out List<ErrorModel> errors)
        {
            errors = null;
            List<ErrorModel> _errors = new List<ErrorModel>();
            
            bool valid = true;

            if (newTrainee.Name.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingName, ErrorMessage.MissingName));
                valid = false;
            }
            if (newTrainee.Name.ContainsNumbers())
            {
                _errors.Add(new ErrorModel(ErrorCodes.NameViolation, ErrorMessage.NameViolation));
                valid = false;
            }
            if (!newTrainee.Email.IsEmail())
            {
                _errors.Add(new ErrorModel(ErrorCodes.EmailViolation, ErrorMessage.EmailViolation));
                valid = false;
            }
            if (!newTrainee.PhoneNumber.IsPhoneNumber())
            {
                _errors.Add(new ErrorModel(ErrorCodes.PhoneNumberViolation, ErrorMessage.PhoneNumberViolation));
                valid = false;
            }
            if (newTrainee.Designation.IsBlankOrWhiteSpace())
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingDesignation, ErrorMessage.MissingDesignation));
                valid = false;
            }
            if (!newTrainee.BatchNumber.IsPositiveNumber())
            {
                _errors.Add(new ErrorModel(ErrorCodes.InvalidBatch, ErrorMessage.InvalidBatch));
            }

            if (_errors != null)
                errors = _errors;
            return valid;
        }

        public static bool IsValidUpdateTrainee(Trainee newTrainee, out List<ErrorModel> errors)
        {
            errors = null;
            List<ErrorModel> _errors = new List<ErrorModel>();
            
            bool valid = true;

            if (newTrainee.Name.IsBlankOrWhiteSpace() && newTrainee.Name!=null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingName, ErrorMessage.MissingName));
                valid = false;
            }
            if (newTrainee.Name.ContainsNumbers() && newTrainee.Name != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.NameViolation, ErrorMessage.NameViolation));
                valid = false;
            }
            if (!newTrainee.Email.IsEmail() && newTrainee.Email != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.EmailViolation, ErrorMessage.EmailViolation));
                valid = false;
            }
            if (!newTrainee.PhoneNumber.IsPhoneNumber() && newTrainee.PhoneNumber != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.PhoneNumberViolation, ErrorMessage.PhoneNumberViolation));
                valid = false;
            }
            if (newTrainee.Designation.IsBlankOrWhiteSpace() && newTrainee.Designation != null)
            {
                _errors.Add(new ErrorModel(ErrorCodes.MissingDesignation, ErrorMessage.MissingDesignation));
                valid = false;
            }
            if (newTrainee.BatchNumber != 0 && newTrainee.BatchNumber.IsPositiveNumber())
            {
                _errors.Add(new ErrorModel(ErrorCodes.InvalidBatch, ErrorMessage.InvalidBatch));
            }
            if (_errors != null)
                errors = _errors;
            return valid;
        }
    }
}
