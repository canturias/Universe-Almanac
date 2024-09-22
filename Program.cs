// Christian G. Canturias BSCS-II · 2024, September 21
// OOP Video Presentation · Object Oriented Programming (SDF 104)
// June Aurelius Jacinto · M–W (10:30–12:00)

using System;
using System.Linq;

class CelestialBody {
    public string Type { get; private set; } // Private setter
    public string Name { get; set; } // Public setter
    public double Age { get; private set; }
    public double Diameter { get; private set; }
    public double DistanceFromEarth { get; private set; }
    public double Mass { get; private set; }
    public string AgeMeasurement { get; private set; }
    public string DiameterMeasurement { get; private set; }
    public string DistanceFromEarthMeasurement { get; private set; }
    public string MassMeasurement { get; private set; }

    // Empty base constructor (Just an example . . .)
    public CelestialBody() {}

    // Base constructor
    public CelestialBody(
        string type,
        string name,
        double age,
        double diameter,
        double distanceFromEarth,
        double mass,
        string ageMeasurement,
        string diameterMeasurement,
        string distanceFromEarthMeasurement,
        string massMeasurement
        ) {
        string[] validTypes = {
            "Galaxy",
            "Star",
            "Planet",
            "Unknown"
        };
        if (!validTypes.Contains(type)) {
            throw new ArgumentException("The type is invalid.", nameof(type));
        } Type = type;
        if (string.IsNullOrWhiteSpace(name)) {
            throw new ArgumentException("The name cannot be empty.", nameof(name));
        } Name = name;
        if (age < 0) {
            throw new ArgumentException("The age cannot be negative.", nameof(age));
        } Age = age;
        if (diameter < 0) {
            throw new ArgumentException("The diameter cannot be negative.", nameof(diameter));
        } Diameter = diameter;
        if (distanceFromEarth < 0) {
            throw new ArgumentException("The distance cannot be negative.", nameof(distanceFromEarth));
        } DistanceFromEarth = distanceFromEarth;
        if (mass < 0) {
            throw new ArgumentException("The mass cannot be negative.", nameof(mass));
        } Mass = mass;
        string[] validAgeMeasurements = {
            "year",
            "years",
            "million years",
            "billion years"
        };
        if (!validAgeMeasurements.Contains(ageMeasurement)) {
            throw new ArgumentException("The time measurement is invalid.", nameof(ageMeasurement));
        } AgeMeasurement = ageMeasurement;
        string[] validDiameterMeasurements = {
            "kilometers",
            "miles",
            "million kilometers",
            "million miles",
            "solar radii",
            "light years",
            "parsecs"
        };
        if (!validDiameterMeasurements.Contains(diameterMeasurement)) {
            throw new ArgumentException("The diameter measurement is invalid.", nameof(diameterMeasurement));
        } DiameterMeasurement = diameterMeasurement;
        string[] validDistanceFromEarthMeasurements = {
            "kilometers",
            "miles",
            "million kilometers",
            "million miles",
            "astronomical units",
            "light years",
            "million light years",
            "billion light years",
            "parsecs",
            "million parsecs",
            "billion parsecs"
        };
        if (!validDistanceFromEarthMeasurements.Contains(distanceFromEarthMeasurement)) {
            throw new ArgumentException("The distance measurement is invalid.", nameof(distanceFromEarthMeasurement));
        } DistanceFromEarthMeasurement = distanceFromEarthMeasurement;
        string[] validMassMeasurements = {
            "kilograms",
            "earth masses",
            "jupiter masses",
            "solar masses",
            "million solar masses",
            "billion solar masses",
            "trillion solar masses",
            "quadrillion solar masses"
        };
        if (!validMassMeasurements.Contains(massMeasurement)) {
            throw new ArgumentException("The mass measurement is invalid.", nameof(massMeasurement));
        } MassMeasurement = massMeasurement;
    }

    // Base method to display data
    public virtual void DisplayData() {
        Console.WriteLine($"— {Age} {AgeMeasurement} old");
        Console.WriteLine($"— {Diameter} {DiameterMeasurement} in diameter");
        Console.WriteLine($"— {DistanceFromEarth} {DistanceFromEarthMeasurement} away from earth");
        Console.WriteLine($"— {Mass} {MassMeasurement}\n");
    }
}

class Galaxy : CelestialBody {
    public string TypeOfGalaxy { get; set; }
    public double AmountOfStars { get; private set; }
    public string AmountOfStarsMeasurement { get; private set; }

