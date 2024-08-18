namespace OldPhonePad
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("33#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("227*#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("4433555 555666#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("8 88777444666*664#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("111#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("2222#"));
            Console.WriteLine("Output: " + HandlingOldPhonePad.OldPhonePad("102#"));
        }
    }
}
