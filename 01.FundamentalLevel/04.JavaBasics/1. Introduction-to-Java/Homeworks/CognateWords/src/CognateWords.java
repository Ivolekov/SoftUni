import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class CognateWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("[^A-Za-z]+");

        Set<String> results = new HashSet<>();

        for (int a = 0; a < input.length; a++) {
            for (int b = 0; b < input.length; b++) {
                for (int c = 0; c < input.length; c++) {
                    if (a != b) {
                        boolean check = (input[a] + input[b]).equals(input[c]);
                        if (check){
                            results.add(input[a] + "|" + input[b] + "=" + input[c]);
                        }
                    }
                }

            }
        }

        if (results.isEmpty()){
            System.out.print("No");
        }else {
            for (String result : results) {
                System.out.println(result);
            }
        }
    }
}
