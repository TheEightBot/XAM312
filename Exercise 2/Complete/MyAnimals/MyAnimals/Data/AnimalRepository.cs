using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyAnimals
{
    public static class AnimalRepository
    {
        public static IList<Animal> Animals { get; private set; }

        static AnimalRepository()
        {
            Animals = new ObservableCollection<Animal>
            {
                new Animal {
                    Name = "Bird",
                    Description = "Represents celebration or major life events",
                    ImageUrl = "bird.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = true },

                new Animal {
                    Name = "Butterfly",
                    Description = "Represents youth transitioning to adulthood",
                    ImageUrl = "butterfly.png",
                    Difficulty = Difficulty.Medium,
                    IsFavorite = false },

                new Animal {
                    Name = "Cat",
                    Description = "Represents mystery, balance and independence",
                    ImageUrl = "cat.png",
                    Difficulty = Difficulty.Medium,
                    IsFavorite = false },

                new Animal {
                    Name = "Chicken",
                    Description = "It means you may or may not be a real person",
                    ImageUrl = "chicken.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = true },

                new Animal {
                    Name = "Crane",
                    Description = "Represents good fortune and longevity",
                    ImageUrl = "crane.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = false },

                new Animal {
                    Name = "Elephant",
                    Description = "Represents strength, perseverance and luck",
                    ImageUrl = "elephant.png",
                    Difficulty = Difficulty.Hard,
                    IsFavorite = false },

                new Animal {
                    Name = "Fish",
                    Description = "Represents happiness, well being and freedom",
                    ImageUrl = "fish.png",
                    Difficulty = Difficulty.Hard,
                    IsFavorite = false },

                new Animal {
                    Name = "Fox",
                    Description = "Represents cunning, strategy and adaptability",
                    ImageUrl = "fox.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = false },

                new Animal {
                    Name = "Giraffe",
                    Description = "Represents vision elegance and perception",
                    ImageUrl = "giraffe.png",
                    Difficulty = Difficulty.Hard,
                    IsFavorite = false },

                new Animal {
                    Name = "Monkey",
                    Description = "Respresents excellent problem solving and software development skills",
                    ImageUrl = "monkey.png",
                    Difficulty = Difficulty.Medium,
                    IsFavorite = true },

                new Animal {
                    Name = "Mouse",
                    Description = "Represents quick wits, intelligence and resourefulness",
                    ImageUrl = "mouse.png",
                    Difficulty = Difficulty.Medium,
                    IsFavorite = false },

                new Animal {
                    Name = "Rabbit",
                    Description = "Represents fertility or rebirth",
                    ImageUrl = "rabbit.png",
                    Difficulty = Difficulty.Medium,
                    IsFavorite = false },

                new Animal {
                    Name = "Rooster",
                    Description = "Represents talent, courage and confidence",
                    ImageUrl = "rooster.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = false },

                new Animal {
                    Name = "Whale",
                    Description = "Represents communication, navigation and conservation",
                    ImageUrl = "whale.png",
                    Difficulty = Difficulty.Easy,
                    IsFavorite = false },
            };
        }
    }
}