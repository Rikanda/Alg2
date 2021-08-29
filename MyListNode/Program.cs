using System;

namespace MyListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            

            MyList TestList = new MyList();
            TestList.WriteList();


            // добавляем ноды в список
            TestList.AddNode(9);
            TestList.AddNode(14);
            TestList.AddNode(5);
            TestList.AddNode(7);
            TestList.AddNode(16);
            TestList.AddNode(25);
            TestList.WriteList();

            Console.WriteLine();
            Console.WriteLine("В списке элементов: " + TestList.GetCount());

            // ищем элемент со значением 7 и вставляем после него значение 112
            Node searchNode = TestList.FindNode(7);
            TestList.AddNodeAfter(searchNode, 112);
            TestList.WriteList();

            // удаляем 1й элемент
            TestList.RemoveNode(0);
            TestList.WriteList();

            // удаляем 5й элемент, который имеет индекс = 4 т.к. счетчик индексов идет с 0
            TestList.RemoveNode(4);
            TestList.WriteList();

            // ищем элемент со значением 25 и удаляем его
            searchNode = TestList.FindNode(25);
            TestList.RemoveNode(searchNode);
            TestList.WriteList();

        }
    }
}
