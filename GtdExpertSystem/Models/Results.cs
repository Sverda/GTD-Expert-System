using System.ComponentModel;

namespace GtdExpertSystem.Models
{
    public enum Results
    {
        [Description("Throw it out to trash")]
        Trash,
        [Description("Save into references")]
        Reference,
        [Description("Look at it another day")]
        MaybeLater,
        [Description("It seems like you have a project to plan")]
        Projects,
        [Description("Do it immediately")]
        DoItNow,
        [Description("Delegate it to someone else")]
        Delegate,
        [Description("Put it into your calendar")]
        Calendar,
        [Description("Do it when you will have some time")]
        NextAction,
        [Description("Error: Any conclusion could not be proceed")]
        None
    }
}
