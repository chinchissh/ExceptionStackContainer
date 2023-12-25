using System;

namespace ExceptionStackContainer
{
    // Базовый класс для исключений, связанных с контейнером
    public class ContainerException : Exception
    {
        // Конструктор класса, принимающий сообщение об ошибке
        public ContainerException(string message) : base(message)
        {
        }
    }

    // Класс исключения для ошибок, связанных с объемом контейнера
    public class ContainerVolumeException : ContainerException
    {
        // Конструктор класса, передающий сообщение родительскому классу
        public ContainerVolumeException(string message) : base(message)
        {
        }
    }

    // Класс исключения для ошибок переполнения контейнера
    public class ContainerOverflowException : ContainerVolumeException
    {
        // Конструктор класса, передающий сообщение родительскому классу
        public ContainerOverflowException(string message) : base(message)
        {
        }
    }

    // Класс исключения для ошибок недостатка элементов в контейнере
    public class ContainerUnderflowException : ContainerVolumeException
    {
        // Конструктор класса, передающий сообщение родительскому классу
        public ContainerUnderflowException(string message) : base(message)
        {
        }
    }

    // Класс исключения для ошибок некорректного индекса
    public class InvalidIndexException : ContainerException
    {
        // Конструктор класса, передающий сообщение родительскому классу
        public InvalidIndexException(string message) : base(message)
        {
        }
    }

    // Класс исключения для ошибок, связанных с диапазоном значений
    public class ContainerOutOfRangeException : ContainerException
    {
        // Конструктор класса, передающий сообщение родительскому классу
        public ContainerOutOfRangeException(string message) : base(message)
        {
        }
    }
}