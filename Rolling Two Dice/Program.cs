/* TASK: 
 *  I will write a program that throws a pair of dice three times.I will
    show you the right way to do this and the wrong way.
 */

// 1. CORRECT SOLUTION
// Creating random number generator object
Random randomNumbers = new Random();
// Repeatedly throwing two dice
int correctNumber11 = randomNumbers.Next(0, 100 + 1);
int correctNumber12 = randomNumbers.Next(0, 100 + 1);

int correctNumber21 = randomNumbers.Next(0, 100 + 1);
int correctNumber22 = randomNumbers.Next(0, 100 + 1);

int correctNumber31 = randomNumbers.Next(0, 100 + 1);
int correctNumber32 = randomNumbers.Next(0, 100 + 1);

// Output
Console.WriteLine("CORRECTLY");
Console.WriteLine("Thrown couples: " +
correctNumber11 + "-" + correctNumber12 + ", " + correctNumber21 + "-" + correctNumber22 + ", " +
correctNumber31 + "-" + correctNumber32);

// 2. INCORRECT SOLUTION
// Two random number generators
Random randomNumbers1 = new Random();
Random randomNumbers2 = new Random();
// Repeatedly throwing two dice
int incorrectNumber11 = randomNumbers1.Next(0, 100 + 1);
int incorrectNumber12 = randomNumbers2.Next(0, 100 + 1);

int incorrectNumber21 = randomNumbers1.Next(0, 100 + 1);
int incorrectNumber22 = randomNumbers2.Next(0, 100 + 1);

int incorrectNumber31 = randomNumbers1.Next(0, 100 + 1);
int incorrectNumber32 = randomNumbers2.Next(0, 100 + 1);
// Output
Console.WriteLine(); // empty line
Console.WriteLine("INCORRECTLY");
Console.WriteLine("Thrown couples: " +
incorrectNumber11 + "-" + incorrectNumber12 + ", " +
incorrectNumber21 + "-" + incorrectNumber22 + ", " +
incorrectNumber31 + "-" + incorrectNumber32);
// Waiting for Enter
Console.ReadLine();