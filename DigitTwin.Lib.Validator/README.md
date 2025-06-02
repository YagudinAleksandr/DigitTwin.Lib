# Валидатор DTO

## Применение
```csharp
public class UserDto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

public static class ValidatorExample
{
    public static void Run()
    {
        var validator = new Validator<UserDto>();
        
        validator.RuleFor(u => u.Name)
            .Must(name => !string.IsNullOrEmpty(name), "Name is required")
            .Must(name => name.Length >= 3, "Name must be at least 3 characters");

        validator.RuleFor(u => u.Age)
            .Must(age => age >= 18, "Age must be 18+");

        validator.RuleFor(u => u.Email)
            .Must(email => email.Contains("@"), "Invalid email format");

        var invalidUser = new UserDto { Name = "A", Age = 17, Email = "invalid" };
        var result = validator.Validate(invalidUser);

        if (!result.IsValid)
        {
            Console.WriteLine("Errors:");
            foreach (var error in result.Errors)
            {
                Console.WriteLine($"- {error}");
            }
        }
    }
}
```