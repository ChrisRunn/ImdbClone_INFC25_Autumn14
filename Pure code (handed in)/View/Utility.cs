using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace IMDBCloneApplication
{
    class Utility
    {
        //default constructor
        public Utility()
        {

        }

        //receive an SQLException och return user-friendly error message
        public string HandleError(SqlException ex)
        {
            int errorCode = ex.Errors[0].Number;
            string errorMessage = "";

           
            
            switch (errorCode)
            {
                case 2627:
                    errorMessage = "The database already contains the object you are trying to add.";
                    break;
                case 53:
                    errorMessage = "There is no connection to database";
                    break;
                default:
                    errorMessage = ("An SQL error occured:" + errorCode);
                    break;
            }
            return errorMessage;
        }

        //receive an Exception, check if it is of type SQL and pass it on, otherwise return userfriendly error message
        public string HandleAllExceptions(Exception ex)
        {
            if (ex is DbUpdateException)
            {
                return ex.InnerException.InnerException.Message;
            }
            
            if (ex is SqlException)
            {
                SqlException mySqlException = ex as SqlException;
                return HandleError(mySqlException);
            }
            if (ex is FormatException)
            {
               return "Du har ej angivit en int";
            }
            if (ex is NoNullAllowedException)
            {
                return "Please make sure to fill all fields before trying to save.";
            }

            return ex.Message;
        }


    

    }
}
