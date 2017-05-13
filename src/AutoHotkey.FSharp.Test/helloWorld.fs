// See https://fsprojects.github.io/FsUnit/xUnit.html for tutorial
namespace AutoHotkey.FSharp.Tests

module helloWorld =
    open Xunit
    open FsUnit.Xunit
    
    [<Fact>]
    let ``Hello World Should Occur`` () = 
        AutoHotkey.FSharp.HelloWorld.test() |> should equal "Hello World."
