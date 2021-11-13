namespace Lesson7.Task_1
{
    public static class Test
    {
        public static void Run()
        {
            var acoder = new ACoder();
            var entry = "Гидроэлектростанция";
            var encode = acoder.Encode(new(entry, entry.Length), 3);
            acoder.Decode(encode, 3);
            var bcoder = new BCoder();
            var entry2 = "IsNullOrWhiteSpace";
            var encode_1 = bcoder.Encode(new(entry2, entry.Length), 4);
            bcoder.Decode(encode_1, 4);
        }
    }
}
