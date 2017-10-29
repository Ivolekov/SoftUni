import java.util.Scanner;

public class _P7_CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        String substring = scan.nextLine();

        Integer interval = substring.length();

        int substringCount = 0;

        for (int i = 0; i <= input.length() - substring.length(); i++) {
            String pattern = input.substring(i, interval);

            if (pattern.toLowerCase().equals(substring.toLowerCase())) {
                substringCount++;
            }

            interval++;
        }

        System.out.println(substringCount);
    }
}
