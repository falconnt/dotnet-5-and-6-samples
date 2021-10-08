namespace net_5_and_6_samples.Records;

public enum PersonSex { Unknown = 0, Man = 1, Woman = 2 };
public record Person(string FirstName, string LastName, PersonSex Sex, int Age);

public record Man(string FirstName, string LastName, int Age) : Person(FirstName, LastName, PersonSex.Man, Age);
public record Woman(string FirstName, string LastName, int Age) : Person(FirstName, LastName, PersonSex.Woman, Age);