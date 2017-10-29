import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class StuckNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        List<Integer> nums = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            int input = scan.nextInt();
            nums.add(input);
        }
        int count = 0;
        for (int i = 0; i < nums.size(); i++) {
            for (int j = 0; j < nums.size(); j++) {
                for (int k = 0; k < nums.size(); k++) {
                    for (int l = 0; l < nums.size(); l++) {
                        int a = nums.get(i);
                        int b = nums.get(j);
                        int c = nums.get(k);
                        int d = nums.get(l);

                        if (a != b && a != c && a != d && b != c && b != d && c != d) {
                            String first = "" + a + b;
                            String second = "" + c + d;
                            if (first.equals(second)) {
                                System.out.format("%d|%d==%d|%d\n", a, b, c, d);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count == 0){
            System.out.print("No");
        }
    }
}
