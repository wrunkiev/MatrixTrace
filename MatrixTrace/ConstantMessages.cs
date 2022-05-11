using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public class ConstantMessages
    {
        public static readonly string WelcomeMsg = "Welcome to program 'Matrix'.";
        public static readonly string CreateMsg = "1. Create matrix.";
        public static readonly string TraceMsg = "2. Get matrix trace.";
        public static readonly string PrintMsg = "3. Print matrix.";
        public static readonly string PrintSnakeMsg = "4. Print matrix snake.";
        public static readonly string ExitMsg = "5. Exit.";        
        public static readonly string ErrorZeroMsg = "Row and column must be more then zero";        
        public static readonly string ErrorInputEmptyMsg = "The input can't be empty";       
        public static readonly string ErrorInputIntMsg = "The input must be integer";
        public static readonly string SelectMsg = "Select command: ";
        public static readonly string SizeMatrixMsg = "Input size of matrix:";
        public static readonly string ColumnMsg = "Input columns count(integer): ";
        public static readonly string RowMsg = "Input rows count(integer): ";
    }
}
