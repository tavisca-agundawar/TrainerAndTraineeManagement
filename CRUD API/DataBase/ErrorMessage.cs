﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.DataBase
{
    public class ErrorMessage
    {
        public const string InvalidId = "Error! Invalid ID";
        public const string TrainerNotFound = "Error! Trainer not found!";
        public const string NameViolation = "Error! Name cannot contain numbers!";
        public const string MissingName = "Error! Name cannot be blank!";
        public const string MissingDesignation = "Error! Designation cannot be blank!";
        public const string MissingTechnology = "Error! Technology cannot be blank!";
        public const string MissingTribe = "Error! Tribe cannot be blank!";
        public const string PhoneNumberViolation = "Error! Phone number is invalid";
        public const string EmailViolation = "Error! Incorrect email id!";
        public const string Unknown = "Unknown error occurred!";
    }  
}      
