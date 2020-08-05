open System
open System.Windows
open System.Windows.Controls

[<EntryPoint; STAThread>]
let main argv =
    let app = Application()

    let button = Button(HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = float 100,
                        Width = float 200,
                        Content = "Click me!")
    button.Click.Add(fun _ -> MessageBox.Show "Clicked!" |> ignore)

    let window = Window(Title = "Bla",
                        Height = float 450,
                        Width = float 800,
                        WindowStartupLocation = WindowStartupLocation.CenterScreen,
                        Content = button)

    window.Show()

    app.Run()
    