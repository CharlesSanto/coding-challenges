public class Solution {
    public bool IsPalindrome(int x) {

        if (x < 0) return false;

        string stringNumber = x.ToString();
        char[] array = stringNumber.ToCharArray(); 
        Array.Reverse(array);
        string arrayInvertido = new string(array);
        
        return x.ToString() == arrayInvertido;
    }
}