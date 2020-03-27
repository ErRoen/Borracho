using System.Collections.Generic;
using Borracho.AzureFunction.Models;

namespace Borracho.AzureFunction.Cocktails
{
    // ToDo: Figure out Azure costs for storage and/or Cosmos DB
    public static class CocktailList
    {
        public static IEnumerable<Cocktail> GetCocktails()
        {
            return new List<Cocktail>
            {
                /*   Old Fashioned   */
                new Cocktail
                {
                    Name = "Old Fashioned",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = Measurement.Oz,
                            Name = "Bourbon",
                        },
                        new Ingredient
                        {
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                            Name = "Simple Syrup",
                        },
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = Measurement.Dash,
                            Name = "Bitters",
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in bitters",
                        "put in Simple Syrup",
                        "put in bourbon",
                        "put in ice",
                        "express Orange peel over drink and drop it in"
                    }
                },

                /*   Margarita   */
                new Cocktail
                {
                    Name = "Margarita",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Amount = 2,
                            Measurement = Measurement.Oz,
                            Name = "Tequila",
                        },
                        new Ingredient
                        {
                            Amount = 1,
                            Measurement = Measurement.Oz,
                            Name = "Lime Juice",
                        },
                        new Ingredient
                        {
                            Amount = .75M,
                            Measurement = Measurement.Oz,
                            Name = "Cointreau",
                        },
                        new Ingredient
                        {
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                            Name = "Simple Syrup",
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Fill shaker with ice",
                        "Add all ingredients",
                        "Shake",
                        "strain into cup",
                    }
                },

