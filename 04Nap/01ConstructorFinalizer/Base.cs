namespace _01ConstructorFinalizer
{
    public class Base
    {
        private readonly bool IsConstructed; //false

        //ez egy különleges fgv : ez a constructor
        public Base()
        {
            System.Console.WriteLine("Base létrehozó: Base()");

            IsInitiated = true;

        }

        public Base(string name) : this()
        {

            System.Console.WriteLine("Base létrehozó: Base(string name)");
            Name = name;

        }

        public Base(string name, string email) : this(name)
        {
            System.Console.WriteLine("Base létrehozó: Base(string name, string email)");

            Email = email;
        }

        public string Name { get; private set; }

        public bool IsInitiated { get; private set; }
        public string Email { get; }

        ~Base()
        {
            System.Console.WriteLine("Véglegesítő: ~Base()");
        }
    }
}