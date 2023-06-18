using System.Collections.Generic;

namespace HeavenLib
{
    public class NameGen
    {
        static readonly string mnpath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, @"HeavenLib\Names\", "MaleNames.txt");
        static readonly string mspath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, @"HeavenLib\Names\", "MaleSurnames.txt");
        static readonly string fnpath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, @"HeavenLib\Names\", "FemaleNames.txt");
        static readonly string fspath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, @"HeavenLib\Names\", "FemaleSurnames.txt");

        private static Random rnd = new();

        static string[] mNames = File.ReadAllLines(mnpath, System.Text.Encoding.UTF8);
        static string[] mSurnames = File.ReadAllLines(mspath, System.Text.Encoding.UTF8);
        static string[] fNames = File.ReadAllLines(fnpath, System.Text.Encoding.UTF8);
        static string[] fSurnames = File.ReadAllLines(fspath, System.Text.Encoding.UTF8);

        public static string GenerateFullName(bool isMale)
        {
            string name, surname;
            if (isMale) {
                name = mNames[rnd.Next(0, mNames.Length)];
                surname = mSurnames[rnd.Next(0, mSurnames.Length)];
                return name + " " + surname;
            }
            else {
                name = fNames[rnd.Next(0, fNames.Length)];
                surname = fSurnames[rnd.Next(0, fSurnames.Length)];
                return name + " " + surname;
            }
        }
        public static string GenerateName(bool isMale)
        {
            string name;
            if (isMale)
            {
                name = mNames[rnd.Next(0, mNames.Length)];
                return name;
            }
            else
            {
                name = fNames[rnd.Next(0, fNames.Length)];
                return name;
            }
        }
        public static string GenerateSurname(bool isMale)
        {
            string surname;
            if (isMale)
            {
                surname = mSurnames[rnd.Next(0, mSurnames.Length)];
                return surname;
            }
            else
            {
                surname = fSurnames[rnd.Next(0, fSurnames.Length)];
                return surname;
            }
        }

    }
}