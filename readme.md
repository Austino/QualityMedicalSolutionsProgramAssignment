# Test Case Program
A simple C# console app which is a variation of the famous (infamous) BuzzFizz challenge. The program specifies a max number and will print all the numbers from 1 upto max number. If a given number is divisible by 3 it will print Test, if divisible by 5 it will print Case and if divisible by both it will print TestCase. 

# Extendability
Note to Quality Medical Solutions. If the program needed to be extended to accomodate more divisible checks, it could easily be done. I personally would have a data structure class like this:

```
internal class DivisibilityCheck
{
	internal int Divisor { get; private set; }
	internal string Message { get; private set; }

	internal DivisibilityCheck(int divisor, string message)
	{
		this.Divisor = divisor;
		this.Message = message;
	}
}
```

I would create some IEnumerable data structure to hold multiple DivisibilityChecks, i.e. 

```
	List<DivisibilityCheck> numbersToCheck = new List<DivisibilityCheck>();
	numbersToCheck.Add(new DivisibilityCheck(3, "Test"));
	...
```

And then inside my **TestCaseBasicFunctionality** class I would loop through this object like so:

```
	foreach(DivisibilityCheck check in numbersToCheck)
	{
		CheckIfDivisble(i, check.Divisor, check.Message, currentMessage); 
	}
	
```