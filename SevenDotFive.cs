namespace SevenDotFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bool1 = true;
            char char1 = 'c';
            int int1 = 12;
            string string1 = "this is a string";

            //var boolBool = bool1 + bool1;
            //var boolChar = bool1 + char1;
            //var boolInt = bool1 + int1;
            var boolString = bool1 + string1;

            //var charBool = char1 + bool1;
            var charChar = char1 + char1;
            var charInt = char1 + int1;
            var charString = char1 + string1;

            //var intBool = int1 + bool1;
            var intChar = int1 + char1;
            var intInt = int1 + int1;
            var intString = int1 + string1;

            var stringBool = string1 + bool1;
            var stringChar = string1 + char1;
            var stringInt = string1 + int1;
            var stringString = string1 + string1;

            //Console.WriteLine(thisBool + thisBool);+
            //Console.WriteLine(thisChar + thisBool);
            //Console.WriteLine(thisInt + thisBool);
            Console.WriteLine("Concat string + bool: "+string1 + bool1);
            Console.WriteLine("Concat char + char: " + char1 + char1);
            Console.WriteLine(char1+char1); // this result differs because there's no string attached
            Console.WriteLine("Concat int + char: " + int1 + char1);
            Console.WriteLine("Concat string + char: " + string1 + char1);
            Console.WriteLine("Concat int + int: "+int1 + int1);
            Console.WriteLine("Concat int + string: "+int1 + string1);
            Console.WriteLine("Concat string + string: "+string1 + string1 +"\n\n");

            Console.WriteLine("boolString:\t"+boolString + boolString.GetType());

            Console.WriteLine("charChar:\t" + charChar + "\t" + charChar.GetType());
            Console.WriteLine("charInt:\t" + charInt + "\t" + charInt.GetType());
            Console.WriteLine("charString:\t" + charString + "\t" + charString.GetType());
            Console.WriteLine("intChar:\t" + intChar + "\t" + intChar.GetType());
            Console.WriteLine("intInt:\t\t" + intInt + "\t" + intInt.GetType());
            Console.WriteLine("intString:\t" + intString + "\t" + intString.GetType());
            Console.WriteLine("stringBool:\t" + stringBool + "\t" + stringBool.GetType());
            Console.WriteLine("stringChar:\t" + stringChar + "\t" + stringChar.GetType());
            Console.WriteLine("stringInt:\t" + stringInt + "\t" + stringInt.GetType());
            Console.WriteLine("stringString:\t" + stringString + "\t" + stringString.GetType());

            //Console.WriteLine("\n\n\n");
            //char1++;
            //Console.WriteLine("char1 is now: " + char1);
            //char1 = char1 + 1;
        }
    }
}

/* 
 * 2.
 * -----------------------------------
 * |       | bool | char | int | string|
 * | bool  |  NO  |  NO  |  NO |  YES  |
 * | char  |  NO  | YES1 | YES2|  YES  |
 * | int   |  NO  | YES  | YES |  YES  |
 * | string|  YES | YES  | YES |  YES  |
 * 
 * 1 & 2: char becomes an int as the system returns the value of the ASCII char rather than the char itself
 * 
 * 3. 
 *   It does seem unavoidable that just about anything works with string because string is the simplest 
 * way to store complex ideas that humans can understand. This allows for string to be a sortof "primary" data
 * type, with int being a secondary. 
 * 
 *   I think the choice to make the char type dependent on context is an interesting one; this allows for char
 * to be used in really interesting ways such as incrementing or decrementing it if i'ts separated from
 * a string but it's still basically plug and play and legible to humans when put into a string.
 *   
 *   I don't think any of these choices seem arbitrary or problematic.
 *   
 * 4.
 * The error tells me that it can't implicitly convert an 'int' to a 'char'. This is one of the things I was
 * impressed with above. I'm pretty sure that as the code is written, the IDE (or the .NET environment in the IDE?)
 * stores the 'char' as a 'char', but when comes time to actually run the program the compiler checks what is 
 * around the 'char' and may - temporarily, I'm guessing - perform a typecast to 'int' if certain conditions are
 * met. I think it could do this by either copying the 'char' and typecasting the copy (pass by value) or by
 * adding a note to the pointer that lets it know to typecast the 'char' (pass by reference).
 *  
 * 
 */