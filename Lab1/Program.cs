namespace Lab1
{
    class Program
    {
        // 12 вариант.
        static A GetTree()
        {
            A temp = new A();

            return new C(temp, new A(), new B(new B(temp)));
        }

        static void Main(string[] args)
        {
            A tree = GetTree();
        }
    }
}
