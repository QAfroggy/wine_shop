// See https://aka.ms/new-console-template for more information
/*
Ticket #WS-001: Customer Age Verification
User Story:
As a store owner,
I want to verify the age of users when they start the application,
so that I can legally sell alcohol only to adults (18+).

Acceptance Criteria (AC):

The console must ask the user: "Please enter your age:".

The program must read the user's input.

If the age is less than 18, print: "Sorry, access to the store is allowed only for persons 18 and older." and stop the program.

If the age is 18 or older, print: "Age verified. Welcome to the catalog!" and continue the program.


*/
Console.WriteLine("Welcome to the Wine Shop Online!");
Console.WriteLine("Please enter your age:");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);
if (age <18)
{
    Console.WriteLine("Sorry, access to the store is allowed only for persons 18 and older.");
    return;

}else
{
    Console.WriteLine("Age verified. Welcome to the catalog!");
}