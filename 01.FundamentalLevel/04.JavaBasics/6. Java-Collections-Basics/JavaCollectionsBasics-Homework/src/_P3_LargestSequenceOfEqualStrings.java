import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _P3_LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");
        List<String> results = new ArrayList<>();

        if (input.length == 1){
            results.add(input[0]);
        }

        for (int i = 0; i < input.length - 1; i++) {
            List<String> arr = new ArrayList<>();
            arr.add(input[i]);
            while (i < input.length - 1 && input[i+1].equals(input[i])){
                arr.add(input[i+1]);
                i++;
            }
            if (arr.size()> results.size()){
                results.clear();
                results.addAll(arr);
            }

        }
        for (String result : results) {
            System.out.print(result + " ");
        }
    }
}
