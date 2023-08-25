using System;
namespace Zmywara;

public void Main()
{
    // Fill the sink with hot water.
    Sink.FillWithHotWater();
   


    // Add dish soap to the water.
    Sink.AddDishSoap();


    // Place the dishes in the sink.
    Dishes.PlaceInSink();


    // Scrub the dishes with a sponge.
    Dishes.ScrubWithSponge();


    // Rinse the dishes with water.
    Dishes.RinseWithWater();


    // Dry the dishes with a towel.
    Dishes.DryWithTowel();


    // Put the dishes away.
    Dishes.PutAway();

    // Wash the sink after washing dishes
    Sink.WashingSink();
}
