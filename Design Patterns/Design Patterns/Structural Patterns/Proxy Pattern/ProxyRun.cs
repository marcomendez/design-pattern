using System;

namespace Design_Patterns.Structural_Patterns.Proxy_Pattern
{
    public class ProxyRun
    {
        public void run()
        {
            Console.WriteLine("************************** ProxyRun pattern **********************************");

            Image image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.display();
        }
    }
}
