using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

    }


    //   public class MyList1 : ILinkedList
    //{
    //    public Node lastNode;
    //    public Node startNode;
       

       



    //    public void AddNode(int value)
    //    {
    //        // добавление новой ноды после последней ноды
    //        var node = lastNode; // присваиваем переменной последнюю ноду 
    //        var newNode = new Node { Value = value }; // создаем новую ноду с заданным значением
    //        node.NextNode = newNode; // задаем бывшей последней ноде ссылку на новую ноду
    //        newNode.PrevNode = node; // добавление в новую ноду ссылки на бывшую последнюю
          
    //        lastNode = newNode; // определение новой ноды в качестве последней
    //    }

    //    public void AddNodeAfter(Node node, int value) // добавление после любого элемента
    //    {
    //        if (node == lastNode) // если вставка после последней ноды
    //        {
    //            AddNode(value);
    //        }
            
    //        // если вставка после любой другой ноды
    //        var newNode = new Node { Value = value };// создание ноды с заданным значением
    //        var nextItem = node.NextNode; // переменная, в которой хранится нода, следующая за той, после которой нужно вставить новую
    //        node.NextNode = newNode; // замена указателя на новую ноду после той, после которой надо вставить ее
    //        newNode.NextNode = nextItem; // добавление в новую ноду указателя на следующую
    //        newNode.PrevNode = node; // добавление в новую ноду ссылки на ту, после которой ее вставили
    //        nextItem.PrevNode = newNode; // добавление в следующую ноду ссылки на новую 
    //    }

    //    public Node FindNode(int searchValue) // поиск элемента с определенным значением
    //    {
            


    //        return null; // если ничего не нашли, возвращаем null
    //    }

    //    public int GetCount() // возвращает количество элементов в списке
    //    {
    //        var currentNode = startNode; // начиная с первой ноды
    //        int n = 1; // счетчик количества
    //        while (currentNode != null) // последовательный обход списка начиная с первой ноды
    //        {
               
    //            currentNode = currentNode.NextNode; // переход к следующему элементу в списке
    //            n++; // увеличение счетчика на 1
    //        }

    //        return n; // возвращает значение счетчика
    //    }

    //    public void RemoveNode(int index) // удаление ноды по индексу

    //    {
            
    //        // ищем ноду по индексу
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
                
    //        }


    //    }

    //    public void RemoveNode(Node node) // удаляет указанный элемент
    //    {
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

    //    public override bool Equals(object obj)
    //    {
    //        return obj is MyList list &&
    //               EqualityComparer<Node>.Default.Equals(startNode, list.startNode);
    //    }
    //}

    //public interface ILinkedList
    {
        int GetCount();
        void AddNode(int value);
        void AddNodeAfter(Node node, int value);
        void RemoveNode(int index);
        void RemoveNode(Node node);
        Node FindNode(int searchValue);
    }
}
