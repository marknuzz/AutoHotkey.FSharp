namespace AutoHotkey.FSharp
    module HelloWorld =
        let test() = 
            let engine = AutoHotkey.Interop.AutoHotkeyEngine.Instance
            engine.SetVar("hello", "Hello World.")
            engine.GetVar("hello")
