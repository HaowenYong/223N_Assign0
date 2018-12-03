rm *.dll
rm *.exe

ls -l

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -out:Colorselector.dll Colorselector.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:Colorselector.dll -out:Selector.dll Selector.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:Selector.dll -out:SelectMain.dll SelectMain.cs

mcs -r:System -r:System.Windows.Forms -r:System.Drawing -r:Selector.dll -out:Select.exe SelectMain.cs

./Select.exe