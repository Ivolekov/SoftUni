import java.util.Scanner;

public class GenerateThreeLetterWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        char[] letter = input.toCharArray();
        for (int i = 0; i < letter.length; i++) {
            for (int j = 0; j < letter.length; j++) {
                for (int k = 0; k < letter.length; k++) {
                    System.out.print(" " + letter[i] + letter[j] + letter[k] + " ");

                }

            }
        }
    }
}
