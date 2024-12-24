namespace TestProjectDecBatchEGIndia
{
    public class Tests
    {
        [Test, Order(1)]
        public void reg()
        {
            Console.WriteLine("USer regidtration completed");
        }

        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("login");
        }

        [Test, Order(3)]
        public void product()
        {
            Console.WriteLine("Product");
        }

        [Test, Order(4)]
        [Ignore("Defect ID 34556")]
        public void order()
        {
            Console.WriteLine("Order");
        }
    }
}