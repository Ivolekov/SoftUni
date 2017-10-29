import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.print("Enter a number: ");

        int numberToCountLines = input.nextInt();

        ArrayList<String> strings = new ArrayList<>();

        for (int i = 0; i <= numberToCountLines; i++) {
            strings.add(input.nextLine());
        }

        Arrays.toString(strings.toArray());

        Collections.sort(strings);

        for (String line : strings) {
            System.out.println(line);
        }

    }
}
