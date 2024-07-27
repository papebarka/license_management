open System

type Name = Name of string
type Department = Department of string
type Periodicity = Monthly | Yearly
type StartDate = StartDate of DateOnly
type Cost = Cost of int

type LicenseId = LicenseId of int

type License =
    {
        Id : LicenseId
        Name : Name
        Department : Department
        Billing : Periodicity
        StartedOn : StartDate
        Price : Cost
    }


type SubscribedSoftwares = SubscribedSoftwares of ResizeArray<_>

let adobe : License =
    {
        Id = 10001
        Name = "Adobe CC"
        Department = "MCC"
        Billing = Yearly
        StartedOn = (2024, 08, 30)
        Price = 1200000
    }


// For more information see https://aka.ms/fsharp-console-apps
printfn $"Software product: {adobe}"