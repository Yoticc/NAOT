function korn-build
{
	$path = "$env:userprofile\.nuget\packages\korn\CURRENT_PACKAGE_VERSION\build\Korn.Commands.exe"
	
	$id = [System.Diagnostics.Process]::GetCurrentProcess().Id
	$workingDirectory = Get-Location
	
	$pinfo = New-Object System.Diagnostics.ProcessStartInfo
	$pinfo.FileName = $path
	$pinfo.RedirectStandardError = $true
	$pinfo.RedirectStandardOutput = $true
	$pinfo.UseShellExecute = $false
	$pinfo.Arguments = '"' + $id + '" "' + $workingDirectory + '"'
	$p = New-Object System.Diagnostics.Process
	$p.StartInfo = $pinfo
	$p.Start() | Out-Null
	$stdout = $p.StandardOutput.ReadToEnd()
	$p.WaitForExit()
	
    $lines = $stdout -split '\r\n'

    if ($lines[0] -ne "OK")
    {
        echo "Korn.Commands failed. All output: $stdout"
        return
    }

    $execs = $lines[1..($lines.Length - 1)]
    foreach ($exec in $execs)
    {
        if ($exec -eq '\r\n')
        {
            return
        }

        if ($exec -eq '')
        {
            return
        }

        Invoke-Expression $exec
    }
}

function korn
{
	korn-build
}