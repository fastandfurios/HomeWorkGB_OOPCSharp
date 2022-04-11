namespace Lesson7.Task_1
{
    public static class Test
    {
        public static void Run()
        {
            Console.WriteLine("Кодирование/расшифровка методом сдвига:");
            var entry = "Поршень";
            var acoder = new ACoder();
            var encode = acoder.Encode(new(entry, entry.Length));
            Console.WriteLine(@$"""{entry}"" после кодирования ""{encode}""");
            Console.WriteLine($"После расшифровки: {acoder.Decode(encode)}\n");

            entry = "clUtch";
            encode = acoder.Encode(new(entry, entry.Length));
            Console.WriteLine(@$"""{entry}"" после кодирования ""{encode}""");
            Console.WriteLine($"После расшифровки: {acoder.Decode(encode)}\n");

            Console.WriteLine("Кодирование/расшифровка методом замены:");
            var bcoder = new BCoder
            {
                FirstSymbolAlphabet = 'a',
                LastSymbolAlphabet = 'Z'
            };
            entry = "Exception";
            var encode_1 = bcoder.Encode(new(entry, entry.Length));
            Console.WriteLine(@$"""{entry}"" после кодирования ""{encode_1}""");
            Console.WriteLine($"После расшифровки: {bcoder.Decode(encode_1)}\n");

            bcoder.FirstSymbolAlphabet = 'А';
            bcoder.LastSymbolAlphabet = 'Я';
            entry = "Москва";
            encode_1 = bcoder.Encode(new(entry, entry.Length));
            Console.WriteLine(@$"""{entry}"" после кодирования ""{encode_1}""");
            Console.WriteLine($"После расшифровки: {bcoder.Decode(encode_1)}\n");
        }
    }
}
