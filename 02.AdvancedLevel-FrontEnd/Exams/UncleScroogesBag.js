function calculateCoins(input){
    var coins = 0,
        gold = 0,
        silver = 0,
        bronze = 0;

    for (var i = 0; i < input.length; i++) {
        var arr = input[i].split(" ");
        var type = arr[0].toLowerCase();
        var value = arr[1];

        if (type === 'coin' && value > 0 && isInt(value)){
            coins += parseInt(value);
        }
    }

    bronze += Math.floor(coins%10);
    silver += (coins % 100) - bronze;
    gold += coins - silver - bronze;
    console.log("gold : " + gold / 100);
    console.log("silver : " + silver / 10);
    console.log("bronze : " + bronze);

    function isInt(value){
        return value % 1 === 0;
    }

}

calculateCoins(['coin 10001', 'coin 200.0', 'coin -5', 'coin 10.50', 'coin 2002.00', 'coin fifty', 'coin -100', 'cigars 1']);