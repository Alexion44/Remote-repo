    static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            t.IsBackground = true;
            t.Start();

            for (int i = 0; i < 200; i++) Console.WriteLine("ForeGround"+i);
        }
        static void Go()
        {
            for (int i = 0; i < 200; i++) Console.WriteLine("BackGround"+i);
        }