namespace CRUD_API.DataBase
{
    public class ErrorCodes
    {
        public const int InvalidId = 1403;
        public const int InvalidBatch = 1404;

        public const int TrainerNotFound = 1601;
        public const int TraineeNotFound = 1602;

        public const int MissingName = 1501;
        public const int MissingDesignation = 1502;
        public const int MissingTechnology = 1503;
        public const int MissingTribe = 1504;
        public const int MissingBatch = 1505;

        public const int NameViolation = 1701;
        public const int PhoneNumberViolation = 1702;
        public const int EmailViolation = 1703;

        public const int Unknown = 5000;
        
        
    }
}
