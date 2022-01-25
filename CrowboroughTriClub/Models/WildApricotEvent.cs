namespace CrowboroughTriClub.Models
{
    public class WildApricotEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EventType { get; set; }
        public string StartDate { get; set; }
        public bool StartTimeSpecified { get; set; }
        public string EndDate { get; set; }
        public bool EndTimeSpecified { get; set; }
        public string Location { get; set; }
        public bool RegistrationEnabled { get; set; }
        public string[] Tags { get; set; }
        public Details Details { get; set; }
        public Session[] Sessions { get; set; }
        public int RegistrationsLimit { get; set; }
    }

    public class Details
    {
        public string DescriptionHtml { get; set; }
        public string PaymentInstructions { get; set; }
        public Timezone TimeZone { get; set; }
        public Accesscontrol AccessControl { get; set; }
        public Guestregistrationsettings GuestRegistrationSettings { get; set; }
        public Organizer Organizer { get; set; }
        public string PaymentMethod { get; set; }
        public string RegistrationConfirmationExtraInfo { get; set; }
        public string RegistrationMessage { get; set; }
        public bool SendEmailCopy { get; set; }
        public bool IsWaitlistEnabled { get; set; }
        public Waitlistsettings WaitlistSettings { get; set; }
        public bool MultipleRegistrationAllowed { get; set; }
        public Attendeesdisplaysettings AttendeesDisplaySettings { get; set; }
    }

    public class Timezone
    {
        public string ZoneId { get; set; }
        public string Name { get; set; }
        public int UtcOffset { get; set; }
    }

    public class Accesscontrol
    {
        public string AccessLevel { get; set; }
        public bool AvailableForAnyLevel { get; set; }
        public Availableforlevel[] AvailableForLevels { get; set; }
        public bool AvailableForAnyGroup { get; set; }
        public Availableforgroup[] AvailableForGroups { get; set; }
    }

    public class Availableforlevel
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }

    public class Availableforgroup
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }

    public class Guestregistrationsettings
    {
        public bool Enabled { get; set; }
        public string CreateContactMode { get; set; }
    }

    public class Organizer
    {
        public int Id { get; set; }
    }

    public class Waitlistsettings
    {
        public string WaitlistType { get; set; }
        public string InformationToCollect { get; set; }
    }

    public class Attendeesdisplaysettings
    {
        public string VisibleTo { get; set; }
        public bool ShowPendingAttendees { get; set; }
    }

    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public bool StartTimeSpecified { get; set; }
        public string EndDate { get; set; }
        public bool EndTimeSpecified { get; set; }
    }
}
