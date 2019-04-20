namespace MyFunctions

open System;
open System.IO;
open System.Threading.Tasks;
open Microsoft.AspNetCore.Mvc;
open Microsoft.Azure.WebJobs;
open Microsoft.Azure.WebJobs.Extensions.Http;
open Microsoft.AspNetCore.Http;
open Microsoft.Extensions.Logging;
open Newtonsoft.Json;

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc

module HelloYou =
    [<FunctionName("HelloYou")>]
    let run
        ([<HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello")>]
        req: HttpRequest) =
            ContentResult(Content = "oo", ContentType = "text/html")