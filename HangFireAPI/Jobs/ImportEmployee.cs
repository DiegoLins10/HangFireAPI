using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireAPI.Jobs
{
    public class ImportEmployee
    {
        [AutomaticRetry(Attempts = 0)]
        public void Execute(string param)
        {
            try
            {

                param = "sucesso";

                if(param != null)
                {
                    throw new Exception("doidera");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
