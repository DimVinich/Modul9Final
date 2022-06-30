using System;

namespace Modul9Final
{

    public delegate void Notify();

    internal class Program
    {

        static void Main(string[] args)
        {
            int sort = -1;
            var arrExcetion = new Exception[]
            { new MyException(), new ArgumentNullException(), new DivideByZeroException(),
                new ArgumentOutOfRangeException(), new NotImplementedException() 
            };
            string[] arrF = { "Иванов", "Петров", "Сидоров", "Козлов", "Деточкин" };
            SortStrArr sortStrArr = new SortStrArr();
            EventServer eventServer = new EventServer();

            eventServer.arrToSort += sortStrArr.SortArr;

            //  Вывод не сортированного массива
            PrintArr.PrintArrToConsol(arrF);

            // Ввод порядка сортировки с проверками
            try
            {
                Console.WriteLine($"Введите порядок сортировки массива. \n 1 - Сортировка А - Я\n 2 - Сортировка Я - А");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out sort))
                {
                    throw new MyException("Введено не числовое значение.");
                }

                if ( sort != 1 && sort !=2 )
                {
                    throw new MyException("Допустимыми значениями для работы программы являются 1 или 2");
                }


            }
            catch (MyException myException)
            {
                Console.WriteLine($"Произошла ошибка. {myException.Message}");
                Console.WriteLine($"Подробности ошибки. {myException}");
            }
            catch (ArgumentNullException argNullEx)
            {
                Console.WriteLine($"Произошла ошибка. {argNullEx.Message}");
                Console.WriteLine($"Подробности ошибки. {argNullEx}");
            }
            catch (DivideByZeroException divZer)
            {
                Console.WriteLine($"Произошла ошибка. {divZer.Message}");
                Console.WriteLine($"Подробности ошибки. {divZer}");
            }
            catch (ArgumentOutOfRangeException outRang)
            {
                Console.WriteLine($"Произошла ошибка. {outRang.Message}");
                Console.WriteLine($"Подробности ошибки. {outRang}");
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine($"Произошла ошибка. {notImp.Message}");
                Console.WriteLine($"Подробности ошибки. {notImp}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка. {ex.Message}");
                Console.WriteLine($"Подробности ошибки. {ex}");
            }
            finally
            {
                Console.WriteLine($"Блок обработки исключений отработал");
            }

            //  Вызов сортировки через событие


            //  Вывод сортированного массива
            PrintArr.PrintArrToConsol(arrF);

            Console.ReadKey();
        }

    }
}
