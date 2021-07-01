# Oscilloscope-Function-Generator

23 April 2019:                                                                                                  

Thank you for checking out the oscilloscope fun pack!      

This is a project written in C#, using Microsoft Visual Studio. It was done out of my own personal interest,           
and development progressed during my occasional free time across a few weeks.

The idea of this came from my interest in vector graphics in old arcade games (such as Asteroids), so I set out
to create a program that takes points on an X-Y plane and converts them to audio signals in a wave file, which
is then played through the computer's auxiliary output and channeled into an oscilloscope's X and Y inputs.
This results in some variable-quality vector grahpics at the mercy of 16-bit signed wave file limitations. Audio
processors also aren't meant to play high-precision frequencies in this manner. The quality of the picture is also
limited by the quality of your audio output device. For example, if you ran the programs on a laptop with an
integrated audio processor, and then compared that to a desktop with a dedicated audio processor, the display
would look MUCH nicer with the latter setup.

This project is open source, so if you want to dig into the code of any of the programs out of curiosity, or
to use them for your own project(s), you're welcome to do that. Detailed comments are used throughout the
programs to make them easy to understand.                                                                       
    
In the "Executables" folder, you'll find the three programs themselves.
Below that, you'll find the source code for each program.                                                 

---

Antivirus warning:                                                                                            
 
You may have already guessed, but I am not a certified Microsoft publisher. Because of this, these programs   
are linked to no publishing certificate. This is a red flag to most antivirus software, and it will likely tell
you that the program could be, or is harmful. To get around this, you will have to add the programs to your   
antivirus software as an exception. All antivirus software is different, so I can't tell you how to do that   
here, but a quick Google search should be of assistance to you.                                           

---

Setup instructions (for all programs):
  1. Set your oscilloscope to X-Y mode
  2. Connect X to the RIGHT audio channel
  3. Connect Y to the LEFT audio channel
  4. Adjust the display as necessary to fit your oscilloscope's screen

---

This program is used to create functions on your oscilloscope, as well as draw your own pictures!

- "Play Wave" Button
  - Once you have your wave picked, use this to play the sound. The sound continues playing until you stop it by clicking this button again.
    - Sound playing will be indicated by text that says "Wave playing!" If you don't see this text, no audio is playing.
		
- "Clear Preview" Button
  - This will clear the preview screen, but will NOT stop the wave from playing.

- "Update Wave" Button
  - Only visible when the wave is currently playing.
  - This button will "update" the display to reflect your CURRENT settings.
  - If you change any settings while the wave is playing, what's shown on the oscilloscope may not reflect the settings you currently have active.

- "Frequency" Trackbar/Textbox
	- Adjust the frequency for your wave files.
	- Ranges from 1-3000 Hz.
	- ONLY affects first four wave manipulation options.


- "Wave Manipulation" Group Box
  - "Sine Wave"
    - Produce a sine wave based on frequency.

  - "Square Wave"
    - Produce a square wave based on frequency.

  - "Triangle Wave"
  - Produce a triangle wave based on frequency.

  - "Sawtooth Wave"
    - Produce a sawtooth wave based on frequency.

  - "Y-Axis Free Drawing"
    - Records movements of the Y axis ONLY, and draws the poins on the oscilloscope.
    - MAX 2000 points. An analog oscilloscope can only move to so many different places before the display begins flashing.

  - "X-Y Mode Free Drawing"
    - Records the movements of the X and Y axes, and draws the points on the oscilloscope.
    - ONLY works in X-Y mode.
	- MAX 2000 points. An analog oscilloscope can only move to so many different places before the display begins flashing.

  - "String"
    - Type out whatever you'd like and have it display on the oscilloscope.
    - Utilizes an unfinished ASCII class that takes a string and converts it to points.
      - Only numbers were completed in the ASCII class.
    - "Text size" textbox will allow you to change the size that characters are displayed
    - While there is no text limit, the display will begin flashing if there are too many characters on the screen

  - Preview
    - Shows X and Y position of the cursor (top left).
    - Cleared every time a setting is changed
      - Regenerated every time "Update Wave" or "Play Wave" is clicked
    - If the user has one of the free drawing options selected...
      - Shows number of poins drawn (top right).
      - Allows the user to draw on the X-Y plane
