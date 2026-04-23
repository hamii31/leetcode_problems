/**
 * @param {number} n
 * @return {number}
 */
var subtractProductAndSum = function(n) {
    let str = String(n)
    let product = 1
    let sum = 0

    for(let i = 0; i < str.length; i++){
        x = Number(str[i])
        product *= x
        sum += x
    }

    return product - sum
};
