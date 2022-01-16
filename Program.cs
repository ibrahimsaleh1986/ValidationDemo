// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
List<Task> taskList = new List<Task>();

Console.WriteLine(DateTime.Now);

// await validators.DateValidator();
// await validators.IdentityValidator();
// await validators.MaritalStatusValidator();
// await validators.NameValidator();
// await validators.AgeValidator();

taskList.Add(Validators.DateValidator());
taskList.Add(Validators.IdentityValidator());
taskList.Add(Validators.MaritalStatusValidator());
taskList.Add(Validators.NameValidator());
taskList.Add(Validators.AgeValidator());

Task.WaitAll(taskList.ToArray());
Console.WriteLine(DateTime.Now);
foreach(var item in ValidatorDTO.ErrorList)
{
    Console.WriteLine(item);
}