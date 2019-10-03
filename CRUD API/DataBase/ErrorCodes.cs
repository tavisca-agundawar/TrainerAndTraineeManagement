using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.DataBase
{
    public class ErrorCodes
    {
        public const int InvalidId = 1403;
        public const int TrainerNotFound = 1404;
        public const int NameViolation = 1500;
        public const int MissingName = 1501;
        public const int MissingDesignation = 1502;
        public const int MissingTechnology = 1503;
        public const int MissingTribe = 1504;
        public const int PhoneNumberViolation = 1505;
        public const int EmailViolation = 1506;
        public const int Unknown = 4000;
    }
}
