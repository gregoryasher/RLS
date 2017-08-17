# Remote Lab System: Base Station
The Remote Lab System is a system designed for the University of Washington Bothell campus's Electrical Engineering department. This was a Capstone (or Senior) project that concluded our degrees at the University of Washington. We are a group of Computer Engineering students who were enrolled in the program from 2015 to 2017 when we graduated summer quarter. The development of this project was broken up into Spring and Summer quarter 2017.

# Starting Notes
When we chose this as our project we were initially informed the system did not function. At all. What we found towards the end of our first quarter was the system did not work because previous teams did not create or test any of the components or any code to do so. It became immediately apparent at this point we must completely redesign the system and create all the code.

We created a project and work schedule and dove in immediately. These schedules were essential to the success of our project.

# Goals
This was the fourth iteration of the Base Station and our design goals were to: 
Add an additional Intronix LogicPort logic analyzer to support a maximum total of 68-channels
Add an 16-bit Analog-to-Digital Converter (ADC)
Improve heat dissipation from linear regulators
Design a stable chassis
Update Graphical User Interface (GUI)
Improve software robustness

# Purpose
The Remote Lab System is designed to allow students to work on lab experiments remotely away from campus, or the lab facilities. This system is a learning tool and study aid allowing students to have unlimited access, at any time of day, to their required lab equipment. Dr. Arnold Berger at the University of Washington Bothell conducted research showing that when students were given the ability to work remotely, the peak times were between midnight and 4:00 am. His research also concluded that female students spent more time connected to the system than male students, and also generally received higher grades on related course content.

While no version of the Remote Lab System has been officially implemented in coursework, we believe our project will increase students understanding of hardware integration by allowing them to quickly change various settings on daughterboard experiments and observe their changes in real time.

# Conclusion
At the end of our Capstone program in Summer quarter 2017 we had successfully achieved our goals. 

We added an additional logic analyzer: allowing the use of the two operating independently (two 34-channel logic analyzers) or dual support (one 68-channel logic analyzer) based on the configuration of the attached daughterboard.

We added a 16-bit ADC, effectively increasing the accuracy of node voltage measurements made by the system by 256 times.

We successfully solved the heat dissipation issue on the linear regulators by increasing the heatsink size and adding a thermally controlled fan circuit. 

We purchased and built a galvanized steel chassis for the system to be housed, complete with rubber feet to reduce vibrations caused by the fan. The motherboard's daughterboard connectors protrude from the lid such that no daughterboard will have clearance issues on the lid. The motherboard is mounted to the lid using brass standoffs threaded to the lid. The Velleman Oscilloscope/Function Generator system is securely mounted to the bottom of the chassis. Connector cables were made long enough such that the lid may be removed from the chassis and placed flat beside it. The fan is securely mounted to the chassis with no interference on the motherboard and in direct line with all four linear regulator heatsinks.

We successfully updated the GUI to improve security and user lockouts. The user can no longer send updated board information to a daughterboard not installed. The user can no longer change settings on a daughterboard not installed. The user is forced to check which board is installed before making any settings changes. 

The GUI now automatically detects the correct communications port for the Remote Lab System. If the Remote Lab System is not detected upon program start-up, a prompt appears warning the user.

Pressing the "Update Board" button now actually updates the board with the user's desired daughterboard settings.

Pressing the "Check Board" button now actually sends a request to read the daughterboard's boardID pin states. It also receives the correct values that were read.

Linear regulators now have supporting code and the values change based on the constructor's inputs. It should be noted that these devices in previous iterations never operated due to a lack of supporting code.


