using ConsoleApp4;

//Animal animal = new Animal();
//animal.PublicMember = "";
//animal.ProtectedMember = "";
//animal.PrivateMember = "";

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.Move();
dog.ToString();

Cat cat = new Cat();
Console.WriteLine(cat.Sound);
cat.Move();
cat.ToString();

Salmon salmon = new Salmon();
Console.WriteLine(salmon.Sound);
salmon.Move();
salmon.ToString();


var animals  = new List<object>
{
    new Cat(),
    new Dog(),
    new Salmon(),
};

foreach(Animal ani in animals)
{
    if(ani is Mammal)
    {
        (ani as Mammal).ProductMilk();
    }
    if (ani is IWalkable) {
        (ani as IWalkable).Walk();
    }
    if (ani is Dog) {
        (ani as Dog).FetchBall();
    }
    if (ani is Cat) {
        (ani as Cat).ThrowOfTheTable();
    }
    if (ani is ISwimmable) {
        (ani as ISwimmable).Swim();
    }
}