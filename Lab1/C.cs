namespace Lab1
{
    public class C : B
    {
        public A SecondObject { get; set; }
        public A ThirdObject { get; set; }

        public C(A FirstObject, A SecondObject, A ThirdObject) : base(FirstObject)
        {
            this.SecondObject = SecondObject;
            this.ThirdObject = ThirdObject;
        }
    }
}
