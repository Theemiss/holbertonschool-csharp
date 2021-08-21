using System;
namespace Enemies
{
    /// <summary>
    /// empty zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>  repersent the health of zombie </summary>

        public int health;
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

    }
}