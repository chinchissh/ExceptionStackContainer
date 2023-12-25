using System;

namespace ExceptionStackContainer
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Создание экземпляра контейнера StackContainer с типом int, объемом 5 и диапазоном от 1 до 10
                StackContainer stack = new StackContainer(5, 2, 10);

                // Добавление элементов в стек
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Push(6);

                // Вывод извлеченного элемента на консоль
                Console.WriteLine("Извлеченный элемент: " + stack.Pop());

                // Вывод элемента по индексу 1 на консоль
                Console.WriteLine("Элемент по индексу 1: " + stack[1]);

                // Использование метода поиска по индексу
                int element = 3;
                int index = stack.FindIndex(element);

                if (index != -1)
                {
                    Console.WriteLine($"Элемент {element} найден по индексу: {index}");
                }
                else
                {
                    Console.WriteLine($"Элемент {element} не найден.");
                }

                // Попытка доступа к элементу по некорректному индексу
                Console.WriteLine("Элемент по индексу 6: " + stack[6]);
            }
            //ContainerException является производным от Exception, и если поменять порядок блоков catch,
            //то блок catch (Exception ex) будет "поглощать" все исключения, включая те, которые являются подклассами ContainerException.
            //В этом случае блок catch (ContainerException ex) никогда не выполнится,
            //потому что все исключения этого типа будут обработаны более общим блоком catch (Exception ex).
            catch (ContainerException ex)
            {
                // Обработка исключения типа ContainerException (включая его производные классы)
                Console.WriteLine("Исключение контейнера: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка неожиданных исключений (не связанных с контейнером)
                Console.WriteLine("Неожиданное исключение: " + ex.Message);
            }
        }
    }
}