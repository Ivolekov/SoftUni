import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _P4_LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");
        int[] inputAsNums = new int[input.length];

        for (int i = 0; i < inputAsNums.length; i++) {
            inputAsNums[i] = Integer.parseInt(input[i]);

        }
        List<Integer> sequance = new ArrayList<>();

        for (int i = 0; i < inputAsNums.length - 1; i++) {
            List<Integer> temp = new ArrayList<>();
            temp.add(inputAsNums[i]);
            while ((i < inputAsNums.length - 1) && (inputAsNums[i + 1] > inputAsNums[i])) {
                temp.add(inputAsNums[i+1]);
                i++;
            }
            System.out.println(temp);
            if (temp.size() > sequance.size()){
                sequance.clear();
                sequance.addAll(temp);
            }
        }
        System.out.print(String.join(" "));
        System.out.println("Longest: " + sequance);
    }
}
