import java.util.Scanner;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = Integer.parseInt(scanner.next());
        int end = Integer.parseInt(scanner.next());

        for (int i = start; i <= end; i++) {
            if (start < 0 || start > end || end > 999) {
                System.out.println("Invalid input");
                break;
            } else {
                if (i / 10 == 0) {
                    System.out.print(i + " ");
                } else if (i / 100 == 0) {
                    if (i % 10 == i / 10) {
                        System.out.print(i + " ");
                    }
                } else if (i % 10 == i / 100) {
                    System.out.print(i + " ");
                }
            }
        }

    }
}
