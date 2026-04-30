#include <stdio.h>
#include <stdbool.h>

bool isPalindrome(int x) {

    // If number is negative or ending on a zero, it won't be a palindrome
    // except zero itself, which is a palindrome
    if (x < 0 || (x % 10 == 0 && x != 0)) {
        return false;
    }

    // reverse half of the original number, the other half will be x itself
    int reversed = 0;
    while (x > reversed) {
        reversed = reversed * 10 + x % 10;
        x /= 10;
    }
    
    // If the number is even, check if the halves are identical directly
    // if the number is odd, remove the last number from reversed (since its the middle number of x, which
    // was taken) and check the remaining halves
    return (reversed == x || x == reversed / 10);
}

int main(){
    printf("%s", isPalindrome(121) ? "true" : "false");
}
