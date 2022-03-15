![example use](https://github.com/smchughinfo/color/blob/master/color.png)

Note - on some systems it grabs the wrong pixel color. I can't remember the exact error but you just have to multiply the x,y values where it looks for the pixel (Form1.cs > GetPixel()) by some constant (maybe 2 ¯\\_(ツ)_/¯)

Correction - the problem seems to be scaling. Like in Windows > Display you can scale the different monitors. In GetColor don't use CoordinateCorrectionCode. Just use Cursor.Position.X/Y and account for scaling. idk the code for that cause it's not something that I need done right now. Basically it'd be something like

var monitor1Scale = someWindowsFunctionToGetTheScaleOfMonitorN; // gives value where 1 = 100%, 1.5 = 150%, etc.
if(xIsOnMonitor1) {
x = Cursor.Position.X * monitor1Scale
} // something ... approximately like that. you can get the idea.
