class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string merk, string tipe) : base(merk, tipe)
    {
        merk = "Intel";
    }
}

class CoreI3 : Intel
{
    public CoreI3(string merk, string tipe) : base(merk, tipe)
    {
        tipe = "Core I3";
    }
}

class CoreI5 : Intel
{
    public CoreI5(string merk, string tipe) : base(merk, tipe)
    {
        tipe = "Core I5";
    }
}

class CoreI7 : Intel
{   
    public CoreI7(string merk, string tipe) : base(merk, tipe)
    {
        tipe = "Core I7";
    }
}

class AMD : Processor
{
    public AMD(string merk, string tipe) : base(merk, tipe)
    {
        merk = "AMD";
    }
}

class Ryzen : AMD
{
    public Ryzen(string merk, string tipe) : base(merk, tipe)
    {
        tipe = "RAYZEN";
    }   
}

class Athlon : AMD
{    
    public Athlon(string merk, string tipe) : base(merk, tipe) 
    {
        tipe = "ATHLON";
    }
}

class VGA
{
    public string merk;

    public VGA(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : VGA
{
    public Nvidia(string merk) : base(merk)
    {
        merk = "Nvidia";
    }
}

class Amd : VGA
{    
    public Amd(string merk) : base(merk)
    {
        merk = "AMD";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;

    public Laptop(string merk, string tipe, VGA vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) 
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) 
    {
        tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor) 
    {
        tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        tipe = "Predator";
    }

    public void bermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        tipe = "Legion";
    }
}

class Program
{
    static void Main(string[] args)
    {
        VGA vga1 = new Nvidia("Nvidia");
        VGA vga2 = new Amd("AMD");

        Processor ps1 = new Processor("Intel", "Core I5");
        Processor ps2 = new Processor("AMD", "RAYZEN");
        Processor ps3 = new Processor("Intel", "Core I7");

        Laptop laptop1 = new Vivobook("ASUS", "Vivobook", vga1, ps1);
        Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", vga2, ps2);
        Predator predator = new Predator("ACER", "Predator", vga2, ps3);

        ACER acer = new Predator("ACER", "Predator", vga2, ps3);

        //acer.bermainGame();
        ((Predator)acer).bermainGame();

        //predator.bermainGame();

        //Console.WriteLine(laptop1.vga.merk);
        //Console.WriteLine(laptop1.processor.merk);
        //Console.WriteLine(laptop1.processor.tipe);

        //laptop1.Ngoding();
        //((Vivobook)laptop1).Ngoding();

        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();

    }
}