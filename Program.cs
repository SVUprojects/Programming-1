// Display system information
Console.WriteLine("\nWindows version: {0}",Environment.OSVersion);
Console.WriteLine("64 Bit operating system? : {0}",Environment.Is64BitOperatingSystem ? "Yes" :"No");
Console.WriteLine("PC Name : {0}",Environment.MachineName);
Console.WriteLine("Number of CPUS : {0}",Environment.ProcessorCount);
Console.WriteLine("Windows folder : {0}",Environment.SystemDirectory);
Console.WriteLine("Logical Drives Available : {0}",String.Join(", ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty));

// ask user for their name and ID
Console.WriteLine("\n===== Please Enter Your First and Last Name and ID =====");
Console.Write(">> ");

// read the user input and split it into an array
string playerInfo = Console.ReadLine();
string[] playerInfoArray = playerInfo.Split(' ');

// check if the user input is valid (at least 3 parts: first name, last name, and ID)
if (playerInfoArray.Length < 3)
{
    Console.WriteLine("Invalid input. Please enter your first name, last name, and ID separated by spaces.");
}
else
{
    // assign the first name, last name, and ID from the array
    string firstName = playerInfoArray[0];
    string lastName = playerInfoArray[1];
    string id = playerInfoArray[2];

    // display the player information
    Console.WriteLine("\nPlayer Information:");
    Console.WriteLine($"First Name: {firstName}");
    Console.WriteLine($"Last Name: {lastName}");
    Console.WriteLine($"ID: {id}");

    // display the user full name and ID but do not duplicate any charecters
    // like if the user enters "noor juor 12345", the output should be "noorjo12345"
    // use for loop
    Console.WriteLine("\nPlayer Information without duplicates:");
    string fullNameAndID = firstName + lastName + id;
    string result = "";
    for (int i = 0; i < fullNameAndID.Length; i++)
    {
        if (!result.Contains(fullNameAndID[i]))
        {
            result += fullNameAndID[i];
        }
    }
    Console.WriteLine($"Full Name and ID (unique characters only): {result}");
}