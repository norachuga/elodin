# Elodin
An engine for generating accurate names of colors using fuzzy color model categorization and Markov chains. Powers the [@PaintNames](https://twitter.com/paintnames) Twitter bot.

Elodin takes a given RGB value, selects similar colors (using HSV color model) from a catalog of named colors, and builds Markov chains from the names of those colors. The chains are then randomly walked to produce names for the RGB value.

The engine requires a large dataset in order to produce good quality names. The included dataset is very small (600 colors) and is only meant as proof-of-concept.
