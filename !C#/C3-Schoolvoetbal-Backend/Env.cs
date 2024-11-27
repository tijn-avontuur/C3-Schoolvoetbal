namespace C3_Schoolvoetbal_Backend;

public class Env {
    private readonly Dictionary<string, string> vars = new();

    public Env(string path) {
        foreach (var line in File.ReadAllLines(path)) {
            var splitIndex = line.IndexOf('=');

            if (splitIndex < 0) continue;

            var key = line[..splitIndex].Trim();
            var value = line[(splitIndex + 1)..].Trim();

            if (key.Length == 0 || value.Length == 0) continue;

            vars.Add(key, value);
        }
    }

    public string Get(string key) {
        if (vars.TryGetValue(key, out var value)) return value;
        throw new KeyNotFoundException($"The given key '{key}' is not present in the environment.");
    }

    public string Get(string key, string defaultValue) {
        return vars.GetValueOrDefault(key, defaultValue);
    }
}
