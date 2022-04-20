// Задача 2. Шахматный конь стоит на поле с координатами (x1, y1).
// Сколько ходов ему потребуется сделать, чтобы забрать неподвижную фигуру на поле (x2, y2)?

// ДЕНИС, ЭТО РЕШЕНИЕ СВОРОВАЛ ИЗ ИНЕТРНЕТА. ДЛЯ СЕБЯ - ИЗУЧИТЬ НОВЫЕ ПРИЕМЫ

using System;


namespace Sem11_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int res = ChessTask(8, 1, 1, 8, 8);

        }
            /// <summary>
        /// задача о двух конях
        /// </summary>
        /// <param name="boardSize"> размер доски </param>
        /// <param name="x1"> координата X активного коня (отсчет от 1) </param>
        /// <param name="y1"> координата Y активного коня (отсчет от 1) </param>
        /// <param name="x2"> координата X пассивного коня (отсчет от 1) </param>
        /// <param name="y2"> координата Y пассивного коня (отсчет от 1) </param>
        /// <returns> номер хода или -1 в случае невозможности достигнуть коня </returns>
        static int ChessTask(int boardSize, int x1, int y1, int x2, int y2)
        {
            const int END = int.MaxValue;
 
            // преобразуем координаты
            x1--; y1--;
            x2--; y2--;
 
            // вспомогательные переменные
            int k = 1;
            bool canMove = true;
            bool finish = false;
 
            // создаем доску
            int[,] board = new int[boardSize, boardSize];
 
            // функция хода
            Action<int, int> step = new Action<int, int>((x, y) =>
            {
                if (x >= 0 && y >= 0 && x < boardSize && y < boardSize)
                {
                    if (board[x, y] == 0)
                    {
                        // сюда еще не ходили
                        board[x, y] = k + 1;
 
                        // запоминаем, что ход был совершен
                        canMove = true;
                    }
                    else if (board[x, y] == END)
                    {
                        // конец
                        finish = true;
                    }
                }
            });
 
            // помещаем коней
            board[x1, y1] = k;
            board[x2, y2] = END;
 
            // начинаем ходить
            while (canMove)
            {
                canMove = false;
 
                for (int x = 0; x < boardSize; x++)
                {
                    for (int y = 0; y < boardSize; y++)
                    {
                        if (board[x, y] == k)
                        {
                            // сюда можно попасть конем на [k-1] ходе
 
                            // рассматриваем возможные ходы
                            step(x - 2, y - 1);
                            step(x - 1, y - 2);
                            step(x + 1, y - 2);
                            step(x + 2, y - 1);
                            step(x + 2, y + 1);
                            step(x + 1, y + 2);
                            step(x - 1, y + 2);
                            step(x - 2, y + 1);
                        }
                    }
                }
 
                if (finish)
                {
                    // конец
                    return k;
                }
 
                k++;
            }
 
            // достичь коня невозможно
            return -1;
        }
        
    }
}




