import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class LegoBlocks {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());

        List<ArrayList<Integer>> first = new ArrayList<>();
        List<ArrayList<Integer>> second = new ArrayList<>();


        takeInput(scan, n, first);
        takeInput(scan, n, second);

        List<ArrayList<Integer>> marged = new ArrayList<>();
        for (int i = 0; i < first.size(); i++) {
            marged.add(new ArrayList<>());
            Collections.reverse(second.get(i));
            marged.get(i).addAll(first.get(i));
            marged.get(i).addAll(second.get(i));

        }
        boolean isRextangelar = false;
        int size = marged.get(0).size();
        for (int i = 1; i < marged.size(); i++) {
            if (size == marged.get(i).size()) {

                isRextangelar = true;
            } else {

                isRextangelar = false;
                break;
            }
        }

        if (isRextangelar){
            for (ArrayList<Integer> strings : marged) {
            System.out.println(strings);
            }
        }else{
            int count = 0;
            for (ArrayList<Integer> integers : marged) {
                count += integers.size();
            }
            System.out.printf("The total number of cells is: %d", count);
        }
    }

    private static void takeInput(Scanner scan, int n, List<ArrayList<Integer>> arr) {
        for (int i = 0; i < n; i++) {
            arr.add(new ArrayList<>());
            String[] strings = scan.nextLine().trim().split("\\s+");
            for (String string : strings) {
                arr.get(i).add(Integer.parseInt(string));
            }
        }
    }
}
