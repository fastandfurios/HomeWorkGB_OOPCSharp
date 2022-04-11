namespace Lesson6.Task_1
{ 
    internal sealed class Withdrawal
    {
        /// <summary> Снимает с банковского счета </summary>
        /// <param name="sum">сумма снятия</param>
        /// <returns>результат о выполнении</returns>
        public static bool WithdrawAccount(decimal sum, decimal balanceAccountOld, out decimal balanceAccountNew)
        {
            balanceAccountNew = balanceAccountOld;

            if (balanceAccountNew - sum < 0)
            {
                return false;
            }

            balanceAccountNew -= sum;

            return true;
        }
    }
}
