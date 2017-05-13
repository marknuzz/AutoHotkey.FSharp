//All fsx repl scripts should reference this file first.
#load @"../../../.paket/load/net462/main.group.fsx"
#r @"../../../build/AutoHotkey.FSharp/Debug/AutoHotkey.FSharp.dll"

System.IO.Directory.SetCurrentDirectory(__SOURCE_DIRECTORY__ + "../../") //Will set a home directory later, this is just a temporary path