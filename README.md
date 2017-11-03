# com-tools
COM Port tools for Windows that I've decided to share.
Useful for people working with (more than one) COM port, especially USB-based serial devices. Each of these may help you save time.

## COM Lister

Simple tool that lists all COM ports on the PC. Useful especially when building applications that require plugging and unplugging USB-Serial devices. Usually on Windows you would just go to Device Manager and check the COM ports. Using this small tool, you don't have to spend time on that any more.

When running, press **Ctrl+Alt+C** to show. The window will stay for a couple of seconds, and will hide itself. If you wish to hide it faster than that, press Ctrl+Alt+C again. May require permissions.
To quit, hit Alt+F4 while the window is on.

## COM2Sniffer

This is a simple tool used to open two COM ports and once and display both outputs in the same window.

It is very useful when having two serial devices used to sniff a serial communication. I used this tool especially to **debug AT-command devices**, together with two FTDI cables. On each of the cable, only the RX pin was used to get data. The first cable had the RX connected to the RX of the AT-enabled device, and the second cable had the RX connected to the TX of the AT-enabled device. This created an easy to debug real-time situation.

**Note:** Since Windows is not a real time system, if both serial devices send data simultaneously or quasi-simultaneously, one might be scheduled before the other, even if the first actually sent data after the second. The buffers are modifiable from Device Manager COM port properties, but having a really low buffer does not help the system very well.