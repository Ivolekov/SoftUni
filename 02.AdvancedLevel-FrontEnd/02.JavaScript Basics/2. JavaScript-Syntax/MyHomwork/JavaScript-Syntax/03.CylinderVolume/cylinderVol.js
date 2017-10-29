function calcCylinderVol(radius, height) {
    var vol = Math.PI * Math.pow(radius, 2) * height;
    console.log(vol.toFixed(3));
}

calcCylinderVol(2, 4);
calcCylinderVol(5, 8);
calcCylinderVol(12, 3);