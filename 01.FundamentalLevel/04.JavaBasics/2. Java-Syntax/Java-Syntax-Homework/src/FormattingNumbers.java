import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int a = input.nextInt();
        double b = input.nextDouble();
        double c = input.nextDouble();

        String aHex = Integer.toHexString(a);
        int aBinary = Integer.parseInt(Integer.toBinaryString(a));

        System.out.printf("|%1$-10s|%2$010d|%3$10.2f|%4$-10.3f|", aHex.toUpperCase(), aBinary, b, c);
    }
}
