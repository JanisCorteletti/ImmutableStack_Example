using System;
using System.Collections.Immutable;
using System.Linq;

namespace ImmutableStack_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //We also can use ImutableList, however instead of use Push, 
            //we have to use .Add() and .RemoveAt(1)
            var stack = ImmutableStack<int>.Empty;

            for (int i = 0; i < 10; i++)
            {
                stack = stack.Push(i);
            }
            Console.WriteLine("No of elements in original stack: " + stack.Count());

            var newStack = stack.Pop();
            Console.WriteLine("No of elements in new stack: " +
            newStack.Count());
            Console.ReadKey();

            //The ImmutableStack<T> can be used to push and pop elements much the same way we do with mutable stacks.
            //However, since ImmutableStack<T> is an immutable collection, its elements cannot be altered. 
            //So, when you make a call to the pop method to pop an element from the stack, 
            //a new stack is created for you and the original stack remains unaltered.
        }
    }
}
