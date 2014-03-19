FactoryDesignWildlifeSimulator
==============================

This is my first go at implementing the Factory Design Pattern for an application. By using this design pattern, I was able to decouple a lot of code, by delegating responsibility of animal creation to their respective factories. 

In this example, I implemented two factories - one for North American species, and the other for Australian species. After finishing this application, I quickly realized the code will be easier to maintain than previous applications I have coded. 

I used Single Responsibility principle so each object is only responsible for its own jobs, Open-Closed principle so classes/objects can be modified by extension, and the Liskov Substitution principle for the Animal classes (each child can be substituted for it's base class).

I could also create a factory for the continents in this application - e.g. if I wanted to add South American or African animals.