import serial



def main():
	ser = serial.Serial('/dev/cu.usbmodem1441', 9600)
	ser.write('5')


if __name__ == "__main__":
    main()