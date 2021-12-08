using System;
/// <summary>
/// interface IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// interact
    /// </summary>
    void Interact();
}
/// <summary>
/// interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// int 
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// method
    /// </summary>
    void Break();
}
/// <summary>
/// interface ICollectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// property
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// method
    /// </summary>
    void Collect();
}
/// <summary>
/// obstract class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// string name
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Overide ToString Method
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
/// <summary>
/// test object class inherit from interfaces and obstact class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// constructor 
    /// </summary>
    /// <param name="name"> the name of the door </param>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// Interact
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }



}
/// <summary>
/// 
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// isQuestItem
    /// </summary>
    public bool isQuestItem;
    /// <summary>
    /// durability
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Decoration
    /// </summary>
    /// <param name="name"> the name </param>
    /// <param name="durability"> durability</param>
    /// <param name="isQuestItem">isQuestItem</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;

    }

        /// <summary>
        /// interact method
        /// </summary>
        public void Interact()
        {
            if (this.durability == 0)
            {
                Console.WriteLine($"The {this.name} has been broken.");
            }
            else if (this.isQuestItem == true)
            {
                Console.WriteLine($"You look at the {this.name}. There's a key inside.");
            }
            if (this.isQuestItem == false)
            {
                Console.WriteLine($"You look at the {this.name}. Not much to see here.");
            }
        }
    /// <summary>
    /// break method
    /// </summary>
        public void Break()
        {
            this.durability -= 1;
            if (this.durability > 0)
            {
                Console.WriteLine($"You hit the {this.name}. It cracks.");
            }
            if (this.durability == 0)
            {
                Console.WriteLine($"You smash the {this.name}. What a mess.");
            }
            if (this.durability < 0)
            {
                Console.WriteLine($"The {this.name} is already broken.");
            }
        }
    }
