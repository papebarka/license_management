open System

type Name = string
type Department = string
type Periodicity = Monthly | Yearly
type StartDate = DateOnly
type Cost = int

type LicenseId = int

type License =
    {
        Id : LicenseId
        Name : Name
        Department : Department
        Billing : Periodicity
        StartedOn : StartDate
        Price : Cost
    }


//type SubscribedSoftwares = ResizeArray<_>

let adobe : License =
    {
        Id = 10001
        Name = "Adobe CC"
        Department = "MCC"
        Billing = Yearly
        StartedOn = new StartDate(2024, 08, 30)
        Price = 1200000
    }


// For more information see https://aka.ms/fsharp-console-apps
printfn $"Software product: {adobe}"