# http://stackoverflow.com/a/4724421
# http://stackoverflow.com/questions/7690994/powershell-running-a-command-as-administrator

$scriptpath = $MyInvocation.MyCommand.Path
$dir = Split-Path $scriptpath
$exe = $dir + "\bin\Debug\net-topshelf-service-timeout-sample-2.exe"
$service = "sample-BlockingService5"
Write-Host $exe

If (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
{   
	$arguments = "& '" + $myinvocation.mycommand.definition + "'"
	Start-Process powershell -Verb runAs -ArgumentList $arguments
	Break
}

If (-NOT (Test-Path $exe)) 
{
	Write-Host "ERROR: Compile the solution first, then re-run this script."
	Exit
}

if (-NOT (Get-Service -Name $service -ErrorAction SilentlyContinue))
{
	Write-Host "Installing service.."	
	New-Service -Name $service -BinaryPathName $exe
}
else
{
	Stop-Service -Name $service 
}

Write-Host "Starting service.."	
Start-Service -Name $service



