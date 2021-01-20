# DataTerminalProject
Small Kiosk Like app running specific app

Alternative Windows Shell/Explorer replacement to allow only Start / Reboot / Shutdown for very specific KIOSK-like enviroments.

## Installation

If you want to run it on hi-res displays copy all files otherwise
copy only DataTerminalProject.exe to `%systemroot%` eg. C:\Windows\
> `HKEY_LOCAL_MACHINE\ Software\ Microsoft\ Windows NT\ CurrentVersion\ Winlogon`
>
> Find the key `Shell` and replace the value from `explorer.exe` to `DataTerminalProject.exe` followed by the server name where DT connects.

## Note
DT must be installed for the user.

## License
    MIT License
