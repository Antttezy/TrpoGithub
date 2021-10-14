namespace Lab1
{
    public class B : A
    {
        public A FirstObject { get; set; }

        public B(A FirstObject)
        {
            this.FirstObject = FirstObject;
        }
    }
}
