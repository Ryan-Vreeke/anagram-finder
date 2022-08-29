build: Ps0.cs
	mcs -out:temp.exe Ps0.cs

run: clean build
	./temp.exe

clean:
	rm -rf *.exe