import java.util.Scanner;

public class _P5_CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("[^\\w]+");
        int count = 0;
        for (int i = 0; i < input.length; i++) {
            count++;

        }
        System.out.print(count);
    }
}
