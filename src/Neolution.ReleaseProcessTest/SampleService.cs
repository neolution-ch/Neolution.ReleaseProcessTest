namespace Neolution.ReleaseProcessTest;

/// <summary>
/// A sample service class for testing the release process
/// </summary>
public class SampleService
{
    /// <summary>
    /// Gets a greeting message
    /// </summary>
    /// <param name="name">The name to greet</param>
    /// <returns>A greeting message</returns>
    public string GetGreeting(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        return $"Hello, {name}! This is Neolution.ReleaseProcessTest library.";
    }

    /// <summary>
    /// Calculates the sum of two integers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>The sum of a and b</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Initial feature for alpha release
    /// </summary>
    public void InitialFeature()
    {
        // Fixed: Added implementation to log feature execution
        Console.WriteLine("Initial feature executed successfully.");
        // Enhanced: Added additional logging for feature completion
        Console.WriteLine("Feature initialization completed with enhanced logging.");
    }

    /// <summary>
    /// Feature completion method for beta release
    /// </summary>
    /// <param name="input">Input parameter for processing</param>
    /// <returns>Processed result</returns>
    public string FeatureCompletion(string input)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(input);
        return $"Feature completed for input: {input}. Ready for beta release.";
    }
}