using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikiSayaka
{
    class Test
    {
        static void Main()
        {
            Mikisayaka sayakasan = new Mikisayaka();

            System.Console.WriteLine("名前は" + sayakasan.Name);

            Console.ReadKey();

            System.Console.WriteLine("さやかさん、何か喋ってください");

            sayakasan.SaySomething();

            Console.ReadKey();

            System.Console.WriteLine( "生存=" + sayakasan.IsLive + "  人間=" + sayakasan.IsHuman );

            Console.ReadKey();

            System.Console.WriteLine("さやかさんは絶望した");

            sayakasan.Despair();

            System.Console.WriteLine("生存=" + sayakasan.IsLive + "  人間=" + sayakasan.IsHuman );

            Console.ReadKey();
        }
    }
}
