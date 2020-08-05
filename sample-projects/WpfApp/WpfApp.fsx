#I @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1"
#r "PresentationCore.dll"
#r "PresentationFramework.dll"
#r "System.Xaml.dll"
#r "WindowsBase.dll"
// #r @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1\WindowsBase.dll"
// #r @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1\PresentationCore.dll"    
// #r @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1\System.Windows.Presentation.dll"    
// #r @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1\PresentationUI.dll"    
// #r @"c:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\3.1.0\ref\netcoreapp3.1\PresentationFramework.dll"

open System
open System.Windows
open System.Windows.Controls

[<EntryPoint; STAThread>]
let main argv =
    let app = new Application()

    let window = new Window(Title = "Bla",
                            Height = float 450,
                            Width = float 800,
                            WindowStartupLocation = WindowStartupLocation.CenterScreen)

    let button = new Button(HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            Height = float 100,
                            Width = float 200,
                            Content = "Click me!")
    button.Click.Add(fun _ -> MessageBox.Show "Clicked!" |> ignore)
    window.Content <- button

    window.Show()

    app.Run()