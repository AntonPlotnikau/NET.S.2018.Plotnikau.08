using System;

namespace BankOperations
{
    /// <summary>
    /// Person data
    /// </summary>
    public struct Person
    {
        /// <summary>
        /// The name
        /// </summary>
        public string Name;

        /// <summary>
        /// The last name
        /// </summary>
        public string Lastname;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> struct.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="lastname">The last name.</param>
        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
        }
    }
}
