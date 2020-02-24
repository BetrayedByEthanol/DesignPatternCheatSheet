using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternCheatSheet.CreationPatterns.ObjectPool
{
    public class ObjectPoolExample
    {
        public void test()
        {
            Random rng = new Random();
            ObjectPool<Spark> sparkPool = new ObjectPool<Spark>(50);

            for(int i = 0; i < rng.Next(sparkPool.Size); i++)
            {
                Spark spark = sparkPool.get();
                ThreadStart start = spark.randomlyFlyAround;
                start += () =>
                {
                    sparkPool.release(spark);
                };
                Thread thread = new Thread(start);
                thread.Start();
                
            }
        }
    }
}
