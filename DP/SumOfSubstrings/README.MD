https://www.hackerrank.com/challenges/sam-and-substrings/problem

1 2 3 4

| | | |
|-|-|-|
| Step 1 | 1 2 3 **4** | 4 = 4 * 1 <br/> Step: 4 <br/> Total: 4 |
| Step 2 | 1 2 **3** 4 | 3 = 3 * 1 <br/> 34 = 30 + 4 <br/> Step: 37 = 3 + 34 = 3 + 30 (3 * 10) + 4 (From Step 1) <br/> Total: 37 + 4 = 41 |
| Step 3 | 1 **2** 3 4 | 2 = 2 * 1 <br/> 23 = 20 + 3 = <br/> 234 = 200 + 30 + 4 <br/> Step: 259 = 2 + 23 + 234 = 2 + 257 = 2 + 220 (2 * 110) + 37 (From Step 2) <br/> Total: 259 + 41 = 300 |
| Step 4 | **1** 2 3 4 | 1 = 1 * 1 <br/> 12 = 10 + 2 <br/> 123 = 100 + 20 + 3 <br/> 1234 = 1000 + 200 + 30 + 4 <br/> Step: 1370 = 1 + 12 + 123 + 1234 = 1 + 1110 (1 * 1110) + 259 (From Step 3)<br/> Total: 1370 + 300 = 1670 |

