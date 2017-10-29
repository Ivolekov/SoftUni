import java.util.Scanner;

public class Enigma {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        int m;

        for (int i = 0; i < n; i++) {
            String input = scan.nextLine();
            m = input.replaceAll("[\\s\\d]+", "").length() / 2;

            for (int j = 0; j < input.length(); j++) {
                char currentChar = input.charAt(j);
                if (currentChar >= '0' && currentChar <= '9' || currentChar == ' ') {
                    System.out.print(currentChar);
                    continue;
                }
                char c = (char)(currentChar + m);
                System.out.print(c);

            }
            System.out.println();
        }


    }
}
