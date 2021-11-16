# zip2rmskin
Convert zip file to a valid rmskin for Rainmeter

Commandline: zip2rmskin.exe "YOUR ZIP FILE"
You can also drag drop a zip file onto zip2rmskin.exe
It will create a rmskin package with the same name as the zip file but with a rmskin extension.

The zip should contain the RMSKIN.ini and folder structure.

A rmskin package is simply a zip file but Rainmeter adds a custom footer to the zip file to prevent you from renaming a zip file to rmskin. zip2rmskin will add this custom footer to the zip file. The footer contains the size of the package in bytes and a "RMSKIN" thumbprint. You can look this up with a HEX editor.

![rmskinhex](https://user-images.githubusercontent.com/50437199/142036954-852d49d8-848b-4e8f-a470-e055f264faaa.jpg)
