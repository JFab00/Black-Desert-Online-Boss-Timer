# Black Desert Online - World Bosses Timer (BDO-WBT)

I used to play a lot of Black Desert Online. (now I'm taking a break since I got addicted)  
When I used to play a lot, me and my family moved from city to countryside and the network here was not the best... So I couldn't just stay with a browser tab 24/7 that announces me when the next World Boss will spawn (this is more just an excuse for me to code a timer, don't take it seriously)  
So anyway, I've decided to make me a timer that will do just that, and on top of it, I added Windows reminders and Voice reminders(that means it will say something like "20 mins till the boss spawn", it can get annoying but it is kinda usefull) as well.  
  
## Images  
This is the UI (I have personally draw and paint it in paint.net using my 30 euros graphic tablet).  
Overall it has 5 labels, 4 of which act as buttons.  
![image](https://user-images.githubusercontent.com/47055309/143210305-36abf9f2-a2a0-4134-883d-504cb1f766cf.png)  
The **minimise** and **exit** labels will do just that... Actually the minimise send it to tray, and if you go with the mouse over it while in tray it will display how much time is left till the world boss spawn...  
![image](https://user-images.githubusercontent.com/47055309/143210957-225b2c5b-9633-4c83-8e90-a63207059b6d.png)  
  
When the timer goes down, the image and boss name will switch as well... (obvious feature, I just wanted to mention it just because...) also the boss images I've redraw them just because I wanted to kill some time  
You can drag the window from wherever point of the UI...  
When you click on the name of the boss, it will bring you to a website where the boss spawns (I wanted to also implement that in the software but I got lazy so I didn't)  
When you click on "JFab" it will bring you to my instagram page...  
  
## Footer  
I had a lot of fun making it.  
I haven't updated it, so I don't know if the world bosses schedule have changed... so it might also be outdated  
From what I remember it had some problems when it reaches the end of the week (like 23:59 of Sundays), it will just not work how it should... the best fix for it is just exit and reopen...
I could have got the boss schedule using HTTP request, but I also got lazy so I just made a bunch of arrays for it...  
If you want to carry on with the project, be my guest... just don't try to make money out of it... or if you do, at least mention me somewhere in the credits...
