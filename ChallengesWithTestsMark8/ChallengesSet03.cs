using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
<<<<<<< Updated upstream
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
=======
           for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
>>>>>>> Stashed changes
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
<<<<<<< Updated upstream
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);  
=======
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
>>>>>>> Stashed changes
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
<<<<<<< Updated upstream
            var isUpper = false;    
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if(isLower == true && isUpper == true && isNumber == true)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
=======
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true; 
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }

                if(isLower && isUpper && isNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

         
>>>>>>> Stashed changes
        }

        public char GetFirstLetterOfString(string val)
        {
<<<<<<< Updated upstream
            return val.First();
=======
            return val[0];
>>>>>>> Stashed changes
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
<<<<<<< Updated upstream
            if (divisor == 0)
            {
                return 0;
            }
=======
            if(divisor == 0)
            {
                return 0;
            }

>>>>>>> Stashed changes
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
<<<<<<< Updated upstream

           for (int i =0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }

           return list.ToArray();
=======
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
>>>>>>> Stashed changes
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
<<<<<<< Updated upstream
           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
=======
           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
>>>>>>> Stashed changes
            }
        }
    }
}
