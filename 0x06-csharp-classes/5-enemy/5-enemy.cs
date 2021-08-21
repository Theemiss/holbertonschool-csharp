using System;
namespace Enemies
{
    /// <summary>
    /// empty zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>  repersent the health of zombie </summary>

        private int health;
        private string name = "(No name)";
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>

        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        ///  Setter for health
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this.health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        /// <summary>
        /// Set or get the name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Return current health of the zombie 
        /// </summary>
        /// <returns> health</returns>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// overide to string method
        /// </summary>
        /// <returns> String representaion of an object</returns>
        public override string ToString() {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }


    }
}