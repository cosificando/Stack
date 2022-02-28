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
        #endregion
        public bool? IsEmpty()
        {
            return this.empty;
        }

        public void Push(int v)
        {
            this.empty = false;
        }
    }
}
