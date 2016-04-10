******************************************************
******************************************************
----------------How to Start?-------------------------
Info: Project is written in .Net 4.6.1 using Visual Studio 2015

The Project does use some nuget packages for DI, and unit testing so
build and restore nuget packages may be required.

To run set the Startup project to PrimeMultiSq.Main and hit Start.
The console app will prompt the user for input, enter a number of at least 1.
Entering 0 will exit the application.
The app will then generate the entered number of primes and print out a prime multiplication table.


----------------What I'm pleased with? -------------------
Fairly pleased with the prime number generation algorithm.
I decided to go with a sieve specfically the sieve of eratosthenes.
It's something I've heard of but I've never implemented before.
Information on the sieve of eratosthenes can be found https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
It's pretty efficient and can generate primes to any given limit.

---------------What I would of done if I had more time? ---------------
I would of implemented the Sieve of Atkin.  It's supposedly the most efficient sieve for generating primes.
This would of taken me much more time though.

I would also of implemented self registering types within the DI.  This is pretty straight forward to do when using the entourage pattern
but as this is an anti pattern I've gone with the stairway pattern which I have used for the project struture.
With a bit of time and research I'm sure I could figure it out.

I could also of spent more time on unit testing the output of the grid.

I would also of put the output of the grid to something a little better than a console app. :)





