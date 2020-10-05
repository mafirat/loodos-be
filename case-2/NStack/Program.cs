using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NStack
{
  class Program
  {
    static void Main(string[] args)
    {
      int k = 3, n = 15;

      var nStack = new NStack(n, k);

      
      nStack.Push(false, 0);

      nStack.Push(true, 0);
      nStack.Push('s', 0);
      nStack.Push("Sic mundus", 1);
      nStack.Push("creatus", 1);
      nStack.Push("est", 1);
      nStack.Push(1003, 2);
      nStack.Push(1002, 2);
      nStack.Push(1001, 2);

      nStack.Print();

      Console.WriteLine($"Popped {nStack.Pop(2)} from stack 2 ");
      Console.WriteLine($"Popped {nStack.Pop(2)} from stack 2 ");
      Console.WriteLine($"Popped {nStack.Pop(1)} from stack 1 ");
      Console.WriteLine($"Popped {nStack.Pop(0)} from stack 0 ");
      Console.WriteLine($"Popped {nStack.Pop(1)} from stack 1 ");
      Console.WriteLine($"Popped {nStack.Pop(0)} from stack 0 ");
      nStack.Print();
    }
  }
}