    // Empty derived constructor (Just an example . . .)
    public Galaxy() : base() {}

    // Derived constructor
    public Galaxy(
        string type,
        string name,
        double age,
        double diameter,
        double distanceFromEarth,
        double mass,
        string ageMeasurement,
        string diameterMeasurement,
        string distanceFromEarthMeasurement,
        string massMeasurement,
        string typeOfGalaxy,
        double amountOfStars,
        string amountOfStarsMeasurement)
        : base (
            type,
            name,
            age,
            diameter,
            distanceFromEarth,
            mass,
            ageMeasurement,
            diameterMeasurement,
            distanceFromEarthMeasurement,
            massMeasurement
            ) {
            string[] validTypesOfGalaxies = {
                "spiral",
                "elliptical",
                "irregular",
                "lenticular"
            };
            if (!validTypesOfGalaxies.Contains(typeOfGalaxy)) {
                throw new ArgumentException("The type of galaxy is invalid.", nameof(typeOfGalaxy));
            } TypeOfGalaxy = typeOfGalaxy;
            if (amountOfStars < 0) {
                throw new ArgumentException("The amount of stars cannot be negative.", nameof(amountOfStars));
            } AmountOfStars = amountOfStars;
            string[] validAmountOfStarsMeasurement = {
                "million",
                "billion",
                "trillion",
                "quadrillion"
            };
            if (!validAmountOfStarsMeasurement.Contains(amountOfStarsMeasurement)) {
                throw new ArgumentException("The amount measurement is invalid.", nameof(amountOfStarsMeasurement));
            } AmountOfStarsMeasurement = amountOfStarsMeasurement;
        }

    public override void DisplayData() {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[{Name} {Type}]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"+ A(n) {TypeOfGalaxy} {Type.ToLower()}");
        Console.WriteLine($"+ {AmountOfStars} {AmountOfStarsMeasurement} stars");
        Console.ResetColor();
        base.DisplayData();
    }
}

class Star : CelestialBody {
    public string TypeOfStar { get; private set; }
    public int AmountOfPlanets { get; private set; }

    // Empty derived constructor (Just an example . . .)
    public Star() : base() {}

    // Derived constructor
    public Star(
        string type,
        string name,
        double age,
        double diameter,
        double distanceFromEarth,
        double mass,
        string ageMeasurement,
        string diameterMeasurement,
        string distanceFromEarthMeasurement,
        string massMeasurement,
        string typeOfStar,
        int amountOfPlanets)
        : base (
            type,
            name,
            age,
            diameter,
            distanceFromEarth,
            mass,
            ageMeasurement,
            diameterMeasurement,
            distanceFromEarthMeasurement,
            massMeasurement
            ) {
            string[] validTypesOfStars = {
                "main sequence",
                "red giant",
                "white dwarf",
                "neutron",
                "black hole",
                "supernova",
                "blue supergiant",
                "brown dwarf"
            };
            if (!validTypesOfStars.Contains(typeOfStar)) {
                throw new ArgumentException("The type of star is invalid.", nameof(typeOfStar));
            } TypeOfStar = typeOfStar;
            if (amountOfPlanets < 0) {
                throw new ArgumentException("The amount of planets cannot be negative.", nameof(amountOfPlanets));
            } AmountOfPlanets = amountOfPlanets;
        }
    public override void DisplayData() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[{Name} {Type}]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"+ A(n) {TypeOfStar} {Type.ToLower()}");
        Console.WriteLine($"+ {AmountOfPlanets} planet(s)");
        Console.ResetColor();
        base.DisplayData();
    }
}

class Planet : CelestialBody {
    public string TypeOfPlanet { get; private set; }
    public double AmountOfMoons { get; private set; }

    // Empty derived constructor (Just an example . . .)
    public Planet() : base() {}

    // Derived constructor
    public Planet(
        string type,
        string name,
        double age,
        double diameter,
        double distanceFromEarth,
        double mass,
        string ageMeasurement,
        string diameterMeasurement,
        string distanceFromEarthMeasurement,
        string massMeasurement,
        string typeOfPlanet,
        int amountOfMoons)
        : base (
            type,
            name,
            age,
            diameter,
            distanceFromEarth,
            mass,
            ageMeasurement,
            diameterMeasurement,
            distanceFromEarthMeasurement,
            massMeasurement
            ) {
            string[] validTypesOfPlanets = {
                "terrestrial",
                "gas giant",
                "ice giant",
                "dwarf"
            };
            if (!validTypesOfPlanets.Contains(typeOfPlanet)) {
                throw new ArgumentException("The type of planet is invalid.", nameof(typeOfPlanet));
            } TypeOfPlanet = typeOfPlanet;
            if (amountOfMoons < 0) {
                throw new ArgumentException("The amount of moons cannot be negative.");
            } AmountOfMoons = amountOfMoons;
        }

