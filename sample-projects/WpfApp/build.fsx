#r "paket:
nuget Fake.Core.Target //
nuget Fake.DotNet.Cli //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet

// *** Define Targets ***
Target.create "Clean" (fun _ ->
  Trace.log " --- Cleaning stuff --- "
)

Target.create "Build" (fun _ ->
  DotNet.build (fun defaults -> defaults) "WpfApp.sln"
)

open Fake.Core.TargetOperators

// *** Define Dependencies ***
"Clean"
  ==> "Build"

// *** Start Build ***
Target.runOrDefault "Build"