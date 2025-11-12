// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//   if ((roll1 == roll2) && (roll2 == roll3))
//   {
//     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//     total += 6;
//   }
//   else
//   {
//     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//     total += 2;
//   }

//   Console.WriteLine($"Your total including the bonus: {total}");
// }

// if (total >= 16)
// {
//   Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//   Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//   Console.WriteLine("You win a trip for two!");
// }
// else
// {
//   Console.WriteLine("You win a kitten!");
// }

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if(message.Contains("fox"))
// {
//   Console.WriteLine("What does the fox say?");
// }

// Random random = new Random();

// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// System.Console.WriteLine("a" == "a");
// System.Console.WriteLine("a" == "A");
// System.Console.WriteLine(1 == 2);

// string myValue = "a";
// System.Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// System.Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Random random = new Random();

// string selection = random.Next(2) == 0 ? "heads" : "tails";

// System.Console.WriteLine(selection);

// string permission = "Regular";
// int level = 26;

// if (permission.Contains("Admin"))
// {
//   if (level > 55) System.Console.WriteLine("Welcome, Super Admin user.");
//   else System.Console.WriteLine("Welcome, Admin user.");
// }

// else if (permission.Contains("Manager"))
// {
//   if (level > 20) System.Console.WriteLine("Contact an Admin for access.");
//   else System.Console.WriteLine("You do not have sufficient privileges.");
// }

// else
// {
//   System.Console.WriteLine("You do not have sufficient privileges.");
// }


// int heroHealth = 10;
// int monsterHealth = 10;
// int attack;
// bool herosTurn = true;

// Random random = new Random();


// while (heroHealth > 0 && monsterHealth > 0)
// {
//   attack = random.Next(1, 7);

//   if (herosTurn)
//   {
//     monsterHealth -= attack;
//     System.Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
//     if (monsterHealth <= 0)
//     {
//       System.Console.WriteLine("Hero Wins!");
//       break;
//     }
//     else
//     {
//       herosTurn = false;
//       continue;
//     }
//   }
//   else
//   {
//     heroHealth -= attack;
//     System.Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
//   }

//   if (heroHealth <= 0)
//   {
//     System.Console.WriteLine("Monster Wins!");
//     break;
//   }
//   else
//   {
//     herosTurn = true;
//     continue;
//   }

// }

// System.Console.WriteLine("The fight is over.");

// bool validInput = false;
// int validInteger = 0;
// System.Console.WriteLine("Please input an integer between the values of 5 and 10");
// do
// {
//   string? input = Console.ReadLine();
//   validInput = int.TryParse(input, out validInteger);

//   if (validInput)
//   {
//     if (validInteger >= 5 && validInteger <= 10)
//     {
//       System.Console.WriteLine($"Your input value of ({validInteger}) has been accepted.");
//     }
//     else
//     {
//       System.Console.WriteLine($"You entered {validInteger}. Please enter a number between 5 and 10.");
//       validInput = false;
//     }

//   }
//   else
//   {
//     System.Console.WriteLine("Sorry, you entered an invalid number. Please try again");
//     continue;
//   }

// } while (validInput == false);

