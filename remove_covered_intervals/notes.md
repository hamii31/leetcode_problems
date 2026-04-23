We have to iterate through the nested list, checking if the values within the lists match the criteria given: In [[a,b],[c,d]], [a,b] is 'removed' from the nested list by [c,d]
if a>=c, but d>=b. I used a slower approach of O(n^2) for the task.
