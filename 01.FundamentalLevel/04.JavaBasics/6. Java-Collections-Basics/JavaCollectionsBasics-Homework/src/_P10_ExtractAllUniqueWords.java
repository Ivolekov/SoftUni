import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _P10_ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toString().toLowerCase().split("[^\\w]+");
        Set<String> uniqueList = new TreeSet<>();
        for (int i = 0; i < input.length; i++) {
            uniqueList.add(input[i]);
        }

        for (String uniqueWord : uniqueList) {
            System.out.print(uniqueWord + " ");
        }
    }
}
