namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IDisplay, IComparable<Person>, IResetable,IMeasurable
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
        public int Size
        {
            get { return Name.Length; }
        }

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
        /// Compares current name to another persons name.
        /// </summary>
        /// <param name="other">Represents another Person</param>
        /// <returns>The int compare value</returns>
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }
        
		public void Reset()
        {
           Name = String.Empty;
        }
    }
}
