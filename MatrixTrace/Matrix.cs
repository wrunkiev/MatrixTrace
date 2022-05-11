using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public class Matrix
    {
        private int[,] _array;
        private int _rows;
        private int _columns;

        public Matrix(int rows, int columns)
        {            
            if (ValidateMinRowsColumns(rows, columns))
            {
                _rows = rows;
                _columns = columns;
                _array = new int[_rows, _columns];
                FillMatrix();                
            }
            else
            {
                throw new Exception(ConstantMessages.ErrorZeroMsg);
            }
        }

        public Matrix(int[,] array)
        {
            _array = array;
            _rows = array.GetLength(0);
            _columns = array.GetLength(1);
        }                     
        
        public int GetMatrixTrace()
        {       
            int matrixTrace = 0;
            int minSize = Math.Min(_rows, _columns);
            
            for (int i = 0; i < minSize; i++)
            {
                matrixTrace += _array[i, i];
            }                       

            return matrixTrace;
        }
        
        public Queue<MatrixFormattedItem> GetMatrix()
        { 
            Queue<MatrixFormattedItem> matrixItems = new Queue<MatrixFormattedItem>();

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    matrixItems.Enqueue(new MatrixFormattedItem()
                    {
                        Color = i == j ? ConsoleColor.Red : ConsoleColor.White,                        
                        ItemString = j == _columns - 1 ? _array[i, j].ToString()+"\n" : _array[i, j].ToString()
                    });                    
                }
            }
            return matrixItems;
        }
        
        public string GetMatrixSnake()
        {             
            StringBuilder result = new StringBuilder("");
            int k = 1;
            int i = 0;
            int j = 0;
            int rowIndexStart = 0;
            int rowIndexEnd = 0;
            int columnIndexStart = 0;
            int columnIndexEnd = 0;

            while (k <= _rows * _columns)
            {
                result.Append(_array[i, j] + ";");

                if (i == rowIndexStart && j < _columns - columnIndexEnd - 1)
                {                                                                           
                    ++j;
                }
                else if (j == _columns - columnIndexEnd - 1 && i < _rows - rowIndexEnd - 1)
                {                                                                              
                    ++i;
                }
                else if (i == _rows - rowIndexEnd - 1 && j > columnIndexStart)
                {                                                                             
                    --j;
                }
                else
                {                                                                              
                    --i;
                }                

                if ((i == rowIndexStart + 1) && (j == columnIndexStart) && (columnIndexStart != _columns - columnIndexEnd - 1))
                {
                    ++rowIndexStart;
                    ++rowIndexEnd;
                    ++columnIndexStart;
                    ++columnIndexEnd;
                }
                ++k;
            }
            return result.ToString();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Random rnd = new Random();
                    _array[i, j] = rnd.Next(101);
                }
            }
        }

        private bool ValidateMinRowsColumns(int rows, int columns)
        {
            return rows >= 1 && columns >= 1;
        }
    }
}
