The python implementation consists of a dictionary (hash map) that holds current value of 'nums' as the key and its index as the value. 
We are effectively looking for the missing piece amidst the remainder of the numbers in 'nums' by subtracting them from the target. 
If the difference matches a key in the dict, we return the key and its values. 

from a testcase involving nums=[2,7,11,15] and a target=9, we get:
Difference 7 between 9 and 2 for 0 (we store 2 with an index of 0)
Difference 2 between 9 and 7 for 1 (we store 7 on key 2 with an index of 1, since the value of the difference already exists as a key)
We return [0,1]

The C# and JS implementations follow the same logic as the python one. 

The C implementation is by far the simplest, because I did not feel like building a Dictionary structure right now. Might do it later.
