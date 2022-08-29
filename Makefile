build: Ps0.cs
	mcs -out:temp.exe Ps0.cs

run: clean build
	mono temp.exe

clean:
	rm -rf *.exe