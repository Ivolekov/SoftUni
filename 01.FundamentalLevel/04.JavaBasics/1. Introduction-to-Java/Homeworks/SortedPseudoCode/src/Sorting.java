import java.util.ArrayList;
import java.util.Scanner;

public class Sorting {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] numbers = scan.nextLine().replace("[", "").replace("]", "").split(", ");
        ArrayList<Integer> numbersArr = new ArrayList<Integer>();

        for (int i = 0; i < numbers.length; i++) {

            numbersArr.add(Integer.parseInt(numbers[i]));
        }

//        StopWatch stopWatch = new StopWatch();
//        stopWatch.start();
        Integer swap = 0;

        //TODO: Write the sorting algorithm that you use for sorting the List's elements
        for (Integer i = 0; i < numbersArr.size() - 1; i++) {
            for (Integer j = 1; j < numbersArr.size() - i; j++) {
                if (Integer.compare(numbersArr.get(j-1), numbersArr.get(j))>0) {
                    swap.equals(numbersArr.get(j-1));
                    numbersArr.get(j-1).equals(numbersArr.get(j));
                    numbersArr.get(j).equals(swap);

                }

            }

        }
//        stopWatch.stop();
//        long time = stopWatch.getTime();
        for (int i = 0; i < numbersArr.size(); i++) {
            System.out.println(numbersArr.get(i));
        }

//        System.out.println(time/1000.0);
    }
}
