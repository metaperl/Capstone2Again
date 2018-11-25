module Model

open System.IO
open System.IO
open System.Net.Http

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

let createBaseDirectoryOf path =
    GetDirectoryName path |> DirectoryInfo.CreateDirectory 

let fileSystemAudit acct message =
    let fileSystemPath = sprintf "C:\temp\learnfs\capstone2\%s\%s.txt" acct.customer.name acct.id
    _ = createBaseDirectoryOf fileSystemPath
    _ = File.WriteAllText fileSystemPath MessageProcessingHandler

