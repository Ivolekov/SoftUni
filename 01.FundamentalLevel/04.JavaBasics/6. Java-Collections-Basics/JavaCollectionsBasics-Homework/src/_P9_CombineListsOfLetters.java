import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _P9_CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char[] firstList = scan.nextLine().replaceAll(" ", "").toCharArray();
        char[] secondList = scan.nextLine().replaceAll(" ", "").toCharArray();

        List<Character> result = new ArrayList();
        List<Character> charList = new ArrayList<>();

        for (char firstChars : firstList) {
            result.add(firstChars);
            charList.add(firstChars);
        }

        for (char secondChars : secondList) {
            if (!charList.contains(secondChars)){
                result.add(secondChars);
            }
        }

        for (Character character : result) {
            System.out.print(character + " ");
        }
    }
}
