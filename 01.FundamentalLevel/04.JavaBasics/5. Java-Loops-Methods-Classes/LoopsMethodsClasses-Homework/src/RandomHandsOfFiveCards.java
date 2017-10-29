import java.util.HashSet;
import java.util.Random;
import java.util.Scanner;

public class RandomHandsOfFiveCards {
    public static void main(String[] args) {
        Random rand = new Random();
        Scanner scaner = new Scanner(System.in);
        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] suits = {"\u2660", "\u2665", "\u2666", "\u2663"};
        System.out.println("How many hands would you like to get");
        int numberOfHands = scaner.nextInt();
        for (int i = 0; i < numberOfHands; i++) {
            HashSet hands = new HashSet();

            while (hands.size() < 5){
                String face = faces[rand.nextInt(13)];
                String suit = suits[rand.nextInt(4)];
                hands.add(face+suit);
            }
            for (Object hand : hands) {
                System.out.print(hand + " ");
            }
            System.out.println();
        }
    }
}
