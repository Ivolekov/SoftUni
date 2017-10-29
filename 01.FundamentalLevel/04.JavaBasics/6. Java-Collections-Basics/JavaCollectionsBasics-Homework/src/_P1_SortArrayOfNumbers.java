import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class _P1_SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int[] nums = new int[n];

        for (int i = 0; i < n; i++) {
            nums[i] = scanner.nextInt();
        }

        Arrays.sort(nums);

        for (int num : nums) {
            System.out.print(num + " ");
        }
    }
}
