using System;

/// <summary>
/// Inventory Manager
/// </summary>
class InventoryManager
{
    /// <summary>
    /// The JSONStorage instance used to load and save objects.
    /// </summary>
    static JSONStorage storage = new JSONStorage();

    /// <summary>
    /// Main - The entry point for the console application.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("Inventory Manager\n-------------------------");
        storage.Load();
        PrintPrompt();

        while (true)
        {
            string input = Console.ReadLine().ToLower().Trim();
            string[] inputArr = input.Split(' ');

            switch (inputArr[0])
            {
                case "classnames":
                    ShowClassNames();
                    break;
                case "all":
                    if (inputArr.Length == 1)
                    {
                        ShowAllObjects();
                    }
                    else if (inputArr.Length == 2)
                    {
                        ShowObjectsByClass(inputArr[1]);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                    break;
                case "create":
                    if (inputArr.Length == 2)
                    {
                        CreateObject(inputArr[1]);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                    break;
                case "show":
                    if (inputArr.Length == 3)
                    {
                        ShowObjectById(inputArr[1], inputArr[2]);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                    break;
                case "update":
                    if (inputArr.Length == 3)
                    {
                        UpdateObjectById(inputArr[1], inputArr[2]);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                    break;
                case "delete":
                    if (inputArr.Length == 3)
                    {
                        DeleteObjectById(inputArr[1], inputArr[2]);
                    }
                    else
                    {
                        PrintInvalidCommand();
                    }
                    break;
                case "exit":
                    storage.Save();
                    return;
                default:
                    PrintInvalidCommand();
                    break;
            }

            PrintPrompt();
        }
    }

    /// <summary>
    /// Prints the initial prompt with the available commands and their usage.
    /// </summary>
    static void PrintPrompt()
    {
        Console.WriteLine("\n<ClassNames> show all ClassNames of objects");
        Console.WriteLine("<All> show all objects");
        Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
        Console.WriteLine("<Create [ClassName]> a new object");
        Console.WriteLine("<Show [ClassName object_id]> an object");
        Console.WriteLine("<Update [ClassName object_id]> an object");
        Console.WriteLine("<Delete [ClassName object_id]> an object");
        Console.WriteLine("<Exit>");
    }

    /// <summary>
    /// Prints all class names of objects loaded in JSONStorage
    /// </summary>
    static void ShowClassNames()
    {
        foreach (string key in storage.All().Keys)
        {
            Console.WriteLine(key.Split('.')[0]);
        }
    }

    /// <summary>
    /// Prints all objects
    /// </summary>
    static void ShowAllObjects()
    {
        foreach (BaseClass obj in storage.All().Values)
        {
            Console.WriteLine(obj.ToString());
        }
    }

    /// <summary>
    /// Prints all objects of a given ClassName
    /// </summary>
    /// <param name="className"></param>
    static void ShowObjectsByClass(string className)
    {
        Type objectType = Type.GetType($"InventoryLibrary.{className}, InventoryLibrary");
        if (objectType == null)
        {
            Console.WriteLine($"{className} is not a valid object type");
        }
        else
        {
            foreach (BaseClass obj in storage.All().Values)
            {
                if (obj.GetType() == objectType)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
        }
    }

    /// <summary>
    /// Create and save a new object of ClassName
    /// </summary>
    /// <param name="className"></param>
    static void CreateObject(string className)
    {
        Type objectType = Type.GetType($"InventoryLibrary.{className}, InventoryLibrary");
        if (objectType == null)
        {
            Console.WriteLine($"{className} is not a valid object type");
        }
        else
        {
            BaseClass obj = (BaseClass)Activator.CreateInstance(objectType);
            storage.New(obj);
            Console.WriteLine($"New {className} created with ID: {obj.id}");
        }
    }
}