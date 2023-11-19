namespace HardwareStore.Infrastructure.Seed
{
    using Newtonsoft.Json;

    public static class FileReader
    {
        public static IEnumerable<T> LoadJson<T>(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(json)!;
            }
        }

        public static string[] GetFilesNames(string jsonFileTemplate)
        {
            var importsPath = Path.Combine(Environment.CurrentDirectory, "..", "HardwareStore.Infrastructure.Seed", "Imports");
            var fileNames = Directory.GetFiles(importsPath, jsonFileTemplate);

            return fileNames.ToArray();
        }
    }
}
