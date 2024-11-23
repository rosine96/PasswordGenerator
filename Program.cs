namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random random = new Random();
            IList<char> list = new List<char>();
            Console.WriteLine(@"bienvenue dans PasswordGenerator!
               vous souhaitez generer un mot de passe de combien de caractere
                (sachant que le minimum de caractere est 4");
            n=int.Parse(Console.ReadLine());
            if (n >=4)
            {
                while (list.Count <n)
                {

                    list.Add((char)random.Next(49,58));
                    list.Add((char)random.Next(65,90));
                    list.Add((char)random.Next(97,122));
                    list.Add((char)random.Next(32,47));
                }
                Console.WriteLine(list.Count);
                if (list.Count > n)
                    
                {
                    int surplus = list.Count - n;
                    for (int i = 0; i < surplus; i++)
                    {
                        list.RemoveAt(list.Count - 1); // Supprime le dernier élément à chaque itération
                    }
                }
                Console.WriteLine("votre mot de passe est:");
                foreach (char c in list)
                    Console.Write(c);
            }
            else
            {
                Console.WriteLine("pour plus de precaution la longueur du mot de " +
                    "passe doit etre superieur ou egal a 4");
            }
        }
    }
}