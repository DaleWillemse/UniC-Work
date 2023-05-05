namespace Abstraction
{
    abstract class Gun
    {
        // Abstract method (does not have a body)
        public abstract void gunSound(); // Guns make different sounds.
        public abstract void gunDamage(); // Guns give different amounts of damage.
        // Regular method
        public void reload() // All guns need to be reloaded.
        {
            Console.WriteLine("*reloads*");
        }

        public void empty() // All guns can be empty.
        {
            Console.WriteLine("*click click*");
        }
    }

    // Derived class (inherit from Gun)
    class Pistol : Gun
    {
        public override void gunSound()
        {
            Console.WriteLine("pistol goes bang");
        }
        public override void gunDamage()
        {
            Console.WriteLine("pistol does 5 dmg");
        }
    }


    class Rifle : Gun
    {
        public override void gunSound()
        {
            Console.WriteLine("rifle goes bang");
        }
        public override void gunDamage()
        {
            Console.WriteLine("rifle does 15 dmg");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pistol myPistol = new Pistol(); // Create a pistol object
            myPistol.gunSound();  // Call the abstract method
            myPistol.gunDamage();
            myPistol.reload();  // Call the regular method

            Rifle myRifle = new Rifle();
            myRifle.gunSound();
            myRifle.gunDamage();
            myRifle.gunSound();
            myRifle.empty();
            myRifle.reload();
        }
    }
}
