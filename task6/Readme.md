### Why is the output incorrect?
Because `marks` and `total` are integers, the expression  
`marks / total * 100` performs integer division first, losing decimals.  
Example: `45 / 50` becomes `0`, so the final result is `0 * 100 = 0`.

### How can we correct the program?
Force floating-point division by converting at least one value to `double`:

	double percentage = (double)marks / total * 100;
