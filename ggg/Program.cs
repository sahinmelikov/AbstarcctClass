namespace ggg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();
            

          Shark shark = new Shark();
            shark.Eat();
            shark.Swim();

            Console.WriteLine("------------------------");



            Animal[] animals = new Animal[] {eagle,shark};
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.See();
                animal.Live();
                animal.Breathe();
                animal.Feed();

            }



        }
    }
}

abstract class Animal
{
    public Animal()
    {
        Console.WriteLine("---------------------------");
    }

    public abstract void Eat();

    public virtual void See()
    {
        Console.WriteLine("Beard as See");
    }
    public abstract void Live();   ////////////Canli

    public abstract void Breathe();    /////////////// Nefes almaq

    public abstract void Feed();      ///////////// Qidalanamq

    public int Myproperty { get; set; }

}

abstract class Bird : Animal
{

    public abstract void Fly();



}

class Eagle : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Eat as  Eagle");
    }
    public override void Fly()
    {
        Console.WriteLine("Fly as  Eagle");

    }
    public override void Live()
    {
        Console.WriteLine("Live as Eagle");
    }
    public override void Breathe()
    {
        Console.WriteLine("Breathe as Eagle");
    }

    public override void Feed()
    {
        Console.WriteLine("Feed as Eagle");
    }


}


///////////// Fish

abstract class Fish : Animal
{
    public abstract void Swim();
}

class Shark : Fish
{
    public override void Swim()
    {
        Console.WriteLine("Swim as Shark");
    }
    public override void Eat()
    {
        Console.WriteLine("Eat as Shark");
    }

    public override void Live()
    {
        Console.WriteLine("Live as  Shark");
    }
    public override void Breathe()
    {
        Console.WriteLine("Breathe as Shark");
    }

    public override void Feed()
    {
        Console.WriteLine("Feed as  Shark");
    }

}
