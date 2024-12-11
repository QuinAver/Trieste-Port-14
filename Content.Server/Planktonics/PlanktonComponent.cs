using Content.Shared.Planktonics;

namespace Content.Server.Planktonics;

[RegisterComponent]
public sealed partial class PlanktonComponent : Component
{
    [DataField("currentSize"), ViewVariables(VVAccess.ReadWrite)]
    public float CurrentSize { get; set; } = 2.0f; // Starting size of cultures

    [DataField("isAlive"), ViewVariables(VVAccess.ReadWrite)]
    public bool IsAlive = true; // Is the plankton alive?

    [DataField("reagentId")]
    public ReagentId ReagentId { get; set; } = new ReagentId();

    // Define a Diet Type Enum
    public enum PlanktonDiet
    {
        Carnivore,
        Photosynthetic,
        Radiophage,
        Saguinophage,
        Electrophage,
        Symbiotroph,
        Chemophage,
        Decomposer,
        Cryophilic,
        Pyrophilic,
        Scavenger
    }

    public enum PlanktonFirstName
    {
    Noctiluce,
    Lumina,
    Scintilla,
    Pyrexia,
    Crystalis,
    Viscera,
    Cnidaria,
    Rhizomorpha,
    Oscillatoria,
    Fluoresca,
    Hydrilla,
    Dinophysis,
    Pyrocystis,
    Euglena,
    Vorticella,
    Phyllodictyon,
    Gymnodinium,
    Peridinium,
    Bacillaria,
    Pseudo-nitzschia
    }


    public enum PlanktonSecondName
    {
    Scilliens,
    Pyrexus,
    Fluctuosa,
    Aurantia,
    Cyanus,
    Vulgaris,
    Ocellata,
    Maritima,
    Toxica,
    Plumbifera,
    Subtilis,
    Diadema,
    Globosa,
    Perforans,
    Confluens,
    Molybdica,
    Aeruginosa,
    Fragilis,
    Pallida,
    Gigantea
    }


    [DataField("planktonName"), ViewVariables(VVAccess.ReadWrite)]
    public PlanktonName Name { get; set; }

    public class PlanktonName
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }

    public PlanktonName(string firstName, string secondName)
    {
        FirstName = firstName;
        SecondName = secondName;
    }

    public override string ToString()
    {
        return $"{FirstName} {SecondName}";
    }
}

    
    // Define a combined Behaviors and Attributes Type Enum (bitwise)
    [Flags]
    public enum PlanktonCharacteristics
    {
        Aggressive = 1 << 0,          // 1
        Bioluminescent = 1 << 1,     // 2
        Parasitic = 1 << 2,          // 4
        Radioactive = 1 << 3,        // 8
        Charged = 1 << 4,            // 16
        Pyrotechnic = 1 << 5,        // 32
        Mimicry = 1 << 6,            // 64
        ChemicalProduction = 1 << 7, // 128
        MagneticField = 1 << 8,      // 256
        Hallucinogenic = 1 << 9,     // 512
        PheromoneGlands = 1 << 10,   // 1024
        PolypColony = 1 << 11,       // 2048
        AerosolSpores = 1 << 12,     // 4096
        HyperExoticSpecies = 1 << 13, // 8192
        Sentience = 1 << 14,          // 16384
        Pyrophilic = 1 << 15,         // 32768
        Cryophilic = 1 << 16          // 65536
    }

    // These hold the random generated values for the plankton
    [DataField("diet"), ViewVariables(VVAccess.ReadWrite)]
    public PlanktonDiet Diet { get; set; }

    [DataField("characteristics"), ViewVariables(VVAccess.ReadWrite)]
    public PlanktonCharacteristics Characteristics { get; set; }

    // Additional properties
    [DataField("temperatureToleranceLow"), ViewVariables(VVAccess.ReadWrite)]
    public float TemperatureToleranceLow { get; set; } = 0.0f; // Min temperature tolerance

    [DataField("temperatureToleranceHigh"), ViewVariables(VVAccess.ReadWrite)]
    public float TemperatureToleranceHigh { get; set; } = 40.0f; // Max temperature tolerance
}