    public override void DisplayData() {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[{Type} {Name}]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"+ A(n) {TypeOfPlanet} {Type.ToLower()}");
        Console.WriteLine($"+ {AmountOfMoons} moon(s)");
        Console.ResetColor();
        base.DisplayData();
    }
}

class Program {
    static void Wait() { 
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Press any key to exit . . .");
        Console.ResetColor();
        Console.ReadKey(true);
    }

    public static void Create() {
        // Create objects here . . .
        CelestialBody UnknownObject404 = new CelestialBody(
            "Unknown",
            "UnknownObject404",
            2.1,
            2,
            96000,
            0.000042,
            "billion years",
            "kilometers",
            "kilometers",
            "earth masses"
        ); // Just an example . . .

        CelestialBody MilkyWay = new Galaxy( // Upcasting
            "Galaxy", // type
            "Milky Way", // name
            13.4, // age
            100000, // diameter
            0, // distanceFromEarth
            1.5, // mass
            "billion years", // ageMeasurement
            "light years", // diameterMeasurement
            "kilometers", // distanceFromEarthMeasurement
            "trillion solar masses", // massMeasurement
            "spiral", // typeOfGalaxy
            250, // amountOfStars
            "billion" // amountOfStarsMeasurements
        );

        
        Galaxy realMilkyWay = (Galaxy)MilkyWay;
        realMilkyWay.TypeOfGalaxy = "spiral";
        

        CelestialBody IC1101 = new Galaxy(
            "Galaxy",
            "IC 1101",
            20,
            600000,
            1,
            100,
            "billion years",
            "light years",
            "billion light years",
            "billion solar masses",
            "elliptical",
            1,
            "trillion"
        );
        // Galaxy realIC1101 = (Galaxy)IC1101;
        // realIC1101.TypeOfGalaxy = "elliptical";

        CelestialBody TheSun = new Star( // Upcasting
            "Star", // type
            "The Sun", // name
            4.6, // age
            1.39, // diameter
            149.6, // distanceFromEarth
            1047, // mass
            "billion years", // ageMeasurement
            "million kilometers", // diameterMeasurement
            "million kilometers", // distanceFromEarthMeasurement
            "jupiter masses", // massMeasurement
            "main sequence", // typeOfStar
            8 // amountOfPlanets
        );

        CelestialBody Rigel = new Star( // Upcasting
            "Star",
            "Rigel",
            8.0,
            78.0,
            860.0,
            21.0,
            "million years",
            "solar radii",
            "light years",
            "solar masses",
            "blue supergiant",
            0
        );

        CelestialBody Earth = new Planet( // Upcasting
            "Planet", // type
            "Earth", // name
            4.54, // age
            12742, // diameter
            0, // distanceFromEarth
            0.0003, // mass
            "billion years", // ageMeasurement
            "kilometers", // diameterMeasurement
            "kilometers", // distanceFromEarthMeasurement
            "solar masses", // massMeasurement
            "terrestrial", // typeOfPlanet
            1 // amountOfMoons
        );

        CelestialBody HD209458b = new Planet(
            "Planet",
            "HD 209458 b",
            4.2,
            140000,
            159,
            0.69,
            "billion years",
            "kilometers",
            "light years",
            "jupiter masses",
            "gas giant",
            0
        );

        // Output here . . .
        // Console.WriteLine($"[{UnknownObject404.Name}]");
        // UnknownObject404.DisplayData();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(">> GALAXIES <<\n");
        Console.ResetColor();
        MilkyWay.DisplayData();
        IC1101.DisplayData();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(">> STARS <<\n");
        Console.ResetColor();
        TheSun.DisplayData();
        Rigel.DisplayData();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(">> PLANETS <<\n");
        Console.ResetColor();
        Earth.DisplayData();
        HD209458b.DisplayData();
    }

    static void Main() {
        Console.Title = "Universe Almanac";
        Create();
        Wait();
    }
}

// Christian G. Canturias BSCS-II · 2024, September 21
// OOP Video Presentation · Object Oriented Programming (SDF 104)
// June Aurelius Jacinto · M–W (10:30–12:00)