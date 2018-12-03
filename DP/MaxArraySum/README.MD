https://www.hackerrank.com/challenges/max-array-sum

Solution: https://www.hackerrank.com/challenges/max-array-sum/forum/comments/466991

> To address with DP, work through the array, keeping track of the max at each position until you get to the last value of the array. You should start with the base cases defined before iterating through the remainder of the array.
> 
> 1. Max @ position 0: value @ 0
> 2. Max @ position 1: either:
>    - value @ 0
>    - value @ 1
> 3. From that point forward, the max of the next position is either:
>    - the current value at that position
>    - the max value found so far
>    - the max value from 2 positions back plus the current value
> 
> Keep track of the max at each position until you get to the last position of the array.