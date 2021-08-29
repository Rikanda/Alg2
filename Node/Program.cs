using System;
using System.Collections.Generic;
namespace Node
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node {Value = 5, NextNode = null, PrevNode = null};

            
          
           
           

            var currentNode = node1;
           
            while (currentNode != null) // последовательный обход списка начиная с первой ноды
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.NextNode; // переход к следующему элементу в списке
       
            }

        }



        }
    }
}
