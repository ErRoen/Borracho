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
                            Name = "Bourbon",
                            Amount = 2,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Simple Syrup",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Bitters",
                            Amount = 2,
                            Measurement = Measurement.Dash,
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

                /*   Hemingway Daiquiri   */
                new Cocktail
                {
                    Name = "Hemingway Daiquiri",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Light Rum",
                            Amount = 2M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Grapefruit Juice",
                            Amount = .75M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lime Juice",
                            Amount = .5M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Maraschino Liqueur",
                            Amount = .5M,
                            Measurement = Measurement.Oz,
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
                /*   Rhubarb-Rosemary Daiquiri   */
                new Cocktail
                {
                    Name = "Rhubarb-Rosemary Daiquiri",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Light Rum",
                            Amount = 1.5M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Rhubarb Juice",
                            Amount = .75M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Rosemary Syrup",
                            Amount = .5M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Fill shaker with ice",
                        "Add all ingredients",
                        "Shake",
                        "strain into cup",
                        "Garnish with lemon wheel and/or rosemary sprig",
                    }
                },
                /*   Rhubarb Juice   */ /*
                new Cocktail
                {
                    Name = "Rhubarb Juice",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Cut Rhubarb",
                            Amount = .5M,
                            Measurement = Lb,
                        },
                        new Ingredient
                        {
                            Name = "Water",
                            Amount = 2M,
                            Measurement = Measurement.Cup,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "Place the cut rhubarb into a pot and cover with water.",
                        "Bring to a boil over high heat, then cover and reduce the heat.",
                        "Allow to simmer for 15 minutes.",
                        "Strain using a fine mesh strainer and press the rhubarb with the back of a spoon to get all of the juice.",
                        "Allow to cool for about 4 hours in the refrigerator.",
                        "If the rhubarb juice separates into a thick, yellowish layer and a pink juice, strain it again until you have only the juice. Use cheesecloth if necessary.",
                    }
                }, */
                /*   Smoked-Rosemary Rum Punch   */
                new Cocktail
                {
                    Name = "Smoked-Rosemary Rum Punch",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gold Rum",
                            Amount = 24M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Orgeat",
                            Amount = 4M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Smoked-Rosemary Citrus Syrup",
                            Amount = 12M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Overproof Rum",
                            Amount = 4M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Water",
                            Amount = 4M,
                            Measurement = Measurement.Oz,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "In a punch bowl, combine gold rum, orgeat, smoked-rosemary citrus syrup, overproof rum, and water.",
                        "Stir to combine",
                        "Refrigerate at least 4 hours and up to overnight.",
                        "To serve, add a large ice cube to the punch bowl.",
                        "Ladle about 3 ounces into a punch glass and grate fresh cinnamon on top.",
                        "Serve.",
                    }
                },
                /*   Smoked-Rosemary Rum Punch   */
                new Cocktail
                {
                    Name = "Smoked-Rosemary Rum Punch",
                    Yield = 1,
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Gold Rum",
                            Amount = 1.5M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Orgeat",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Smoked-Rosemary Citrus Syrup",
                            Amount = .75M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Overproof Rum",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "In a punch bowl, combine gold rum, orgeat, smoked-rosemary citrus syrup, overproof rum, and water.",
                        "Stir to combine",
                        "Refrigerate at least 4 hours and up to overnight.",
                        "To serve, add a large ice cube to the punch bowl.",
                        "Ladle about 3 ounces into a punch glass and grate fresh cinnamon on top.",
                        "Serve.",
                    }
                },
                /*   Smoked-Rosemary Citrus Syrup   */
                new Cocktail
                {
                    Name = "Smoked-Rosemary Citrus Syrup",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Sugar",
                            Amount = 1M,
                            Measurement = Measurement.Cup,
                        },
                        new Ingredient
                        {
                            Name = "Water",
                            Amount = 1M,
                            Measurement = Measurement.Cup,
                        },
                        new Ingredient
                        {
                            Name = "Zest from Lemon",
                            Amount = 2M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = 3M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Zest from Lime",
                            Amount = 1M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = 3M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Sprigs Fresh Rosemary",
                            Amount = 3M,
                            Measurement = Measurement.Oz,
                        },
                    },
                    Instructions = new List<string>
                    {
                        "In a medium saucepan over medium-high heat, combine sugar, water, and lemon and lime zest and juices. Stir to combine.",
                        "Bring mixture to just under a boil, then remove from heat and cover.",
                        "Meanwhile, hold rosemary over an open flame using heatproof tongs, turning continually, until it begins to smoke. As soon as it starts to smoke, uncover syrup and place rosemary in saucepan.",
                        "Cover again and let steep 30 minutes.",
                        "Strain solids out and reserve syrup for the punch in an airtight container.",
                        "The syrup will keep for up to a month in the refrigerator, but flavors will be best if used within 2 days.",
                    }
                },
                
                /*   Some Name   */
                new Cocktail
                {
                    Name = "Some Name",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Dampfwerk Barreled Gin",
                            Amount = 2,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Elderflower Liqueur",
                            Amount = .25M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Grapefruit Rosemary Bitters",
                            Amount = 2,
                            Measurement = Measurement.Dash,
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
                
                /*   Lemon Drop   */
                new Cocktail
                {
                    Name = "Lemon Drop",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient
                        {
                            Name = "Vodka",
                            Amount = 2M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Lemon Juice",
                            Amount = 1M,
                            Measurement = Measurement.Oz,
                        },
                        new Ingredient
                        {
                            Name = "Simple Syrup",
                            Amount = 1,
                            Measurement = Measurement.Oz,
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
            };
        }
    }
}
