using System;
using System.Collections.Generic;

namespace ExceptionStackContainer
{
    public class StackContainer
    {
        private List<int> items;  // Хранение элементов контейнера
        private int capacity;     // Максимальная вместимость контейнера
        private int minValue;     // Минимальное значение элемента
        private int maxValue;     // Максимальное значение элемента

        // Конструктор класса, инициализирующий контейнер с указанными ограничениями.
        public StackContainer(int capacity = 5, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            // Проверка на корректность входных параметров конструктора.
            if (capacity <= 0 || minValue >= maxValue)
            {
                throw new ArgumentException("Объем должен быть больше нуля, а минимальное значение должно быть меньше максимального.");
            }

            // Инициализация полей класса.
            this.capacity = capacity;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.items = new List<int>(capacity);
        }

        // Метод для добавления элемента в контейнер
        public void Push(int item)
        {
            // Проверка на переполнение контейнера.
            if (items.Count == capacity)
            {
                throw new ContainerOverflowException("Стек полон. Невозможно добавить больше элементов.");
            }

            // Проверка на соответствие добавляемого элемента заданному диапазону.
            if (item < minValue || item > maxValue)
            {
                throw new ArgumentOutOfRangeException("Добавляемый элемент выходит за пределы заданного диапазона.");
            }

            // Добавление элемента в стек.
            items.Add(item);
        }

        // Метод для извлечения элемента из контейнера (взять с вершины стека).
        public int Pop()
        {
            // Проверка на недостаток элементов в контейнере.
            if (items.Count == 0)
            {
                throw new ContainerUnderflowException("Стек пуст. Невозможно извлечь элементы.");
            }

            // Извлечение элемента с вершины стека.
            int poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return poppedItem;
        }

        // Метод для поиска индекса элемента в контейнере.
        public int FindIndex(int item)
        {
            int index = items.IndexOf(item);
            return index;
        }

        // Индексатор для доступа к элементу по индексу.
        public int this[int index]
        {
            get
            {
                // Проверка на корректность индекса.
                if (index < 0 || index >= items.Count)
                {
                    throw new InvalidIndexException("Некорректный индекс.");
                }

                // Возвращение элемента по указанному индексу.
                return items[index];
            }
        }
    }
}