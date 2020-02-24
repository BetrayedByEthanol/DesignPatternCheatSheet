using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCheatSheet.CreationPatterns.ObjectPool
{
    public class ObjectPool<T> where T : new()
    {
        private Queue<T>  queue { get; set; }
        public readonly int Size;

        public ObjectPool(int size)
        {
            Size = size;
        }

        public T get()
        {
            if(queue.Count == Size)
            {
                return queue.Dequeue();
            }
            else
            {
                T t = new T();
                queue.Enqueue(t);
                return t;
            }
        }

        public void release(T item)
        {
            queue.Enqueue(item);
        }
    }
}
