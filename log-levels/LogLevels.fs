module LogLevels

open System.Text.RegularExpressions

let logLineRegex = ".*\[(.+)\]:\s*(.+)"

let getPart (logLine, num: int) =
    Regex.Match(logLine, logLineRegex).Groups[ num ].Value

let message (logLine: string) : string = getPart(logLine, 2).Trim()

let logLevel (logLine: string) : string = getPart(logLine, 1).ToLower()

let reformat (logLine: string) : string =
    $"{message logLine} ({logLevel logLine})"
