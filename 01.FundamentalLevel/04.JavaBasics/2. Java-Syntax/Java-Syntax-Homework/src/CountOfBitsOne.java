import java.util.Scanner;

public class CountOfBitsOne {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int inputNumber = input.nextInt();

        String binary = Integer.toBinaryString(inputNumber);

        int countBits = 0;

        for (int i = 0; i < binary.length(); i++) {
            if (binary.charAt(i) == '1') {
                countBits++;
            }
        }

        System.out.println(countBits);
    }
}
