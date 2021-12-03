﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elodin.Core;

namespace Elodin.TestConsole
{
    internal class TestData
    {
        // A completely uncurated set of colors, just so the console app has something to test with.
        internal static List<PaintColor> Colors = new List<PaintColor>
        {
            new PaintColor("Mulberry Silk", 149, 120, 108),
            new PaintColor("Chelsea Mauve", 189, 172, 158),
            new PaintColor("Cabbage Rose", 199, 163, 148),
            new PaintColor("Rose Brocade", 155, 109, 110),
            new PaintColor("Deepest Mauve", 108, 88, 88),
            new PaintColor("Toile Red", 140, 85, 78),
            new PaintColor("Decorous Amber", 173, 119, 87),
            new PaintColor("Cajun Red", 142, 77, 56),
            new PaintColor("Eastlake Gold", 192, 146, 94),
            new PaintColor("Wickerwork", 192, 162, 128),
            new PaintColor("Crewel Tan", 204, 191, 158),
            new PaintColor("Empire Gold", 193, 162, 109),
            new PaintColor("Majolica Green", 173, 181, 145),
            new PaintColor("Sheraton Sage", 142, 139, 103),
            new PaintColor("Gallery Green", 109, 135, 115),
            new PaintColor("Billiard Green", 70, 89, 79),
            new PaintColor("Calico", 138, 163, 156),
            new PaintColor("Teal Stencil", 98, 128, 125),
            new PaintColor("Festoon Aqua", 160, 186, 185),
            new PaintColor("Peacock Plume", 117, 150, 150),
            new PaintColor("Queen Anne Lilac", 195, 183, 183),
            new PaintColor("Patchwork Plum", 128, 108, 109),
            new PaintColor("Pewter Tankard", 163, 157, 145),
            new PaintColor("Curio Gray", 152, 140, 119),
            new PaintColor("Rosedust", 207, 144, 133),
            new PaintColor("Rachel Pink", 234, 188, 174),
            new PaintColor("Aristocrat Peach", 235, 208, 184),
            new PaintColor("Caen Stone", 235, 212, 176),
            new PaintColor("Acanthus", 203, 209, 182),
            new PaintColor("Colonial Yellow", 236, 202, 134),
            new PaintColor("Dutch Tile Blue", 154, 172, 172),
            new PaintColor("Needlepoint Navy", 87, 103, 114),
            new PaintColor("Rembrandt Ruby", 154, 81, 74),
            new PaintColor("Roycroft Rose", 193, 146, 128),
            new PaintColor("Indian White", 237, 221, 195),
            new PaintColor("Buckram Binding", 217, 198, 165),
            new PaintColor("Morris Room Grey", 173, 163, 148),
            new PaintColor("Library Pewter", 126, 116, 99),
            new PaintColor("Portrait Tone", 194, 150, 120),
            new PaintColor("Roycroft Adobe", 167, 99, 80),
            new PaintColor("Dard Hunter Green", 63, 79, 69),
            new PaintColor("Ruskin Room Green", 170, 165, 126),
            new PaintColor("Peristyle Brass", 172, 151, 98),
            new PaintColor("Hubbard Squash", 230, 196, 138),
            new PaintColor("Antiquarian Brown", 148, 108, 70),
            new PaintColor("White Hyacinth", 240, 230, 207),
            new PaintColor("Studio Blue Green", 108, 129, 124),
            new PaintColor("Bunglehouse Blue", 76, 99, 112),
            new PaintColor("Silver Gray", 184, 180, 162),
            new PaintColor("Light Buff", 239, 236, 221),
            new PaintColor("Ivory", 242, 226, 195),
            new PaintColor("Pearl Gray", 202, 206, 197),
            new PaintColor("Porcelain", 232, 225, 213),
            new PaintColor("Twilight Gray", 201, 192, 182),
            new PaintColor("Light French Gray", 194, 193, 187),
            new PaintColor("Sand", 214, 191, 171),
            new PaintColor("Chinese Red", 164, 67, 52),
            new PaintColor("Jazz Age Coral", 243, 193, 176),
            new PaintColor("Frostwork", 203, 210, 196),
            new PaintColor("Alexandrite", 87, 143, 119),
            new PaintColor("Salon Rose", 173, 120, 119),
            new PaintColor("Studio Mauve", 199, 186, 184),
            new PaintColor("Blue Sky", 171, 209, 203),
            new PaintColor("Blue Peacock", 0, 74, 79),
            new PaintColor("Vogue Green", 72, 86, 68),
            new PaintColor("Cascade Green", 171, 180, 160),
            new PaintColor("Belvedere Cream", 237, 209, 159),
            new PaintColor("Copen Blue", 192, 204, 198),
            new PaintColor("Rose Tan", 205, 158, 132),
            new PaintColor("Pink Shadow", 223, 197, 185),
            new PaintColor("Orchid", 190, 157, 158),
            new PaintColor("Deep Maroon", 99, 63, 68),
            new PaintColor("Chartreuse", 222, 216, 136),
            new PaintColor("Radiant Lilac", 168, 136, 160),
            new PaintColor("Holiday Turquoise", 141, 199, 194),
            new PaintColor("Appleblossom", 220, 182, 180),
            new PaintColor("French Gray", 139, 139, 134),
            new PaintColor("Sunbeam Yellow", 237, 216, 156),
            new PaintColor("Pinky Beige", 202, 172, 153),
            new PaintColor("Pink Flamingo", 209, 112, 121),
            new PaintColor("Dark Red", 73, 34, 33),
            new PaintColor("Red", 101, 47, 42),
            new PaintColor("Terra Cotta", 152, 90, 61),
            new PaintColor("Rose Beige", 175, 138, 112),
            new PaintColor("Beige", 195, 178, 158),
            new PaintColor("Brown", 126, 100, 73),
            new PaintColor("Medium Brown", 110, 84, 64),
            new PaintColor("Dark Brown", 93, 75, 63),
            new PaintColor("Shutter Green", 48, 59, 57),
            new PaintColor("Sash Green", 69, 100, 97),
            new PaintColor("Blue Green", 114, 133, 121),
            new PaintColor("Jade", 148, 163, 128),
            new PaintColor("Downing Straw", 198, 173, 121),
            new PaintColor("Antique Gold", 159, 131, 79),
            new PaintColor("Olive", 146, 136, 100),
            new PaintColor("Dark Green", 84, 94, 75),
            new PaintColor("Amber", 186, 135, 64),
            new PaintColor("Heather", 140, 126, 123),
            new PaintColor("Slate", 116, 123, 130),
            new PaintColor("Earth", 137, 125, 104),
            new PaintColor("Stone", 163, 161, 148),
            new PaintColor("Sand", 203, 191, 166),
            new PaintColor("Clay", 153, 129, 99),
            new PaintColor("Golden Oak", 150, 119, 75),
            new PaintColor("Sea Green", 171, 193, 167),
            new PaintColor("Green Stone", 162, 159, 126),
            new PaintColor("Stone", 166, 150, 124),
            new PaintColor("Tan", 209, 182, 150),
            new PaintColor("Classical White", 236, 228, 204),
            new PaintColor("Classical Gold", 232, 191, 114),
            new PaintColor("Colonial Revival Gray", 181, 186, 186),
            new PaintColor("Vellum", 231, 221, 192),
            new PaintColor("Birdseye Maple", 223, 199, 143),
            new PaintColor("Craftsman Brown", 173, 149, 120),
            new PaintColor("Quartersawn Oak", 127, 99, 81),
            new PaintColor("Aurora Brown", 108, 69, 57),
            new PaintColor("Polished Mahogany", 67, 39, 33),
            new PaintColor("Copper Red", 123, 49, 30),
            new PaintColor("Hammered Silver", 151, 140, 127),
            new PaintColor("Weathered Shingle", 146, 130, 103),
            new PaintColor("Suede", 166, 150, 116),
            new PaintColor("Brass", 121, 109, 80),
            new PaintColor("Mist Gray", 192, 190, 177),
            new PaintColor("Bunglehouse Gray", 152, 145, 123),
            new PaintColor("Bronze Green", 85, 85, 72),
            new PaintColor("Bottle Green", 49, 64, 56),
            new PaintColor("Pewter", 91, 96, 95),
            new PaintColor("Westchester Gray", 121, 122, 121),
            new PaintColor("Chelsea Gray", 183, 185, 179),
            new PaintColor("Sage Green Light", 112, 112, 92),
            new PaintColor("Plymouth Green", 174, 185, 150),
            new PaintColor("New Colonial Yellow", 213, 178, 126),
            new PaintColor("Caribbean Coral", 191, 125, 93),
            new PaintColor("Sycamore Tan", 155, 141, 122),
            new PaintColor("Fairfax Brown", 99, 72, 59),
            new PaintColor("Peace Yellow", 232, 210, 154),
            new PaintColor("Harvest Gold", 216, 167, 104),
            new PaintColor("Beige", 221, 202, 180),
            new PaintColor("Sage", 177, 176, 151),
            new PaintColor("Avocado", 129, 127, 93),
            new PaintColor("Burma Jade", 146, 179, 161),
            new PaintColor("Powder Blue", 139, 163, 176),
            new PaintColor("Stratford Blue", 87, 136, 155),
            new PaintColor("Yellow", 245, 218, 145),
            new PaintColor("Wine Country", 96, 34, 52),
            new PaintColor("Elderberry", 124, 36, 61),
            new PaintColor("Pomegranate", 141, 29, 48),
            new PaintColor("Poppy Flower", 135, 20, 31),
            new PaintColor("Carmine", 128, 21, 34),
            new PaintColor("Crimson Red", 113, 25, 34),
            new PaintColor("Scarlet", 181, 0, 26),
            new PaintColor("Cardinal", 157, 16, 28),
            new PaintColor("Redwing", 152, 1, 13),
            new PaintColor("Primary Red", 172, 0, 0),
            new PaintColor("Pompeii Red", 148, 0, 0),
            new PaintColor("Chanticleer", 135, 0, 0),
            new PaintColor("Classy Red", 145, 31, 33),
            new PaintColor("Vermilion", 126, 25, 27),
            new PaintColor("Red Prairie", 142, 57, 40),
            new PaintColor("Clay Pot", 154, 74, 51),
            new PaintColor("Bramble Bush", 80, 54, 41),
            new PaintColor("Woodsy Brown", 61, 39, 29),
            new PaintColor("Iron Gate", 63, 53, 43),
            new PaintColor("Weathervane", 44, 32, 26),
            new PaintColor("Garden Path", 66, 67, 48),
            new PaintColor("Marsh Fern", 76, 69, 39),
            new PaintColor("Black Emerald", 18, 34, 29),
            new PaintColor("Snowfall", 225, 223, 219),
            new PaintColor("Grayish", 208, 203, 200),
            new PaintColor("Essential Gray", 188, 184, 181),
            new PaintColor("Proper Gray", 174, 169, 166),
            new PaintColor("Mink", 134, 126, 121),
            new PaintColor("Folkstone", 111, 104, 100),
            new PaintColor("Black Bean", 64, 51, 46),
            new PaintColor("Smart White", 229, 221, 217),
            new PaintColor("Individual White", 214, 206, 204),
            new PaintColor("Imagine", 193, 182, 180),
            new PaintColor("Flexible Gray", 177, 164, 161),
            new PaintColor("Chinchilla", 137, 123, 119),
            new PaintColor("Browse Brown", 111, 98, 95),
            new PaintColor("Bitter Chocolate", 79, 61, 61),
            new PaintColor("Quartz White", 226, 218, 215),
            new PaintColor("Vaguely Mauve", 210, 198, 196),
            new PaintColor("Chaise Mauve", 193, 179, 178),
            new PaintColor("Intuitive", 179, 163, 163),
            new PaintColor("Enigma", 140, 124, 126),
            new PaintColor("Poetry Plum", 116, 97, 99),
            new PaintColor("Marooned", 80, 52, 51),
            new PaintColor("Dreamy White", 228, 218, 214),
            new PaintColor("Breathless", 213, 195, 190),
            new PaintColor("Insightful Rose", 201, 177, 171),
            new PaintColor("Dressy Rose", 184, 157, 153),
            new PaintColor("Socialite", 146, 119, 120),
            new PaintColor("River Rouge", 121, 92, 94),
            new PaintColor("Cordovan", 96, 61, 63),
            new PaintColor("Cultured Pearl", 229, 221, 215),
            new PaintColor("White Truffle", 215, 201, 194),
            new PaintColor("Artistic Taupe", 197, 179, 173),
            new PaintColor("Glamour", 182, 160, 154),
            new PaintColor("Dutch Cocoa", 144, 117, 108),
            new PaintColor("Bateau Brown", 127, 101, 94),
            new PaintColor("Arresting Auburn", 92, 56, 51),
            new PaintColor("Gauzy White", 228, 221, 214),
            new PaintColor("Angora", 210, 199, 191),
            new PaintColor("Temperate Taupe", 192, 179, 171),
            new PaintColor("Truly Taupe", 175, 162, 154),
            new PaintColor("Poised Taupe", 143, 131, 124),
            new PaintColor("Less Brown", 120, 107, 100),
            new PaintColor("Otter", 90, 74, 65),
            new PaintColor("Hush White", 230, 219, 212),
            new PaintColor("Unfussy Beige", 216, 202, 193),
            new PaintColor("Doeskin", 199, 181, 170),
            new PaintColor("Emerging Taupe", 185, 163, 151),
            new PaintColor("Swing Brown", 151, 123, 108),
            new PaintColor("Hot Cocoa", 130, 101, 86),
            new PaintColor("Terra Brun", 90, 57, 43),
            new PaintColor("Gorgeous White", 232, 220, 212),
            new PaintColor("Abalone Shell", 219, 201, 190),
            new PaintColor("Sashay Sand", 208, 183, 169),
            new PaintColor("Sandbank", 196, 166, 152),
            new PaintColor("Reddened Earth", 159, 113, 98),
            new PaintColor("Canyon Clay", 137, 93, 80),
            new PaintColor("Fiery Brown", 94, 57, 47),
            new PaintColor("Polite White", 234, 223, 213),
            new PaintColor("Malted Milk", 223, 204, 190),
            new PaintColor("Likeable Sand", 210, 186, 169),
            new PaintColor("Interface Tan", 195, 167, 149),
            new PaintColor("Moroccan Brown", 160, 125, 106),
            new PaintColor("Tanbark", 139, 104, 84),
            new PaintColor("Rugged Brown", 104, 67, 51),
            new PaintColor("Nice White", 231, 223, 214),
            new PaintColor("Reticence", 217, 207, 196),
            new PaintColor("Bona Fide Beige", 204, 187, 172),
            new PaintColor("Sand Trap", 187, 167, 149),
            new PaintColor("Mocha", 152, 127, 109),
            new PaintColor("Brevity Brown", 113, 84, 66),
            new PaintColor("French Roast", 81, 58, 45),
            new PaintColor("Heron Plume", 230, 226, 217),
            new PaintColor("Popular Gray", 213, 206, 196),
            new PaintColor("Versatile Gray", 194, 184, 172),
            new PaintColor("Perfect Greige", 181, 171, 158),
            new PaintColor("Spalding Gray", 145, 132, 121),
            new PaintColor("Garret Gray", 119, 107, 98),
            new PaintColor("Turkish Coffee", 79, 60, 50),
            new PaintColor("Everyday White", 228, 221, 212),
            new PaintColor("Realist Beige", 211, 202, 189),
            new PaintColor("Diverse Beige", 196, 183, 168),
            new PaintColor("Utterly Beige", 181, 168, 151),
            new PaintColor("Down Home", 144, 123, 102),
            new PaintColor("Cobble Brown", 124, 105, 87),
            new PaintColor("Sable", 93, 76, 61),
            new PaintColor("Modest White", 231, 222, 212),
            new PaintColor("Simplify Beige", 213, 200, 185),
            new PaintColor("Sand Dune", 196, 178, 160),
            new PaintColor("Trusty Tan", 181, 162, 143),
            new PaintColor("Nuthatch", 144, 120, 98),
            new PaintColor("Grounded", 121, 94, 72),
            new PaintColor("Java", 103, 76, 58),
            new PaintColor("Reliable White", 232, 224, 212),
            new PaintColor("Lightweight Beige", 218, 202, 185),
            new PaintColor("Familiar Beige", 203, 184, 162),
            new PaintColor("Sensational Sand", 190, 166, 141),
            new PaintColor("Toasty", 149, 118, 85),
            new PaintColor("Jute Brown", 129, 97, 65),
            new PaintColor("Sturdy Brown", 104, 74, 42),
            new PaintColor("Pacer White", 229, 222, 208),
            new PaintColor("Sand Dollar", 215, 200, 180),
            new PaintColor("Practical Beige", 201, 181, 156),
            new PaintColor("Sands Of Time", 187, 165, 139),
            new PaintColor("Portabello", 148, 126, 99),
            new PaintColor("Tea Chest", 124, 101, 75),
            new PaintColor("Kaffee", 101, 83, 62),
            new PaintColor("Divine White", 231, 222, 206),
            new PaintColor("Kilim Beige", 215, 201, 176),
            new PaintColor("Nomadic Desert", 198, 180, 152),
            new PaintColor("Latte", 186, 165, 135),
            new PaintColor("Hopsack", 158, 134, 101),
            new PaintColor("Steady Brown", 136, 110, 75),
            new PaintColor("Coconut Husk", 111, 89, 60),
            new PaintColor("Biscuit", 235, 223, 204),
            new PaintColor("Interactive Cream", 227, 206, 173),
            new PaintColor("Bagel", 214, 185, 147),
            new PaintColor("Totally Tan", 203, 171, 130),
            new PaintColor("Tatami Tan", 185, 147, 101),
            new PaintColor("Smokey Topaz", 165, 127, 84),
            new PaintColor("Leather Bound", 140, 102, 58),
            new PaintColor("Antique White", 231, 222, 199),
            new PaintColor("Believable Buff", 217, 202, 168),
            new PaintColor("Whole Wheat", 204, 186, 146),
            new PaintColor("Camelback", 195, 175, 134),
            new PaintColor("Baguette", 177, 151, 104),
            new PaintColor("Cardboard", 158, 130, 91),
            new PaintColor("Craft Paper", 137, 107, 73),
            new PaintColor("Navajo White", 234, 223, 201),
            new PaintColor("Ivoire", 226, 209, 172),
            new PaintColor("Blonde", 218, 193, 146),
            new PaintColor("Restrained Gold", 208, 183, 133),
            new PaintColor("Mannered Gold", 191, 159, 100),
            new PaintColor("Chamois", 173, 141, 84),
            new PaintColor("Relic Bronze", 144, 114, 61),
            new PaintColor("Muslin", 232, 225, 201),
            new PaintColor("Netsuke", 222, 210, 176),
            new PaintColor("Ecru", 207, 193, 151),
            new PaintColor("Harmonic Tan", 195, 180, 137),
            new PaintColor("Burlap", 171, 155, 115),
            new PaintColor("Artifact", 153, 136, 97),
            new PaintColor("Mossy Gold", 125, 106, 65),
            new PaintColor("Moderate White", 232, 223, 207),
            new PaintColor("Softer Tan", 217, 205, 178),
            new PaintColor("Macadamia", 203, 187, 156),
            new PaintColor("Basket Beige", 191, 174, 140),
            new PaintColor("Dapper Tan", 148, 131, 103),
            new PaintColor("Thatch Brown", 133, 115, 85),
            new PaintColor("Panda White", 233, 226, 213),
            new PaintColor("Wool Skein", 217, 209, 188),
            new PaintColor("Relaxed Khaki", 200, 190, 165),
            new PaintColor("Universal Khaki", 186, 174, 150),
            new PaintColor("Quiver Tan", 144, 132, 109),
            new PaintColor("Superior Bronze", 121, 110, 89),
            new PaintColor("Nacre", 232, 228, 212),
            new PaintColor("Rice Grain", 218, 210, 186),
            new PaintColor("Ramie", 203, 193, 163),
            new PaintColor("Favorite Tan", 191, 179, 146),
            new PaintColor("Sawdust", 154, 144, 116),
            new PaintColor("High Tea", 125, 115, 89),
            new PaintColor("Best Bronze", 92, 82, 60),
            new PaintColor("Nonchalant White", 222, 222, 210),
            new PaintColor("Ancient Marble", 208, 207, 187),
            new PaintColor("Grassland", 192, 190, 167),
            new PaintColor("Svelte Sage", 177, 176, 151),
            new PaintColor("Connected Gray", 138, 136, 118),
            new PaintColor("Eclipse", 105, 104, 86),
            new PaintColor("Garden Gate", 94, 92, 75),
            new PaintColor("Moderne White", 226, 225, 216),
            new PaintColor("Sedate Gray", 208, 206, 192),
            new PaintColor("Techno Gray", 190, 187, 170),
            new PaintColor("Chatroom", 175, 173, 156),
            new PaintColor("Hardware", 140, 135, 117),
            new PaintColor("Cocoon", 113, 108, 89),
            new PaintColor("Andiron", 67, 68, 57),
            new PaintColor("Sagey", 224, 227, 210),
            new PaintColor("Liveable Green", 205, 209, 189),
            new PaintColor("Softened Green", 186, 191, 168),
            new PaintColor("Clary Sage", 170, 176, 151),
            new PaintColor("Artichoke", 126, 135, 105),
            new PaintColor("Oakmoss", 100, 108, 78),
            new PaintColor("Secret Garden", 79, 86, 60),
            new PaintColor("Ethereal White", 228, 227, 220),
            new PaintColor("Conservative Gray", 209, 210, 197),
            new PaintColor("Austere Gray", 189, 191, 178),
            new PaintColor("Escape Gray", 169, 172, 158),
            new PaintColor("Dried Thyme", 123, 131, 114),
            new PaintColor("Rosemary", 100, 109, 94),
            new PaintColor("Shade-Grown", 77, 81, 70),
            new PaintColor("Opaline", 220, 224, 216),
            new PaintColor("Filmy Green", 208, 213, 199),
            new PaintColor("Contented", 189, 194, 180),
            new PaintColor("Coastal Plain", 157, 168, 148),
            new PaintColor("Privilege Green", 122, 139, 121),
            new PaintColor("Basil", 97, 114, 98),
            new PaintColor("Rock Garden", 70, 86, 73),
            new PaintColor("Frosty White", 221, 222, 214),
            new PaintColor("Aloof Gray", 201, 202, 193),
            new PaintColor("Sensible Hue", 181, 183, 172),
            new PaintColor("Rare Gray", 166, 168, 156),
            new PaintColor("Link Gray", 128, 129, 116),
            new PaintColor("Thunderous", 111, 112, 101),
            new PaintColor("Cast Iron", 101, 103, 92),
            new PaintColor("Spare White", 229, 229, 222),
            new PaintColor("Sea Salt", 205, 211, 202),
            new PaintColor("Comfort Gray", 189, 195, 185),
            new PaintColor("Oyster Bay", 172, 179, 168),
            new PaintColor("Retreat", 124, 131, 121),
            new PaintColor("Pewter Green", 95, 100, 90),
            new PaintColor("Ripe Olive", 71, 76, 66),
            new PaintColor("Window Pane", 216, 224, 218),
            new PaintColor("Rainwashed", 194, 205, 198),
            new PaintColor("Quietude", 171, 187, 180),
            new PaintColor("Halcyon Green", 155, 172, 164),
            new PaintColor("Underseas", 126, 145, 139),
            new PaintColor("Rocky River", 97, 116, 110),
            new PaintColor("Jasper", 52, 60, 55),
            new PaintColor("Topsail", 218, 227, 224),
            new PaintColor("Tradewind", 194, 208, 209),
            new PaintColor("Rain", 172, 190, 193),
            new PaintColor("Interesting Aqua", 155, 175, 179),
            new PaintColor("Moody Blue", 125, 147, 149),
            new PaintColor("Riverway", 96, 116, 119),
            new PaintColor("Still Water", 76, 94, 97),
            new PaintColor("Mountain Air", 217, 223, 223),
            new PaintColor("Sleepy Blue", 188, 203, 207),
            new PaintColor("Languid Blue", 166, 184, 191),
            new PaintColor("Meditative", 151, 169, 177),
            new PaintColor("Refuge", 100, 125, 135),
            new PaintColor("Tempe Star", 75, 98, 109),
            new PaintColor("Rainstorm", 43, 70, 86),
            new PaintColor("Rock Candy", 223, 225, 224),
            new PaintColor("Misty", 205, 209, 210),
            new PaintColor("Samovar Silver", 185, 190, 191),
            new PaintColor("Uncertain Gray", 168, 175, 177),
            new PaintColor("Foggy Day", 117, 126, 130),
            new PaintColor("Grays Harbor", 90, 100, 104),
            new PaintColor("Dark Night", 41, 59, 67),
            new PaintColor("Icicle", 220, 223, 225),
            new PaintColor("Upward", 193, 201, 209),
            new PaintColor("Windy Blue", 172, 185, 199),
            new PaintColor("Aleutian", 156, 170, 186),
            new PaintColor("Bracing Blue", 6, 124, 158),
            new PaintColor("Distance", 98, 110, 130),
            new PaintColor("Naval", 48, 58, 76),
            new PaintColor("Quicksilver", 222, 226, 225),
            new PaintColor("North Star", 202, 208, 210),
            new PaintColor("Krypton", 186, 193, 196),
            new PaintColor("Jubilee", 173, 180, 184),
            new PaintColor("Storm Cloud", 125, 134, 144),
            new PaintColor("Granite Peak", 100, 110, 121),
            new PaintColor("Outerspace", 84, 92, 100),
            new PaintColor("Ice Cube", 227, 228, 226),
            new PaintColor("Olympus White", 213, 216, 216),
            new PaintColor("Lazy Gray", 191, 193, 196),
            new PaintColor("Morning Fog", 168, 173, 177),
            new PaintColor("Serious Gray", 128, 134, 141),
            new PaintColor("Gibraltar", 101, 107, 115),
            new PaintColor("Tricorn Black", 45, 45, 46),
            new PaintColor("Spatial White", 222, 221, 221),
            new PaintColor("Unique Gray", 203, 201, 204),
            new PaintColor("Swanky Gray", 182, 179, 183),
            new PaintColor("Mysterious Mauve", 167, 163, 169),
            new PaintColor("Exclusive Plum", 118, 113, 122),
            new PaintColor("Midnight", 94, 90, 99),
            new PaintColor("Quixotic Plum", 74, 68, 83),
            new PaintColor("Discreet White", 224, 220, 220),
            new PaintColor("Sensitive Tint", 208, 201, 205),
            new PaintColor("Veiled Violet", 190, 181, 185),
            new PaintColor("Beguiling Mauve", 177, 167, 172),
            new PaintColor("Soulmate", 137, 120, 126),
            new PaintColor("Expressive Plum", 108, 92, 100),
            new PaintColor("Plum Brown", 79, 66, 71),
            new PaintColor("Nouvelle White", 226, 221, 218),
            new PaintColor("Destiny", 208, 202, 201),
            new PaintColor("Fashionable Gray", 190, 185, 185),
            new PaintColor("Mystical Shade", 175, 170, 171),
            new PaintColor("Special Gray", 126, 122, 127),
            new PaintColor("Cloak Gray", 97, 94, 100),
            new PaintColor("Black Swan", 59, 55, 62),
            new PaintColor("Mauve Tinge", 233, 226, 226),
            new PaintColor("Wallflower", 221, 207, 213),
            new PaintColor("Mauve Finery", 206, 184, 193),
            new PaintColor("Thistle", 176, 144, 157),
            new PaintColor("Plum Dandy", 143, 107, 123),
            new PaintColor("Grape Harvest", 130, 92, 111),
            new PaintColor("Mature Grape", 98, 63, 84),
            new PaintColor("White Beet", 236, 224, 222),
            new PaintColor("Rosebud", 226, 206, 210),
            new PaintColor("Delightful", 212, 182, 190),
            new PaintColor("Rosè", 188, 149, 161),
            new PaintColor("Moss Rose", 162, 110, 123),
            new PaintColor("Berry Bush", 146, 89, 105),
            new PaintColor("Fabulous Grape", 112, 50, 78),
            new PaintColor("Rose Of Sharon", 235, 220, 220),
            new PaintColor("Demure", 234, 213, 213),
            new PaintColor("Fading Rose", 220, 190, 193),
            new PaintColor("Rose Embroidery", 201, 158, 162),
            new PaintColor("Concerto", 162, 110, 118),
            new PaintColor("Aged Wine", 138, 82, 94),
            new PaintColor("Burgundy", 102, 50, 61),
            new PaintColor("Patient White", 240, 226, 222),
            new PaintColor("Innocence", 237, 211, 208),
            new PaintColor("Rose Colored", 222, 184, 181),
            new PaintColor("Pressed Flower", 197, 149, 147),
            new PaintColor("Rambling Rose", 158, 97, 101),
            new PaintColor("Cordial", 136, 75, 80),
            new PaintColor("Fine Wine", 118, 57, 66),
            new PaintColor("Possibly Pink", 240, 223, 220),
            new PaintColor("Charming Pink", 238, 212, 211),
            new PaintColor("Lotus Flower", 233, 190, 189),
            new PaintColor("Memorable Rose", 211, 139, 140),
            new PaintColor("Redbud", 180, 96, 102),
            new PaintColor("Kirsch Red", 154, 70, 80),
            new PaintColor("Luxurious Red", 138, 57, 65),
            new PaintColor("White Dogwood", 239, 221, 215),
            new PaintColor("Rosy Outlook", 237, 207, 203),
            new PaintColor("Gracious Rose", 229, 183, 177),
            new PaintColor("Resounding Rose", 208, 144, 137),
            new PaintColor("Reddish", 187, 110, 104),
            new PaintColor("Bravado Red", 165, 85, 77),
            new PaintColor("Red Bay", 145, 51, 52),
            new PaintColor("Intimate White", 240, 225, 215),
            new PaintColor("Romance", 237, 209, 195),
            new PaintColor("Mellow Coral", 228, 182, 167),
            new PaintColor("Constant Coral", 207, 144, 126),
            new PaintColor("Henna Shade", 184, 107, 94),
            new PaintColor("Bold Brick", 164, 89, 77),
            new PaintColor("Fireweed", 125, 54, 46),
            new PaintColor("Faint Coral", 239, 223, 213),
            new PaintColor("Quaint Peche", 235, 206, 193),
            new PaintColor("Smoky Salmon", 227, 185, 166),
            new PaintColor("Coral Island", 208, 150, 130),
            new PaintColor("Foxy", 173, 97, 83),
            new PaintColor("Flower Pot", 145, 67, 52),
            new PaintColor("Fired Brick", 134, 58, 43),
            new PaintColor("Nearly Peach", 237, 224, 210),
            new PaintColor("Spun Sugar", 237, 212, 192),
            new PaintColor("Warmin", 229, 187, 163),
            new PaintColor("Persimmon", 218, 156, 126),
            new PaintColor("Baked Clay", 195, 125, 91),
            new PaintColor("Red Cent", 177, 104, 74),
            new PaintColor("Spicy Hue", 155, 76, 50),
            new PaintColor("Alluring White", 240, 227, 211),
            new PaintColor("Peach Fuzz", 235, 209, 186),
            new PaintColor("Sumptuous Peach", 230, 188, 155),
            new PaintColor("Fame Orange", 222, 159, 122),
            new PaintColor("Chrysanthemum", 199, 128, 90),
            new PaintColor("Reynard", 182, 107, 69),
            new PaintColor("Pennywise", 163, 90, 54),
            new PaintColor("Intricate Ivory", 237, 223, 202),
            new PaintColor("Sweet Orange", 236, 208, 180),
            new PaintColor("Soft Apricot", 225, 183, 147),
            new PaintColor("Chivalry Copper", 213, 155, 111),
            new PaintColor("Armagnac", 196, 135, 87),
            new PaintColor("Truepenny", 180, 112, 62),
            new PaintColor("Copper Mountain", 166, 100, 55),
            new PaintColor("Choice Cream", 240, 227, 209),
            new PaintColor("Creamery", 237, 212, 182),
            new PaintColor("Sociable", 231, 195, 154),
            new PaintColor("Folksy Gold", 214, 159, 103),
            new PaintColor("Autumnal", 205, 147, 92),
            new PaintColor("Tigereye", 186, 124, 68),
            new PaintColor("Gingery", 175, 112, 57),
            new PaintColor("Eggwhite", 242, 232, 210),
            new PaintColor("Cachet Cream", 242, 220, 185),
            new PaintColor("Ambitious Amber", 239, 207, 149),
            new PaintColor("Viva Gold", 228, 182, 115),
            new PaintColor("Bakelite Gold", 213, 162, 91),
            new PaintColor("Tassel", 196, 143, 68),
            new PaintColor("Saucy Gold", 179, 122, 53),
            new PaintColor("Vanillin", 240, 229, 202),
            new PaintColor("Inviting Ivory", 240, 218, 176),
            new PaintColor("Harvester", 234, 201, 140),
            new PaintColor("Torchlight", 227, 184, 108),
            new PaintColor("Honeycomb", 211, 161, 84),
            new PaintColor("Gold Coast", 197, 143, 59),
            new PaintColor("Butterscotch", 181, 129, 53),
            new PaintColor("Crisp Linen", 242, 232, 212),
            new PaintColor("Jersey Cream", 241, 224, 186),
            new PaintColor("Humble Gold", 234, 206, 148),
            new PaintColor("Anjou Pear", 218, 181, 107),
            new PaintColor("Ceremonial Gold", 209, 167, 87),
            new PaintColor("Golden Rule", 200, 153, 66),
            new PaintColor("Cut The Mustard", 183, 135, 49),
            new PaintColor("Dover White", 239, 236, 221),
            new PaintColor("Na 6386pe yr", 237, 224, 3),
            new PaintColor("Compatible Cream", 230, 206, 157),
            new PaintColor("Golden Fleece", 212, 180, 119),
            new PaintColor("Butternut", 201, 163, 91),
            new PaintColor("Bosc Pear", 188, 151, 84),
            new PaintColor("Gallant Gold", 162, 127, 61),
            new PaintColor("Vital Yellow", 236, 228, 197),
            new PaintColor("Convivial Yellow", 230, 218, 175),
            new PaintColor("Sequin", 221, 200, 139),
            new PaintColor("Alchemy", 199, 171, 88),
            new PaintColor("Different Gold", 184, 157, 76),
            new PaintColor("Nankeen", 164, 135, 48),
            new PaintColor("Sconce Gold", 152, 121, 52),
            new PaintColor("Chamomile", 231, 227, 197),
            new PaintColor("Lucent Yellow", 224, 213, 165),
            new PaintColor("Independent Gold", 205, 193, 129),
            new PaintColor("Antiquity", 188, 172, 94),
            new PaintColor("Escapade Gold", 177, 163, 84),
            new PaintColor("Grandiose", 151, 133, 60),
            new PaintColor("Fervent Brass", 145, 127, 57),
            new PaintColor("Ionic Ivory", 230, 226, 198),
            new PaintColor("Ancestral Gold", 219, 209, 166),
            new PaintColor("Wheat Grass", 199, 188, 133),
            new PaintColor("Edgy Gold", 174, 161, 97),
            new PaintColor("Brassy", 156, 141, 73),
            new PaintColor("Bengal Grass", 137, 124, 57),
            new PaintColor("Eminent Bronze", 120, 107, 64),
            new PaintColor("Restoration Ivory", 232, 228, 202),
            new PaintColor("Rice Paddy", 219, 216, 176),
            new PaintColor("Hearts Of Palm", 203, 199, 145),
            new PaintColor("Sassy Green", 180, 174, 104),
            new PaintColor("Tupelo Tree", 152, 149, 81),
            new PaintColor("Rural Green", 138, 136, 76),
            new PaintColor("Saguaro", 97, 97, 41),
            new PaintColor("Queen Anne's Lace", 236, 235, 214),
            new PaintColor("Celery", 224, 224, 191),
            new PaintColor("Shagreen", 201, 205, 156),
            new PaintColor("Ryegrass", 173, 177, 122),
            new PaintColor("Tansy Green", 147, 153, 93),
            new PaintColor("Relentless Olive", 110, 116, 59),
            new PaintColor("Basque Green", 92, 99, 48),
            new PaintColor("Sprout", 228, 232, 208),
            new PaintColor("Honeydew", 218, 224, 190),
            new PaintColor("Baize Green", 197, 208, 168),
            new PaintColor("Great Green", 169, 183, 133),
            new PaintColor("Leapfrog", 133, 150, 94),
            new PaintColor("Garden Spot", 106, 122, 69)
        };
    }
}