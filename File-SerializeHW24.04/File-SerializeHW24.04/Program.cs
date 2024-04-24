using Newtonsoft.Json;

namespace File_SerializeHW24._04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Add("Anar");
            Add("Nurlan");
           
        }

       
        public static void Add(string name)
        {

            List<string> names = Deserialize(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json");
            names.Add(name);
            Serialize(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json", names);

        }

        public static bool Search(string name)
        {

            List<string> names = Deserialize(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json""");

            if (names.Contains(name))
            return true;
            else
            return false;
            

            Serialize<List<string>>(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json""", names);
        }
        public static void Delete(string name)
        {

            List<string> names = Deserialize(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json");
            if (names.Contains(name))
            {
                names.Remove(name);

                Console.WriteLine($"{name}- deleted");
            }

            Serialize<List<string>>(@"C:\Users\ASUS\OneDrive\İş masası\CodeAcademy Tasks\File-SerializeHW24.04\File-SerializeHW24.04\Files\file.json", names);

        }
        public static List<string> Deserialize(string path)
        {
            string result;


            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
    }
}
