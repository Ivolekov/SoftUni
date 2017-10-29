import java.util.Scanner;

public class _P2_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");

        boolean isEqual;
        System.out.print(input[0] + " ");
        for (int i = 1; i < input.length; i++) {
            if (input[i].equals(input[i - 1])){
                isEqual = true;
            }else{
                isEqual = false;
            }
            if (isEqual){
                System.out.print(input[i] + " ");
            } else {
                System.out.print("\n" + input[i] + " ");
            }
        }

    }
}
