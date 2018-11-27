module Model
open System.IO

type Customer = { name: string }

type Account = 
    { balance: int
      id: string
      customer: Customer }

let deposit amount account =
    {account with balance = account.balance + amount}

// turn string into a path
// create a directory path - https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.createdirectory?view=netframework-4.7.2
// get basename of a path  - https://docs.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/3x9wbdze(v=vs.95)
// ensure directory exists?

let createBaseDirectoryOf (filePath:string) =
    Path.GetDirectoryName filePath |> Directory.CreateDirectory 

let fileSystemAudit acct message =
    let fileSystemPath = sprintf "C:\temp\learnfs\capstone2\%s\%s.txt" acct.customer.name acct.id
    createBaseDirectoryOf fileSystemPath |> ignore
    File.WriteAllText fileSystemPath message |> ignore


