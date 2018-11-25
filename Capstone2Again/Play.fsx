#load "Model.fs"
open Model

let b = { name = "bill" }
let ba = { balance = 10; id = "asdfasdfasdf"; customer = b}

let c = deposit 45 ba

createBaseDirectoryOf @"c:\temp\somedir\somefile.txt"
