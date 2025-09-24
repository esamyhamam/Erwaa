using ErwaaSystem.Debugging;

namespace ErwaaSystem;

public class ErwaaSystemConsts
{
    public const string LocalizationSourceName = "ErwaaSystem";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4075a87082bf469da6ba44e19f07d7d7";
}
