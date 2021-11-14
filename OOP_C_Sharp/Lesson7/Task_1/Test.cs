namespace Lesson7.Task_1
{
    public static class Test
    {
        public static void Run()
        {
            var acoder = new ACoder();
            var entry = "Яблоко";
            var encode = acoder.Encode(new(entry, entry.Length));
            acoder.Decode(encode);
            var bcoder = new BCoder();
            var entry2 = "IsNullOrWhiteSpace";
            var encode_1 = bcoder.Encode(new(entry2, entry.Length));
            bcoder.Decode(encode_1);
        }
    }
}
