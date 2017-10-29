import java.lang.reflect.Array;
import java.math.BigDecimal;
import java.util.*;

public class PossibleTriangels {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        ArrayList<String> triangels = new ArrayList<>();

        while (!input.equals("End")) {
            String[] sides = input.split(" ");
            BigDecimal[] values = new BigDecimal[sides.length];

            for (int i = 0; i < values.length; i++) {
                values[i] = new BigDecimal(sides[i]);
            }

            Arrays.sort(values);
            BigDecimal a = values[0];
            BigDecimal b = values[1];
            BigDecimal c = values[2];

            if (a.add(b).compareTo(c) > 0) {
                triangels.add(String.format("%.2f+%.2f>%.2f", a, b, c));
            }
            input = scan.nextLine();
        }
        if (triangels.size()>0){
            for (String triangel : triangels) {
                System.out.println(triangel);
            }
        }else{
            System.out.println("No");
        }

    }
}
