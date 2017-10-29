import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Pyramid {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        List<Integer> nums = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            String pyramid = scan.nextLine().trim().replaceAll("[\\s]+", " ");
            for (int j = 0; j < pyramid.length(); j++) {
                nums.add((int) pyramid.charAt(j));

            }
        }
    }
}