                /*   The Last Word   */
                new Cocktail
                {
                    Name = "The Last Word",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gin",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Green Chartreuse",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Maraschino Liqueur",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Lime Juice",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "Shake",
                        "Pour",
                        "drink",
                    }
                },

                /*   El Presidente   */
                new Cocktail
                {
                    Name = "El Presidente",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Rum",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Cointreau",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Grenadine",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "Shake",
                        "Pour",
                        "drink",
                    }
                },

                /*   Manhattan   */
                new Cocktail
                {
                    Name = "Manhattan",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Bourbon",
                            Amount = 2,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Sweet Vermouth",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Bitters",
                            Amount = 2,
                            Measurement = Measurement.Dash
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "stir",
                        "Pour",
                        "express lemon peel",
                        "drink",
                    }
                },

                /*   Final Thought   */
                new Cocktail
                {
                    Name = "Final Thought",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gin",
                            Amount = .75M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Yellow Chartreuse",
                            Amount = .75M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Thyme Liqueur",
                            Amount = .75M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = .75M,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "Shake",
                        "Pour",
                        "drink",
                    }
                },

                /*   Vesper   */
                new Cocktail
                {
                    Name = "Vesper",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gin",
                            Amount = 2,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Vodka",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Dry Vermouth",
                            Amount = .5M,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "Shake",
                        "Pour",
                        "Lemon Peel",
                        "drink",
                    }
                },

                /*   Nordic Snapper   */
                new Cocktail
                {
                    Name = "Nordic Snapper",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Aquavit",
                            Amount = 2,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Tomato Juice",
                            Amount = 2,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = .25M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Worcestershire Sauce",
                            Amount = .5M,
                            Measurement = Measurement.Teaspoon
                        },
                        new Ingredient
                        {
                            Name = "Celery Bitters",
                            Amount = 2,
                            Measurement = Measurement.Dash
                        },
                        //new Ingredient
                        //{
                        //    Name = "Sea Salt",
                        //    Amount = 2,
                        //    Measurement = Measurement.Pinch
                        //},
                        //new Ingredient
                        //{
                        //    Name = "Black Pepper",
                        //    Amount = 2,
                        //    Measurement = Measurement.Pinch
                        //},
                        //new Ingredient
                        //{
                        //    Name = "Cayenne Pepper",
                        //    Amount = 2,
                        //    Measurement = Measurement.Pinch
                        //},
                        //new Ingredient
                        //{
                        //    Name = "Lemon Peel",
                        //    Amount = 2,
                        //    Measurement = Measurement.Garnish
                        //},
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "Shake",
                        "Pour",
                        "drink",
                    }
                },

                /*   Grenadine   */
                new Cocktail
                {
                    Name = "Grenadine",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Pomegranate Juice",
                            Amount = 1,
                            Measurement = Measurement.Cup
                        },
                        new Ingredient
                        {
                            Name = "Sugar",
                            Amount = .5M,
                            Measurement = Measurement.Cup
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = .5M,
                            Measurement = Measurement.Oz
                        },
                        //new Ingredient
                        //{
                        //    Name = "Orange Zest Strips",
                        //    Amount = .333M,
                        //    Measurement = Measurement.Whole
                        //},
                    },
                    Instructions = new List<string>
                    {
                        "Boil POM",
                        "Add Sugar and lemon juice",
                        "Stir to dissolve Sugar",
                        "Add orange zest",
                        "Decrease heat to medium low and cook uncovered until reduced by half",
                        "Strain, and pour into bottle",
                        "Add .5 oz over-proof Rum if desired."
                    }
                },

                /*   Boulevardier   */
                new Cocktail
                {
                    Name = "Boulevardier",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Rye",
                            Amount = 1.5M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Campari",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Sweet Vermouth",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "stir",
                        "Pour",
                        "drink",
                    }
                },

                /*   Negroni   */
                new Cocktail
                {
                    Name = "Negroni",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gin",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Campari",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Sweet Vermouth",
                            Amount = 1,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "stir",
                        "Pour",
                        "drink",
                    }
                },

                /*   Sazerac   */
                new Cocktail
                {
                    Name = "Sazerac",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Rye",
                            Amount = 1.5M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Absinthe",
                            Amount = .25M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Peychaud's Bitters",
                            Amount = 3,
                            Measurement = Measurement.Dash
                        },
                        new Ingredient
                        {
                            Name = "Simple Syrup",
                            Amount = 1,
                            Measurement = Measurement.Teaspoon
                        },
                        //new Ingredient
                        //{
                        //    Name = "Lemon Peel",
                        //    Amount = 1,
                        //    Measurement = Measurement.Garnish
                        //},
                    },
                    Instructions = new List<string>
                    {
                        "Rinse glass with Absinthe",
                        "Put in other stuff",
                        "stir",
                        "Pour",
                        "Lemon Peel",
                        "drink",
                    }
                },

                /*   Boo Radley   */
                new Cocktail
                {
                    Name = "Boo Radley",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Bourbon",
                            Amount = 2,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Cynar",
                            Amount = .75M,
                            Measurement = Measurement.Oz
                        },
                        new Ingredient
                        {
                            Name = "Cherry Hearing",
                            Amount = .5M,
                            Measurement = Measurement.Oz
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Put in stuff",
                        "stir",
                        "Pour",
                        "Lemon Peel",
                        "drink",
                    }
                },

                /*   Ancho Margarita   */
                new Cocktail
                {
                    Name = "Ancho Margarita",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Tequila",
                            Amount = 1.5M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Ancho Reyes Chile Liqueur",
                            Amount = 1,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lime Juice",
                            Amount = .5M, // ??? Check this measurement
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Agave Nectar",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Mezcal",
                            Amount = 1,
                            Measurement = Measurement.Teaspoon,
                        },
                        new Ingredient
                        {
                            Name = "Ancho Chocolate Bitters",
                            Amount = 1,
                            Measurement = Measurement.Dash,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Fill shaker with ice",
                        "Add all ingredients",
                        "Shake",
                        "strain into cup",
                    }
                },


/*   Martinez   */
/*   Boris Karloff   */
/*   Mai Tai   */
/*   French 75   */
/*   Singapore Sling   */
/*   Daiquiri   */
/*   Hemingway Daiquiri ???The Papa Doble???   */
/*   Paloma   */
/*   Whiskey Sour   */
/*   Hot Buttered Rum   */
/*   Mojito   */
/*   Pina Colada   */
/*   Dark and Stormy   */
/*   Black Manhattan   */
/*   Corpse Reviver #1   */
/*   Corpse Reviver #2   */
/*   Improved Gin Cocktail   */
/*   Vieux Carre   */
/*   Pisco Sour   */
/*   Red Hook   */
/*      */
/*      */
/*      */
/*      */
/*      */
/*      */
            };
        }
    }
}
