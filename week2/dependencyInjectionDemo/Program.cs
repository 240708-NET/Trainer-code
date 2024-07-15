IEngine sport = new Engine("Sport", 350, 6); // created a future dependency
Car myCar = new Car(sport); // passing our dependency(engine)


myCar.printingEngineDetails();
