import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Gandaf {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Integer gandolfFirstMood = Integer.parseInt(scanner.nextLine());
        String[] data = scanner.nextLine().split("[^A-Za-z]+");

        List<String> foodList = new ArrayList<>();

        for (int i = 0; i < data.length; i++) {
            foodList.add(data[i].toLowerCase());
        }

        int happinessPoints = gandolfFirstMood;

        for (String food : foodList) {
            switch (food) {
                case "cram":
                    happinessPoints += 2;
                    break;
                case "lembas":
                    happinessPoints += 3;
                    break;
                case "apple":
                    happinessPoints += 1;
                    break;
                case "melon":
                    happinessPoints += 1;
                    break;
                case "honeycake":
                    happinessPoints += 5;
                    break;
                case "mushrooms":
                    happinessPoints -= 10;
                    break;
                default:
                    happinessPoints -= 1;
                    break;
            }
        }
        System.out.println(happinessPoints);
        if (happinessPoints < -5) {
                    System.out.print("Angry");
                } else if (happinessPoints >= -5 && happinessPoints < 0) {
                    System.out.print("Sad");
                } else if (happinessPoints >= 0 && happinessPoints < 15) {
                    System.out.print("Happy");
                } else {
                    System.out.print("Special JavaScript mood");
                }
    }
}
