using System.Collections.Generic;

namespace DSA.Scripts.Dictionary
{
    public class CharacterFinder
    {
        #region FindFirstNonRepeatingCharacter

        public char FindFirstNonRepeatingCharacter(string input)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (dictionary.ContainsKey(character))
                {
                    dictionary.TryGetValue(character, out int count);
                    dictionary[character] = count + 1;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            foreach (char character in input)
            {
                if (dictionary[character] == 1)
                {
                    return character;
                }
            }

            return char.MinValue;
        }

        #endregion

        #region FindFirstRepeatedCharacter

        public char FindFirstRepeatedCharacter(string input)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (char character in input)
            {
                if (set.Contains(character))
                {
                    return character;
                }

                set.Add(character);
            }

            return char.MinValue;
        }

        #endregion
    }
}
