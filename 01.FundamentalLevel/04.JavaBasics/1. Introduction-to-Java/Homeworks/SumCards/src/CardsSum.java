import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CardsSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("[SHDC]");
        List<String> list = new ArrayList<>();
        for (int i = 0; i < input.length; i++) {
            list.add(input[i]);
        }
List<Integer> ints = new ArrayList<>();
        for (String s : list) {
            switch (s){
                case "A": ints.add(15);continue;
                case "K": ints.add(14);continue;
                case "Q": ints.add(13);continue;
                case "J": ints.add(12);continue;
                case "10": ints.add(10);continue;
                case "9": ints.add(9);continue;
                case "8": ints.add(8);continue;
                case "7": ints.add(7);continue;
                case "6": ints.add(6);continue;
                case "5": ints.add(5);continue;
                case "4": ints.add(4);continue;
                case "3": ints.add(3);continue;
                case "2": ints.add(2);continue;
                default:break;

            }
        }
    }
}
