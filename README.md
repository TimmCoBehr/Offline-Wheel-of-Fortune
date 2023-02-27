# Offline-Wheel-of-Fortune

A simple offline Wheel of Fortune created in WinForms.

It reads .txt files to populate the wheel.

---

In the read text file, each line is considered a different item.
Items can be written in two ways:
  - Just write whatever in the line "Item 1 haha", it'll have a weight of 1
  - Advanced, written so "Item 2 lmao, Weight" where weight is an integer
  
---

Example text file without weights, each bullet point is one line:

  - Pepperoni
  - Mushroom
  - Bacon
  - Ham
  - Salami

![image](https://user-images.githubusercontent.com/81893523/221460889-b6fbc8c7-8133-4b37-95b4-f34e1d340534.png)
 
---
 
Example text file with weights, each bullet point is one line:

  - Pepperoni, 11
  - Mushroom, 2
  - Bacon
  - Ham, 5
  - Salami
  
In this example, the wheel would look like this
![image](https://user-images.githubusercontent.com/81893523/221458602-c193a625-30d5-4588-b612-832b4f3d33af.png)
