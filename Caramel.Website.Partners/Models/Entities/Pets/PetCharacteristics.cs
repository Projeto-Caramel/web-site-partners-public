using Caramel.Website.Partners.Models.Enums.Pets;

namespace Caramel.Website.Partners.Models.Entities.Pets
{
    public class PetCharacteristics
    {
        public PetSex Sex { get; set; }
        public CoatType Coat { get; set; }
        public EnergyLevelType EnergyLevel { get; set; }
        public SizeType Size { get; set; }
        public StimulusLevelType StimulusLevel { get; set; }
        public TemperamentType Temperament { get; set; }
        public ChildLoveType ChildLove { get; set; }
        public AnimalsSocializationType AnimalsSocialization { get; set; }
        public SpecialNeedsType SpecialNeeds { get; set; }
        public SheddingType Shedding { get; set; }
    }
}
