using System;

namespace Stack
{
    public class Stack
    {
        public Stack() {
            this.size = 0;
        }
        
        #region private attributes
        private int size;
        private int element;
        #endregion
        public int Size { get { return size; } }
        public bool? IsEmpty()
        {
            return this.size == 0;
        }

        public void Push(int element)
        {
            this.size++;
            this.element = element;
            
        }

        public int Pop()
        {
            if (size == 0)
                throw new UnderflowException();
            else
            {
                --this.size;
                return this.element;
            }
        }
    }
}
