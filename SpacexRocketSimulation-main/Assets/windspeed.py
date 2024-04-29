import random

def calculate_speed(altitude):
    if altitude < 0 or altitude > 25:
        return "Altitude must be between 0 and 25 km"
    
    layers = [(20, 25), (15, 20), (10, 15), (5, 10), (0, 5)]
    speeds = [(5, 10), (10, 40), (40, 60), (25, 60), (0, 25)]
    
    for index, layer in enumerate(layers):
        if layer[0] <= altitude <= layer[1]:
            min_speed, max_speed = speeds[index]
            return random.randint(min_speed, max_speed)


altitude = float(input("Enter altitude (in km) between 0 and 25: "))
speed = calculate_speed(altitude)
print("Speed at altitude", altitude, "km is:", speed, "m/sec")
