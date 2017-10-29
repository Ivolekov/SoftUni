import java.util.*;

public class MirrorNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = scanner.nextInt();
        }
        boolean isMatched = false;
        for (int i = 0; i < numbers.length; i++) {
            for (int j = i + 1; j < numbers.length; j++) {
                String a = Integer.toString(numbers[i]);
                String b = Integer.toString(numbers[j]);

                if (a.charAt(0) == b.charAt(3) && a.charAt(1) == b.charAt(2) &&
                        a.charAt(2) == b.charAt(1) && a.charAt(3) == b.charAt(0)) {
                    System.out.printf("%s<!>%s\n", a, b);
                    isMatched = true;
                }
            }

        }
        if (!isMatched){
            System.out.println("No");
        }

    }
}
