namespace OOP_s
{
    public class Program
    {
       
    }
    private class Science
    {

    }
    public static class Social
    {

    }
    public abstract class Maths { }

    public class Student
    {
        Maths m = new Maths();

        Program p = new Program();

        Science s = new Science();

        Social sc = new Social();
    }
}

/*  is it possiblle to prevent object creation of a class in c#?
 *  
 *   Object creation of a class can be prevented by
 *   Abstract Class
 *   Private Class
 *   Static Class
 */