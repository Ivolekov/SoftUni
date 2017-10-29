function converKmToKnots(km){
    var oneKnotInKm = 1.852;
    var knots = km / oneKnotInKm;
    console.log(Math.round(knots * 100) / 100);
}

converKmToKnots(20);
converKmToKnots(112);
converKmToKnots(400);

