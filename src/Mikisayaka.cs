using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikiSayaka
{
    class Mikisayaka
    {
        string firstname = "さやか";
        string lastname = "美樹";
        public string Name
        {
            get { return lastname+firstname; }
        }

        int age = 14;
        public int Age
        {
            get { return age; }
        }

        bool is_human = true;
        public bool IsHuman
        {
            get { return is_human; }
        }

        bool is_live = true;
        public bool IsLive
        {
            get { return is_live; }
        }

        string witch_name = "Oktavia von Seckendorff";

        float distance_to_soulgem = 0f;

        string[] serihu = { "あたしってホントバカ", "舞い上がっちゃってますね、私！" };
        //何か喋る
        public void SaySomething()
        {
            Random rnd = new Random();
            int rnd_num = rnd.Next(serihu.Length);

            System.Console.WriteLine( serihu[rnd_num] );
        }

        //絶望
        public void Despair()
        {
            is_human = false;
            is_live = false;
        }

        //ソウルジェム投げる
        public void ThrowedSoulgem()
        {
            distance_to_soulgem = 100f;

            is_live = false;
        }
    }
}
