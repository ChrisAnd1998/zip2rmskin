# zip2rmskin
Convert zip file to a valid rmskin for Rainmeter

Commandline: zip2rmskin.exe "YOUR ZIP FILE"
You can also drag drop a zip file onto zip2rmskin.exe
It will create a rmskin package with the same name as the zip file but with a rmskin extension.

The zip should contain the RMSKIN.ini and folder structure.

A rmskin package is simply a zip file but Rainmeter adds a custom footer to the zip file to prevent you from renaming a zip file to rmskin.
The footer contains the size of the package in bytes and a "RMSKIN" thumbprint. You can look this up with a HEX editor.
