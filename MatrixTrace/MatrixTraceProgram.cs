using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public class MatrixTraceProgram
    {
        private Matrix _matrix;
        private MatrixConsole _matrixConsole;
        private int _rows;
        private int _columns;

        public void Start()
        {
            WelcomeProgram();
            string action = Console.ReadLine();
            SelectStartAction(action);
        }

        private void WelcomeProgram()
        {
            MatrixConsole.PrintMessage(ConstantMessages.WelcomeMsg);
            MatrixConsole.PrintMessage(ConstantMessages.CreateMsg);
            MatrixConsole.PrintMessage(ConstantMessages.ExitMsg);
            MatrixConsole.PrintMessage(ConstantMessages.SelectMsg);            
        }

        private void SelectStartAction(string startAction)
        {
            if (startAction == "1")
            {
                MatrixConsole.PrintMessage(ConstantMessages.SizeMatrixMsg);

                _rows = InputSizeMatrix(ConstantMessages.RowMsg);
                _columns = InputSizeMatrix(ConstantMessages.ColumnMsg);

                ValidateSizeMatrix();

                _matrix = new Matrix(_rows, _columns);
                _matrixConsole = new MatrixConsole();

                MatrixConsole.PrintMessage(ConstantMessages.TraceMsg);
                MatrixConsole.PrintMessage(ConstantMessages.PrintMsg);
                MatrixConsole.PrintMessage(ConstantMessages.PrintSnakeMsg);
                MatrixConsole.PrintMessage(ConstantMessages.ExitMsg);
                MatrixConsole.PrintMessage(ConstantMessages.SelectMsg);
                string command = Console.ReadLine();

                ExecuteAction(command);
            }
            else if (startAction == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Start();
            }
        }

        private void ValidateSizeMatrix()
        {
            if (_rows < 1 || _columns < 1)
            {
                ShowErrorMsg(ConstantMessages.ErrorZeroMsg);
                Start();
            }
        }

        private void ExecuteAction(string action)
        {
            if (action == "2")
            {
                MatrixConsole.PrintMessage(_matrix.GetMatrixTrace().ToString());
            }
            else if (action == "3")
            {
                _matrixConsole.MatrixToConsole(_matrix.GetMatrix());
            }
            else if (action == "4")
            {
                _matrixConsole.MatrixSnakeToConsole(_matrix.GetMatrixSnake());
            }
            else if (action == "5")
            {
                ExitProgram();
            }
            else
            {
                Start();
            }
        }

        private void ExitProgram()
        {
            Environment.Exit(0);
        }       

        private int InputSizeMatrix(string msg)
        {
            MatrixConsole.PrintMsg(msg);
            
            string sizeString = Console.ReadLine();           
                
            string errorMsg = MatrixValidator.ValidateSizeInput(sizeString);                       
            
            if (errorMsg != "")
            {
                ShowErrorMsg(errorMsg);
                Start();
            }
            try
            {
                return int.Parse(sizeString);
            }
            catch
            {
                return 0;
            }
        }       

        private void ShowErrorMsg(string errorMsg)
        {
            MatrixConsole.PrintMessage(errorMsg);
        }                            
    }
}
