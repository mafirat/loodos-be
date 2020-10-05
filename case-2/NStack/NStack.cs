using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NStack
{
  public class NStack
  {
    public object[] arr; // n size item array
    public int[] top; // stack head
    public int[] next; // top map for stacks
    public int n, k;
    public int free; // beginning index of free list 

    public NStack(int arraySize, int stackCount = 3)
    {
      // memory allocation
      k = stackCount;
      n = arraySize;
      arr = new object[n];
      top = new int[k];
      next = new int[n];

      #region InitEmtpy
      for (int i = 0; i < k; i++)
      {
        top[i] = -1;
      }
      #endregion

      #region freedAllSpaces
      free = 0;
      for (int i = 0; i < n - 1; i++)
      {
        next[i] = i + 1;
      }
      next[n - 1] = -1;
      #endregion
    }

    /// <summary>
    /// Check Free space
    /// </summary>
    /// <returns>True or False</returns>
    public bool IsFull()
    {
      return (free == -1);
    }

    /// <summary>
    /// add item to stack with stack number
    /// </summary>
    public void Push(object item, int stackNumber)
    {
      if (IsFull())
      {
        Console.WriteLine("Stack Overflow");
        return;
      }

      int i = free;

      free = next[i];

      next[i] = top[stackNumber];
      top[stackNumber] = i;

      arr[i] = item;
    }

    /// <summary>
    /// Pop an item from stack
    /// </summary>
    /// <returns></returns>
    public object Pop(int stackNumber)
    {
      if (IsEmpty(stackNumber))
      {
        Console.WriteLine("Stack Underflow");
        return int.MaxValue;
      }

      int i = top[stackNumber];

      top[stackNumber] = next[i];
      next[i] = free;
      free = i;

      // Return the previous top item 
      var s = arr[i];
      // arr[i] = null; to clear
      return s;
    }

    public bool IsEmpty(int stacknumber)
    {
      return (top[stacknumber] == -1);
    }

    public void Print()
    {
      foreach (var item in arr)
      {
        Console.Write($"{item} | ");

      }
      Console.WriteLine();
    }

  }
}