open SoftwareLicense



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


let newAdobe =
    {
        adobe with
            StartedOn = new StartDate(2025, 08, 30)

    }

// For more information see https://aka.ms/fsharp-console-apps
printfn $"Software product: {adobe}"

printfn $"Adobe license has been renewed.\n {newAdobe}"