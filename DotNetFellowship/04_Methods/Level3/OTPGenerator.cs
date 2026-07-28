using System;

namespace _04_Methods.Level3
{
    public class OTPGenerator
    {
        // Generate 6-digit OTP
        public static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        // Generate 10 OTPs
        public static int[] GenerateOTPArray(int size)
        {
            int[] otpArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                otpArray[i] = GenerateOTP();
                System.Threading.Thread.Sleep(1);
            }

            return otpArray;
        }

        // Check whether all OTPs are unique
        public static bool AreOTPsUnique(int[] otpArray)
        {
            for (int i = 0; i < otpArray.Length - 1; i++)
            {
                for (int j = i + 1; j < otpArray.Length; j++)
                {
                    if (otpArray[i] == otpArray[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}