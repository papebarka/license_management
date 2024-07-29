namespace SoftwareLicense

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