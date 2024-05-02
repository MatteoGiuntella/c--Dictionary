// See https://aka.ms/new-console-template for more information
 Dictionary<string, int> dizionario = new Dictionary<string, int>();
        dizionario.Add("Mario", 25);
        dizionario.Add("Luca", 22);
        dizionario.Add("Sara", 24);

        if (dizionario.ContainsKey("Luca"))
        {
            dizionario.Remove("Luca");

            // Costruzione della stringa richiesta dal test
            string output = "Studenti e le loro età:\n";
            foreach (var elem in dizionario)
            {
                output += $"{elem.Key}: {elem.Value}\n";
            }
            Console.WriteLine(output);
        }