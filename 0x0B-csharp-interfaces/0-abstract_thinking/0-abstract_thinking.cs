using System;

/// <summary>
/// obstract class
/// </summary>
abstract class Base
{
    public string name { get; set; }
    /// <summary>
    /// Overide ToString Method
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}