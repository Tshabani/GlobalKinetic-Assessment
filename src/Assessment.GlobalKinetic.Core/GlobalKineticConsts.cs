using Assessment.GlobalKinetic.Debugging;

namespace Assessment.GlobalKinetic
{
    public class GlobalKineticConsts
    {
        public const string LocalizationSourceName = "GlobalKinetic";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3b10977dced54916bdfdd4cf0dc9b14b";
    }
}
