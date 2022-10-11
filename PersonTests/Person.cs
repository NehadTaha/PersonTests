namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IDisplay, IComparable<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Displays name.
        /// </summary>
        public void Display()
        {
            MessageBox.Show(this.Name);
        }

        /// <summary>
        /// Compares the names of the person.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>the int value of compareTo method</returns>
        public int compareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
