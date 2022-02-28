using System;

namespace Stack
{
    public class Stack
    {
        public Stack() {
            this.elements = new int[2];
            this.size = 0;
        }

        #region private attributes
        private int size;
        private int[] elements;
        #endregion
        public int Size { get { return size; } }
        public bool? IsEmpty()
        {
            return this.size == 0;
        }

        public void Push(int element)
        {
            this.elements[this.size++] = element;
        }

        public int Pop()
        {
            if (size == 0)
                throw new UnderflowException();

            return this.elements[--size];
        }
    }
}
