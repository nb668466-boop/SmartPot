namespace SmartPot
{
    internal class Program
    {
        public delegate void MyDelegate(string nameDiah, int minutes);
        public event MyDelegate OnDishReady;

        static void Main(string[] args)
        {
            Smartpot s1=new Smartpot();
            Chef c1 = new Chef();

       
            s1.OnDishReady += c1.TakeOffStove;
            s1.OnDishReady += (string nameDiah, int minutes)=>{ Console.WriteLine("Food’s ready!"); };
            s1.StartCooking("piza", 39);
            s1.OnDishReady += s1.StartCooking;
            s1.OnDishReady -= c1.TakeOffStove;
            c1.TakeOffStove("coffee", 39);



        }
    }
}
