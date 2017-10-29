import java.util.Scanner;

public class DecimalToHexadecimal {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();
        String hex = Integer.toHexString(number);
        System.out.println("Hex value is " + hex.toUpperCase());
    }
}