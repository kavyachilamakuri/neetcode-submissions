public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while (i < j) {

            if (!Char.IsLetterOrDigit(s[i]) && Char.IsLetterOrDigit(s[j])) {
                i++;
                continue;
            }

            if (Char.IsLetterOrDigit(s[i]) && !Char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }

            if (!Char.IsLetterOrDigit(s[i]) && !Char.IsLetterOrDigit(s[j])) {
                i++;
                j--;
                continue;
            }

            if (Char.IsLetterOrDigit(s[i]) && Char.IsLetterOrDigit(s[j])) {

                if (char.ToLowerInvariant(s[i]) == char.ToLowerInvariant(s[j])) {
                    i++;
                    j--;
                    continue;
                }
                else {
                    return false;
                }
            }
        }

        return true;
    }
}