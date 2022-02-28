using System;

namespace Stack
{
    public class Stack
    {
        public Stack() {
            this.empty = true;
        }
        
        #region private attributes
        private bool empty;

        public  int Size { get { return 2; } }
        #endregion
        public bool? IsEmpty()
        {
            return this.empty;
        }

        public void Push(int v)
        {
            this.empty = false;
        }

        public void Pop()
        {
            this.empty = true;
        }
    }
}
