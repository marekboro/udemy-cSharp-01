
//DoHelloWorld();
//DoOverflowing();
//DoPrimitivesDemo();
//DoTypeConversionDemo();
//DoOperatorsDemo();

var johnS = new AndroidEntity();
johnS.FirstName = "John";
johnS.LastName = "Smith";
johnS.Introduce2();
johnS.Introduce3();
AndroidEntity.Introduce();

AndroidEntity.Add(1, 2);

void DoHelloWorld()
{
Console.WriteLine("Hello, World!");
}

void DoOverflowing() {
    byte num1 = 255;
    byte num2 = (byte)(num1 + 1);
    Console.WriteLine(num2); // 0 - we have exceeded the boudry of this data type. 
    num2 = (byte)(num1 + 2);
    Console.WriteLine(num2); // 1 ..
    num2 = (byte)(num1 + 5);
    Console.WriteLine(num2); // 4 ..
    //System.Threading.
    Thread.Sleep(1000);
    Console.Beep();
}

//Scope:
{
var a = 1;// a = b + c;   'b' & 'c' are invisible
{
var b = 2;
     {
     var c = 3;
     a = b + c;  // a,b,c all visible here
     }
    }
}


void DoPrimitivesDemo() {

    /*
    byte num3 = 5;
    int count = 10;
    float total = 20.95f;
    char character = 'A';
    string name = "Tloys";
    bool isWorking = false;
    */
    var num3 = 5;
    var count = 10;
    var total = 20.95f;
    var character = 'A';
    var name = "Tloys";
    var isWorking = false;

    Console.WriteLine(num3);
    Console.WriteLine(count);
    Console.WriteLine(total);
    Console.WriteLine(character);
    Console.WriteLine(name);
    Console.WriteLine(isWorking);

    Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
    Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

    Console.Beep();
}


//const float Pi = 3.14f;
//Console.WriteLine("pi: ", Pi);
// Pi = 1; CANNOT BE OVERRITTEN. 

void DoTypeConversionDemo() {

    //implicit/
    byte tcB1 = 2;
    int tcI1 = tcB1;
    Console.WriteLine("{0} {1}", tcB1, tcI1);

    //explicit
    int tcI2 = 300;
    // byte tcB2 = tcI2;
    byte tcB2 = (byte)tcI2; // Overflow happens 
    Console.WriteLine("{0} {1}", tcI2, tcB2);

    var tcS1 = "1234";
    // int tcI3 = (int)tcS1; // WILL NOT WORK
    int tcI3 = Convert.ToInt32(tcS1);
    Console.WriteLine("{0} {1}", tcS1, tcI3);

    try
    {
        byte tcB3 = Convert.ToByte(tcS1);
        Console.WriteLine("{0} {1}", tcS1, tcB3);

    }
    catch (Exception)
    {
        Console.WriteLine("The number could not be converted to a byte");
        // throw;
    }

    try
    {
        string tcS2 = "true";
        bool tsBool1 = Convert.ToBoolean(tcS2);
        Console.WriteLine("{0} {1}", tcS2, tsBool1);

    }
    catch (Exception)
    {
        Console.WriteLine("The string could not be converted to a Bool");
        throw;
    }

}

 void DoOperatorsDemo() {
    int oInt1 = 1;
    int oInt2 = oInt1++; // oint2 is set to oInt1, then oInt1 is incremented! WTH. 
    Console.WriteLine("{0} {1}", oInt1, oInt2);
    int oInt3 = 1;
    int oInt4 = ++oInt3; // oint3  is incremented!  oInt4 then set to oInt3 
    Console.WriteLine("{0} {1}", oInt3, oInt4);
    int oInt5 = 1;
    int oInt6 = oInt5 + 1;
    Console.WriteLine("{0} {1}", oInt5, oInt6);

    int oInt7 = 10;
    int oInt8 = 3;
    int oInt9 = oInt7 + oInt8;
    Console.WriteLine($"{oInt7} + {oInt8} = {oInt9}");
    float oFloat1 = (float)(oInt7 / oInt8);                   //  3
    float oFloat2 = (float)(oInt7) / (float)(oInt8);        //  3.3333333
    Console.WriteLine($"{oInt7} / {oInt8} = {oFloat1}");
    Console.WriteLine($"{oInt7} / {oInt8} = {oFloat2}");
    int oInt10 = (oInt8 + oInt7 * oInt7);
    Console.WriteLine($"({oInt8} + {oInt7} * {oInt7} ) = {oInt10}");    // multiplication before addition. normal mathematical priorities conserved.

    bool oBool1 = oInt7 > oInt8 && oInt10 > oInt7;

    Console.WriteLine($"({oInt7} > {oInt8} && {oInt10} > {oInt7} ) :  {oBool1}");
}

public class AndroidEntity
{
    public string? FirstName;// = "John";
    public string? LastName;// = "Smith";

    public static string StaticName = "Static-John";
    public static void Introduce()
        {
        Console.WriteLine($"Hi, my name is {StaticName}");    // Accesses Name ?
        Console.WriteLine("Hi, my name is", StaticName);      // Name is blank ?
        }
    public  void Introduce2() 
    {
        Console.WriteLine($"2 Hi, my name is {FirstName} {LastName}");    // Accesses Name ?
        Console.WriteLine("2 Hi, my name is", FirstName);      // Name is blank ?
    }public  void Introduce3() 
    {
        Console.WriteLine($"3 Hi, my name is {FirstName} {LastName}");    // Accesses Name ?
        Console.WriteLine("3 Hi, my name is " + FirstName + " " + LastName);      // Name is blank ?
    }
    public static void Add(int a, int b)
    {
        var c = a + b;
        Console.WriteLine($"Person.Add({a},{b}) = {c}");
    }
}

