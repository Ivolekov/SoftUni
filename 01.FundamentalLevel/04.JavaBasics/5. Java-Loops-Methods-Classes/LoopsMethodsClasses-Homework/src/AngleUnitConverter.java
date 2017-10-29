import java.util.Scanner;

public class AngleUnitConverter {
    private static final double constant = 0.0174532925;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        for (int i = 0; i < n; i++) {

            double num = scanner.nextDouble();
            String radOrDeg = scanner.next("[a-z]+");

            if (radOrDeg.equals("rad")) {
                double result = fromRadToDeg(num);
                System.out.printf("%.6f deg\n", result);
            } else if (radOrDeg.equals("deg")) {
                double result = fromDegToRad(num);
                System.out.printf("%.6f rad\n", result);
            }

        }

    }

    private static double fromDegToRad(double num) {
        double result = num * constant;
        return result;
    }

    private static double fromRadToDeg(double num) {
        double result = num / constant;
        return result;
    }
}
