using NUnit.Framework;
using SlippingCards.HelperClasses;
using SlippingCards.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SlippingCards_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCardsetFromFile_AssertEqual_ReturnsTrue()
        {
            TextReader textReader = new StreamReader("SlippingCards_template.txt");
            var cardSet = CardsetLoaderHelper.LoadCardset(textReader.ReadToEnd());
            var cardSetTemplate = GetTemplateCardset();

            const int totalSections = 3;
            const int totalCards = 23;


            int sectionsCount = cardSet.Sections.Count;

            int cardsCount = 0;
            foreach(var section in cardSet.Sections)
            {
                cardsCount += section.Cards.Count;
            }


            Assert.AreEqual(sectionsCount, totalSections);
            Assert.AreEqual(cardsCount, totalCards);
        }

        [Test]
        public void CreateCardFromTextWithoutImage_AssertEqual_ReturnsTrue()
        {
            var text = "Hello World: This is the first frase you use to learn how to program.";
            var cardResult = new Card(text);
            var cardTemplate = new Card()
            {
                Image = "🗃",
                Title = "Hello World",
                Text = "This is the first frase you use to learn how to program."
            };

            Assert.AreEqual(cardResult, cardTemplate);
        }

        [Test]
        public void CreateSectionFromTextNoCard_AssertOneSectionCreated_ReturnsTrue()
        {
            var text = "This is a section\n----";
            var cardset = CardsetLoaderHelper.LoadCardset(text);

            int howManySectionsWhereCreated = 0;
            if (cardset.Sections.Count != 1) Assert.Fail("There were more sections than expected.");
            foreach(var section in cardset.Sections)
            {
                if (section.Title == "This is a section") howManySectionsWhereCreated++;
            }

            Assert.AreEqual(howManySectionsWhereCreated, 1);
        }

        [Test]
        public void CreateSectionFromTextWithTrailinChars_AssertOneSectionCreated_ReturnsTrue()
        {
            // Oops, we slipped a card in a place that it shouldn't be. No \n after the hyphens.
            var text = "This is a section\n----This is a card: Should not be here.";
            var cardset = CardsetLoaderHelper.LoadCardset(text);

            int howManySectionsWhereCreated = 0;
            if (cardset.Sections.Count != 1) Assert.Fail("There were more sections than expected.");
            foreach (var section in cardset.Sections)
            {
                if (section.Title == "This is a section") howManySectionsWhereCreated++;
            }

            Assert.AreEqual(howManySectionsWhereCreated, 1);
        }

        private Card GetTemplateCard()
        {
            return new Card()
            {
                Id = 1,
                Title = "Abstract Factory",
                Text = "Creates an instance of several families of classes."
            };
        }

        private Cardset GetTemplateCardset()
        {
            return new Cardset()
            {
                Id = 1,
                Name = "Design Patterns",
                Sections = new List<Section>()
                {
                    new Section(){
                        Id = 1,
                        Title = "Creational Patterns",
                        Cards = new List<Card>()
                        {
                            new Card()
                            {
                                Id = 1,
                                Title = "Abstract Factory",
                                Text = "Creates an instance of several families of classes."
                            },
                            new Card()
                            {
                                Id = 2,
                                Title = "Builder",
                                Text = "Separates object construction from its representation."
                            },
                            new Card()
                            {
                                Id = 3,
                                Title = "Factory Method",
                                Text = "Creates an instance of several derived classes."
                            },
                            new Card()
                            {
                                Id = 4,
                                Title = "Prototype",
                                Text = "A fully initialized instance to be copied or cloned."
                            },
                            new Card()
                            {
                                Id = 5,
                                Title = "Singleton",
                                Text = "A class of which only a single instance can exist."
                            }
                        }
                    },
                    new Section(){
                        Id = 2,
                        Title = "Structural Patterns",
                        Cards = new List<Card>()
                        {
                            new Card()
                            {
                                Id = 6,
                                Title = "Adapter",
                                Text = "Match interfaces of different classes."
                            },
                            new Card()
                            {
                                Id = 7,
                                Title = "Bridge",
                                Text = "Separates an object’s interface from its implementation."
                            },
                            new Card()
                            {
                                Id = 8,
                                Title = "Composite",
                                Text = "A tree structure of simple and composite objects."
                            },
                            new Card()
                            {
                                Id = 9,
                                Title = "Decorator",
                                Text = "Add responsibilities to objects dynamically."
                            },
                            new Card()
                            {
                                Id = 10,
                                Title = "Facade",
                                Text = "A single class that represents an entire subsystem."
                            },
                            new Card()
                            {
                                Id = 11,
                                Title = "Flyweight",
                                Text = "A fine-grained instance used for efficient sharing."
                            },
                            new Card()
                            {
                                Id = 12,
                                Title = "Proxy",
                                Text = "An object representing another object."
                            }
                        }
                    },
                    new Section(){
                        Id = 3,
                        Title = "Behavioral Patterns",
                        Cards = new List<Card>()
                        {
                            new Card()
                            {
                                Id = 13,
                                Title = "Chain of Responsability",
                                Text = "A way of passing a request between a chain of objects."
                            },
                            new Card()
                            {
                                Id = 14,
                                Title = "Command",
                                Text = "Encapsulate a command request as an object."
                            },
                            new Card()
                            {
                                Id = 15,
                                Title = "Interpreter",
                                Text = "A way to include language elements in a program."
                            },
                            new Card()
                            {
                                Id = 16,
                                Title = "Iterator",
                                Text = "Sequentially access the elements of a collection."
                            },
                            new Card()
                            {
                                Id = 17,
                                Title = "Mediator",
                                Text = "Defines simplified communication between classes."
                            },
                            new Card()
                            {
                                Id = 18,
                                Title = "Memento",
                                Text = "Capture and restore an object's internal state."
                            },
                            new Card()
                            {
                                Id = 19,
                                Title = "Observer",
                                Text = "A way of notifying change to a number of classes."
                            },
                            new Card()
                            {
                                Id = 20,
                                Title = "State",
                                Text = "Alter an object's behavior when its state changes."
                            },
                            new Card()
                            {
                                Id = 21,
                                Title = "Strategy",
                                Text = "Encapsulates an algorithm inside a class."
                            },
                            new Card()
                            {
                                Id = 22,
                                Title = "Template Method",
                                Text = "Defer the exact steps of an algorithm to a subclass."
                            },
                            new Card()
                            {
                                Id = 23,
                                Title = "Visitor",
                                Text = "Defines a new operation to a class without change."
                            }
                        }
                    }
                }
            };
        }
    }
}