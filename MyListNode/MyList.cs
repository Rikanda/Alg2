using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListNode
{
    public class MyList : ILinkedList
    {

        Node startNode = null;
        Node lastNode = null;
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value }; // создаем новую ноду с заданным значением
            if (lastNode != null)
            {
                var node = lastNode; // присваиваем переменной последнюю ноду 

                node.NextNode = newNode; // задаем бывшей последней ноде ссылку на новую ноду
                newNode.PrevNode = node; // добавление в новую ноду ссылки на бывшую последнюю
                lastNode = newNode; // определение новой ноды в качестве последней
            }

            else
            {
                lastNode = newNode;
                startNode = newNode;
            }
                  
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == lastNode) // если вставка после последней ноды
           {
               AddNode(value);
            }

                       // если вставка после любой другой ноды
              var newNode = new Node { Value = value };// создание ноды с заданным значением
              var nextItem = node.NextNode; // переменная, в которой хранится нода, следующая за той, после которой нужно вставить новую
              node.NextNode = newNode; // замена указателя на новую ноду после той, после которой надо вставить ее
              newNode.NextNode = nextItem; // добавление в новую ноду указателя на следующую
              newNode.PrevNode = node; // добавление в новую ноду ссылки на ту, после которой ее вставили
              nextItem.PrevNode = newNode; // добавление в следующую ноду ссылки на новую 
        }
        

        public Node FindNode(int searchValue)
        {
            if (startNode == null)
            {
              
                return null; // если список пустой, возвращаем null
            }

            var currentNode = startNode;
           
            while (currentNode != null) // обходим все значения, пока не дойдем до конца
            {
                if (currentNode.Value==searchValue)
                {
                    return currentNode; // возвращаем ноду, если ее значение равно искомому
                }

                currentNode = currentNode.NextNode;
            }
            return null; // если ничего не нашли, возвращаем null
        }
    

        public int GetCount()
        {
            if (startNode == null) // если список пустой, возвращаем 0
                return 0;

            var currentNode = startNode; // начиная с первой ноды
                     int n = 0; // счетчик количества
                     while (currentNode != null) // последовательный обход списка начиная с первой ноды
            {

                     currentNode = currentNode.NextNode; // переход к следующему элементу в списке
                     n++; // увеличение счетчика на 1
             }

                   return n; // возвращает значение счетчика
        }

        public void RemoveNode(int index)
        {
            if (startNode == null) // если список пустой
                return;
                
            // иначе ищем ноду по индексу
                int i = 0; // переменная для индекса текущей ноды
            var currentNode = startNode; // переменная для текущей ноды, начиная со стартовой
            while (currentNode != null) // последовательный обход списка начиная с первой ноды
            {
                if (i == index) // если текущий индекс равен искомому 
                {
                    RemoveNode(currentNode); // вызываем функцию удаления текущего элемента
                    
                }

                i++; // инкремент счетчика индекса
                currentNode = currentNode.NextNode; // переход к следующему элементу в списке
            }

        }

        public void RemoveNode(Node node)
        {
            if (startNode == null) // если список пустой
                return;

            if (startNode == lastNode) // если в списке 1 элемент, делаем список пустым
            {
                startNode = null;
                lastNode = null;
                return;
            }

            if (node == lastNode) // если элемент последний
            {
                var newlastNode = node.PrevNode; // делаем последним предпоследний элемент
                newlastNode.NextNode = null; // переопределяем ссылку
                lastNode = newlastNode; // записываем новый последний элемент как последний

                return;
            }

            if (node == startNode) // если элемент первый
            {
                var newstartNode = node.NextNode; // делаем первым следующий элемент
                newstartNode.PrevNode = null; // переопределяем ссылку
                startNode = newstartNode; // записываем новый первый элемент как первый

                return;
            }

            // во всех остальных случаях
            var prevItem = node.PrevNode; // предшествующий элемент
            var nextItem = node.NextNode; // последующий элемент
            prevItem.NextNode = node.NextNode; // переопределение ссылки предшествующего элемента на последующий
            nextItem.PrevNode = node.PrevNode; // переопределение ссылки последующего элемента на предшествующий
        }

        public void WriteList() // вывод списка в консоль для проверки операций
        {
            if (startNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var currentNode = startNode;
            Console.WriteLine();
            while(currentNode!=null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.NextNode;
            }
        }
    }

    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

}
