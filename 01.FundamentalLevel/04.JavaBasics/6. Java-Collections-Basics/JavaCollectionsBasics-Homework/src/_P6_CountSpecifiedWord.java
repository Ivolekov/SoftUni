import java.util.Scanner;

public class _P6_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split("[^\\w]+");
        String wordToFind = scanner.nextLine().trim();
        int wordCount = 0;

        for (int i = 0; i < input.length; i++) {
            String s = input[i];
            if (wordToFind.toLowerCase().equals(s.toLowerCase())){
                wordCount++;
            }
        }
        System.out.print(wordCount);
    }
}
