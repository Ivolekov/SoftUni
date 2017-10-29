import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class TerrortistWin {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        StringBuilder input = new StringBuilder(scan.nextLine());

        int bombStartIndex = 0;
        int bombEndIndex = 0;
        int currenIndex = 0;
        while ((bombStartIndex = input.indexOf("|", currenIndex)) != -1) {
            bombEndIndex = input.indexOf("|", bombStartIndex + 1);
            String bombContent = input.substring(bombStartIndex + 1, bombEndIndex);
            int bombPower = 0;
            for (char ch : bombContent.toCharArray()) {
                bombPower += ch;
            }
            bombPower %= 10;
            int startIndex = Math.max(0, bombStartIndex - bombPower);
            int endIndex = Math.min(input.length() - 1, bombEndIndex + bombPower);
            while (startIndex <= endIndex) {
                input.setCharAt(startIndex, '.');
                startIndex++;
            }
            currenIndex = bombEndIndex + 1;

        }
        System.out.println(input);
    }
}
