import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class TheSmallestOfThreeNumbers {
    public static void main(String[] args) {

        ArrayList<Double> arrayOfDoubles = new ArrayList<Double>();

        Scanner input = new Scanner(System.in);

        for (int i = 0; i < 3; i++){
            arrayOfDoubles.add(input.nextDouble());
        }

        double smallestNumber = Collections.min(arrayOfDoubles);
        System.out.println(smallestNumber);
    }
}
