# Shells and Scripting

OS Overview

* What is an OS
* What is a terminal
* What's a shell

## What is an OS ?

Bootloader

Kernel -  This is what we're talking about usually when we say a PC has crashed

Daemons

Networking

Shell - CMD, Powershell, &c

GUI

Applications

### CLI vs GUI

GUI allows user to interact with the OS

CLI allows typed in commands to interact with the OS

Shells are the outermost part of the OS

Kernels manage the hardware, accessible via  shell.

Windows NT: Apps -> GUI -> Windows API -> System Services -> Microkernel/Kernel mode drivers -> Hardware Abstraction layer -> Hardware

## Shells

### Powershell

More powerful than CMD, you can pass complex objects and also chain commands with a pipe symbol

It's open source and on github

### Shell excercise commands

  Id CommandLine
-- -----------
   1 cd desktop
   2 mkdir new_folder
   3 new-item -path "\new_folder" textfile.txt
   4 cd new_folder
   5 new-item textfile.txt
   6 Set-Content test.txt "this is some text"
   7 get-content test.txt
   8 add-content test.txt "even more text"
   9 get-content test.txt
  10 mkdir deeper_folder
  11 copy-item "C:\Users\jackd\desktop\new_folder\test.txt" "C:\Users\jackd\desktop\new_folder\deeper_folder"
  12 ls -R
  13 delete test.txt
  14 delete-item test.txt
  15 rm test.txt
  16 ls
  17 ls R
  18 ls -r
  19 hs

### Bash

Linux & Mac OS popular default shell. Runs in most terminal emulators.

On windows we can emulate a linux environment with GitBash

cat command does all kinds of shit with this. 
cat myFile.txt >copy.txt  : copies myFile.txt to copy.txt
head -2 myFile.txt : gives the first two lines of the file
tail -1 myFile.txt : gives the last line of a text file

#### nano
Linux text editor

#### vim
Also a text editor but *really* user unfriendly

# Git

Version control. Very popular. 

## Github

Code hosting, uses Git. 'Nuff said. 

## Git/hub walkthrough

1. Clone a remote GitHUb repo to the local dirve
2. make some changes locally to the repo
3. add the modified files to the staging area
4. commit the changes and push to the github repo
5. introduce branching

## Branching

Covered branching. 







