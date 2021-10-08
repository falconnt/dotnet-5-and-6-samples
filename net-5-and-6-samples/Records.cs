namespace net_5_and_6_samples
{
    public enum PersonSex { Unknown = 0, Man = 1, Woman = 2 };
    public record Person(string FirstName, string LastName, PersonSex Sex);

    public record Man(string FirstName, string LastName) : Person(FirstName, LastName, PersonSex.Man);
    public record Woman(string FirstName, string LastName) : Person(FirstName, LastName, PersonSex.Woman);
}
