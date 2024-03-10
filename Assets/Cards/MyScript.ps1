Get-ChildItem -Path . -Include *.jpeg -Recurse | ForEach-Object {
    $pngPath = $_.FullName -replace "\.jpeg$", ".png"
    Start-Process ffmpeg -ArgumentList "-i `"$($_.FullName)`" `"$pngPath`"" -Wait -NoNewWindow
}

