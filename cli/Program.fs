open System

type Name = Name of string
type Department = Department of string
type Periodicity = Monthly | Yearly
type StartDate = StartDate of Date
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
// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"