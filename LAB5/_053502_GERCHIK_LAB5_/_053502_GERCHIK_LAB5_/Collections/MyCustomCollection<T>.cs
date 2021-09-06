using System;
using _053502_GERCHIK_LAB5_.Interfaces;

namespace _053502_GERCHIK_LAB5_.Collections
{
    public class MyCustomCollection<T> : ICustomInterface<T>
    {
        private MyNode<T> _headElement = null;
        private MyNode<T> _tailElement;


        public T this[int index] // индексатор коллекции
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
        
        public int Count { get; set; } //свойство, возвращает количество элементов в коллекции

        public void Reset() // метод, устанавливает курсор в начало коллекции
        {
            throw new System.NotImplementedException();
        }

        public void Next() // метод, перемещает курсор на следующий элемент коллекции
        {
            throw new System.NotImplementedException();
        }

        public T Current() //метод, возвращает элемент текущего положения курсора
        {
            throw new System.NotImplementedException();
        }

        public void Add(T item) //метод, добавляет объект item в конец коллекции
        {
            MyNode<T> nodeToAdd = new MyNode<T>();
            nodeToAdd.Item = item;
            if (_headElement == null)
            {
                _headElement = nodeToAdd;
                _tailElement = nodeToAdd;
                nodeToAdd.PointerToNext = null;
            }
            else
            {
                MyNode<T> current = _tailElement;
                current.PointerToNext = nodeToAdd;
                _tailElement = nodeToAdd;
                _tailElement.PointerToNext = null;
            }
        }

        public void Remove(T item) //метод, удаляет объект item из коллекции
        {
            
        }

        public T RemoveCurrent() //метод, удаляет элемент текущего положения курсора
        {
            throw new System.NotImplementedException();
        }
    }
}