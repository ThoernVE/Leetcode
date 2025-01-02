public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        bool length = false;
        bool lowercase = false;
        bool uppercase = false;
        bool digit = false;
        bool specialChar = false;
        bool twoInARow = true;
        char[] lower = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x','y', 'z'];
        char[] upper = ['A','B','C','D','E','F','G','H','I','J','L','K','M','N','O','P','Q','R','S','T','U','V', 'W', 'X','Y','Z'];
        char[] num = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
        char[] special = ['"','!','@','#','$','%','^','&','*','(',')','-','+','"'];
        if(password.Length >= 8)
        {
            length = true;
        }
        for(int i = 0; i < password.Length; i++)
        {
            if(lower.Contains(password[i]))
            {
                lowercase = true;
            }
            if(upper.Contains(password[i]))
            {
                uppercase = true;
            }
            if(num.Contains(password[i]))
            {
                digit = true;
            }
            if(special.Contains(password[i]))
            {
                specialChar = true;
            }
            if(i < password.Length-1 && password[i] == password[i+1])
            {
                twoInARow = false;
            }
        }
        Console.WriteLine(length);
        Console.WriteLine(twoInARow);
        Console.WriteLine(specialChar);
        Console.WriteLine(digit);
        Console.WriteLine(uppercase);
        Console.WriteLine(lowercase);

        return (length && twoInARow && specialChar && digit && uppercase && lowercase);
    }
}