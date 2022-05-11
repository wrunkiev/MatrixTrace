using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public static class MatrixValidator
    {
        public static string ValidateSizeInput(string input)
        {
            if (String.IsNullOrEmpty(input))
            {                
                return ConstantMessages.ErrorInputEmptyMsg;                                  
            }
            try
            {
                int result = Int32.Parse(input);
                return "";
            }
            catch
            {                   
                return ConstantMessages.ErrorInputIntMsg;                                                
            }           
        }        
    }
}
