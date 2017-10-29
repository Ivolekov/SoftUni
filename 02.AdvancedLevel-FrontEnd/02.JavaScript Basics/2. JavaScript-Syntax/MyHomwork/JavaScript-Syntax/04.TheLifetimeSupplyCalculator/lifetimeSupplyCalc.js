function calcSupply(age, maxAge, food, foodPerDay){
    var years = (age - maxAge) * -1;
    var amount = (365 * years) * foodPerDay;
    console.log(amount + 'kg of ' + food + ' would be enough until I am ' + maxAge + ' years old.');
}

calcSupply(38, 118, 'chocolate', 0.5);
calcSupply(20, 87, 'fruits', 2);
calcSupply(16, 102, 'nuts', 1.1);