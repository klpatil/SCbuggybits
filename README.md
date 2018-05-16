# SCbuggybits (Sitecore buggy bits)

SCbuggybits is a series of tutorials for learning how to debug memory/CPU/crash bugs in your Sitecore applications. It is based on Tess Ferrandez's .NET Debugging Demos, taken an inspiration from it and upgraded with code and instructions that work on Sitecore 9.0.1. Few things are used as-is (Wtih her permission).

These demos and instructions are specifically for Sitecore 9.0.1.

# Prerequisites
1. VS 2015 or higher
2. Sitecore 9.0.1
3. TDS >= 5.7.0.15
4. Your focused attention! [Disable all those mobile alerts! :-)]

# How to Setup?

1. Make sure you have plain Sitecore 9.0.1 instance up and running.
2. Clone this repository.
3. Open SCbuggybits.sln
4. Modify TdsGlobal.config as per your local environment.
5. Modify SCbuggybits/Properties/PublishProfiles/Local.pubxml file as per your loal environment.
6. Perform Visual Studio Publish for SCbuggybits solution.
7. Perform TDS Sync.
8. Perform Sitecore Publish.
9. Add IIS Binding with HostName as scbuggybits.
10. Add Host entry for scbuggybits.
11. Open your favorite browser and request : http://scbuggybits
12. Happy Debugging! :)


# Labs

(Work in progress)

1. Lab1
2. Lab2
3. Lab3

# Todos

- Write step by step instructions or record video for current labs.
- High CPU/Locking Scenario
- EventQueue related Scenario
- Publishing related Scenario
- What else?

>Found any bug? Got suggestion/feedback/comment, Share it here!

