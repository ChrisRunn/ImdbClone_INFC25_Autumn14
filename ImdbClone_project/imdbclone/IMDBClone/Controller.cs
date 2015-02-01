using System;

namespace IMDBCloneApplication
{
    class Controller
    {
        Utility myUtility = new Utility();
        
        public Controller()
        {
            
        }

        public string HandleAllExceptions(Exception ex)
        {
            return myUtility.HandleAllExceptions(ex);
        }

    }
}
