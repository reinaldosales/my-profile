namespace MyProfile.Shared;

public sealed class MyProfileSettings
{
    private MyProfileSettings()
    {
    }

    private static MyProfileSettings _instance;
    private static readonly object _lock = new object();

    public static MyProfileSettings GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new MyProfileSettings();
            }
        }

        return _instance;
    }

    public string DefaultConnectionStrings { get; set; }
    public string BrApi { get; set; }
    public string BrApiToken { get; set; }
}
