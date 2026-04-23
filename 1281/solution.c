int subtractProductAndSum(int n) {
    int product = 1;
    int sum = 0;
    char str[20];
    sprintf(str,"%d", n);	
    for (int i = 0; i < strlen(str); i++) {
        int x = str[i] - '0';
        product *= x;
        sum += x;
    }
    return product - sum;
}
