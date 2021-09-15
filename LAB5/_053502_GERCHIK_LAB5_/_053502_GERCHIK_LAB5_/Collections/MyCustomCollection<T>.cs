using System;
using System.Collections.Generic;
using _053502_GERCHIK_LAB5_.Entities;
using _053502_GERCHIK_LAB5_.Interfaces;

namespace _053502_GERCHIK_LAB5_.Collections
{
    public class MyCustomCollection<T> : ICustomInterface<T>
    {
        private MyNode<T> _headElement = null;
        private MyNode<T> _tailElement;
        private MyNode<T> _cursor;

        public MyCustomCollection()
        {
            _cursor = _headElement;
        }

        // https://stackoverflow.com/questions/390900/cant-operator-be-applied-to-generic-types-in-c
        public bool Compare<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }


        public T this[int index] // индексатор коллекции
        {
            get
            {
                int _tempCounter = 0;
                MyNode<T> tempElement = _headElement;
                while (_tempCounter != index)
                {
                    tempElement = tempElement.PointerToNext;
                    _tempCounter++;
                }

                return tempElement.Item;
            }

            set
            {
                int _tempCounter = 0;
                MyNode<T> tempElement = _headElement;
                while (_tempCounter != index)
                {
                    tempElement = tempElement.PointerToNext;
                }

                tempElement.Item = value;
            }
        }

        public int Count { get; set; } //свойство, возвращает количество элементов в коллекции

        public void Reset() // метод, устанавливает курсор в начало коллекции
        {
            _cursor = _headElement;
        }

        public void Next() // метод, перемещает курсор на следующий элемент коллекции
        {
            _cursor = _cursor.PointerToNext;
        }

        public T Current() //метод, возвращает элемент текущего положения курсора
        {
            return _cursor.Item;
        }

        public void Add(T itemToAdd) //метод, добавляет объект item в конец коллекции // add cursor moving
        {
            MyNode<T> nodeToAdd = new MyNode<T>();
            nodeToAdd.Item = itemToAdd;
            if (_headElement == null)
            {
                _headElement = nodeToAdd;
                _tailElement = nodeToAdd;
                nodeToAdd.PointerToNext = null;
                _cursor = _headElement;
            }
            else
            {
                MyNode<T> current = _tailElement;
                current.PointerToNext = nodeToAdd;
                _tailElement = nodeToAdd;
                _tailElement.PointerToNext = null;
                _cursor = _tailElement;
            }

            Count++;
        }

        public void Remove(T itemToDelete) //метод, удаляет объект item из коллекции
        {
            MyNode<T> nodeToDelete = new MyNode<T>();
            nodeToDelete.Item = itemToDelete;

            MyNode<T> tempNode = _headElement;
            MyNode<T> previousTempNode = null;

            while (tempNode != null)
            {
                if (Compare(nodeToDelete.Item, tempNode.Item))
                {
                    if (tempNode.PointerToNext == null && tempNode == _headElement)
                    {
                        _headElement = null;
                        _tailElement = null;
                        Count--;
                        return;
                    }

                    if (tempNode == _headElement)
                    {
                        _headElement = tempNode.PointerToNext;
                        Count--;
                        return;
                    }

                    if (tempNode == _tailElement)
                    {
                        _tailElement = previousTempNode;
                        if (_tailElement != null)
                        {
                            _tailElement.PointerToNext = null;
                        }

                        Count--;
                        return;
                    }

                    else
                    {
                        if (previousTempNode != null)
                        {
                            previousTempNode.PointerToNext = tempNode.PointerToNext;
                        }

                        Count--;
                        return;
                    }
                }
                else
                {
                    previousTempNode = tempNode;
                    tempNode = tempNode.PointerToNext;
                }
            }
        }

        public void RemoveCurrent() //метод, удаляет элемент текущего положения курсора
        {
            if (_cursor == _headElement)
            {
                _headElement = _headElement.PointerToNext;
                _cursor = _headElement;
                Count--;
                return;
            }

            MyNode<T> previousNode = _headElement;
            while (previousNode != null)
            {
                if (previousNode.PointerToNext == _cursor)
                {
                    MyNode<T> nextNode = _cursor.PointerToNext;
                    _cursor = previousNode;
                    _cursor.PointerToNext = nextNode;
                    Count--;
                    return;
                }
                else
                {
                    previousNode = previousNode.PointerToNext;
                }
            }
        }
    }
}