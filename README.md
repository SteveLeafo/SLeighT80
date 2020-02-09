# SLeighT80
A winforms emualtor for the 8080 processor.

Also contains a framework for the space invaders hardware so in theory it should be possible to play some old school arcade games.

![8080](https://raw.githubusercontent.com/SteveLeafo/SLeighT80/master/doc/game.png)


## Why?

My son was showing an interest in computers and how they work, so what better way than to sit down and write an emulator together.
But why c# and Winforms? Emualtors have historically always been written lower lower level programming languages like c/c++.  Since 
2004, I have predominately been programming in C# and don't really enjoy c/c++ as much as I used to.  So I decided to write an 8080 
emulatorin c# to see how it went.  I also decided against OpenGL or Vulkan to see how far I could actually push Winforms and GDI.

## Features?

- Has a simple debugger for registers, pointers and ports.  You can step / pause / run instructions
- A really basic, but functional disassemnler and assembler
- Uses the really cool ByteViewer to view the emualted machines RAM
- I added some very basic emulator functionality for sound, XInput etc, so I should be possible to fire up and play any old 8080 games you have lying around.

![debug](https://raw.githubusercontent.com/SteveLeafo/SLeighT80/master/doc/debug.png)


## How to use it?

Pretty simple really, just install the latest version and away you go.

You can load any 8080 machine code and start stepping through.

There are a number of 8080 tests around the net, most of those should run without any issues

![tests](https://raw.githubusercontent.com/SteveLeafo/SLeighT80/master/doc/emualtor.png)


## Credit

Thanks to "Budford" for your help and getting me motivated  enough to finish this thing.

Also, I don't think I could have written this without the following sites that have all the information you need to write any emulator.

 http://emulator101.com/
 https://www.tutorialspoint.com/instruction-type-rrc-in-8085-microprocessor 
 https://sam.speccy.cz/asm/8080-z80_asm_techniques.pdf
 https://bluishcoder.co.nz/js8080/ 
 http://sensi.org/~svo/i8080/
 https://pastraiser.com/cpu/i8080/i8080_opcodes.html
 http://www.classiccmp.org/dunfield/r/8080.txt
 http://computerarcheology.com/Arcade/SpaceInvaders/Code.html




## License

Mozilla Public License Version 2.0