using Design_Patterns.Abstract_Factory_Pattern;
using Design_Patterns.Creational_Patterns.Builder_Pattern;
using Design_Patterns.Creational_Patterns.Factory_Method;
using Design_Patterns.Creational_Patterns.Prototype_pattern;
using Design_Patterns.Structural_Patterns.Adapter;
using Design_Patterns.Structural_Patterns.Brigde_Pattern;
using Design_Patterns.Structural_Patterns.Composite_Pattern;
using Design_Patterns.Structural_Patterns.Decorator_Pattern;
using Design_Patterns.Structural_Patterns.Facade_Pattern;
using Design_Patterns.Structural_Patterns.Fyweight_Pattern;
using Design_Patterns.Structural_Patterns.Proxy_Pattern;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // ** Creatinal **
            new RunAbstactFactory().Run();

            new RunBuilder().Run();

            new RunFactory().run();

            new PrototypePatternRun().run();

            // new Singleton().run() --> there is not run class because this pattern is easy.


            // ** Structural **
            new AdapterRun().run();

            new BridgeRun().run();

            new CompositePatternRun().run();
            
            new DecoratorRun().run();

            new FacadeRun().run();

            new FlyweightRun().run();

            new ProxyRun().run();

            Console.ReadLine();
        }
    }
}
