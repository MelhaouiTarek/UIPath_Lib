using System;


namespace Company.Product1.Activities
{
    class CustomException : Exception
    {
        private int Code;

        private CustomException()
            : base()
        {
            Code = -1;
        }
        public CustomException(String Message)
        : base(Message)
        {
            Code = -1;
        }
        public CustomException(String Message, int Code)
            : base(Message)
        {
            this.Code = Code;
        }

    }
}
