import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LabyrinthDash {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());

        char[][] map = new char[n][];

        int lives = 3;
        int row = 0;
        int col = 0;
        int moves = 0;

        for (int i = 0; i < n; i++) {
            String line = scan.nextLine();
            map[i] = line.toCharArray();
        }

        String commands = scan.nextLine();

        for (char command : commands.toCharArray()) {

            int previosRow = row;
            int previosCol = col;

            switch (command) {
                case '>':
                    col++;
                    break;
                case '<':
                    col--;
                    break;
                case 'v':
                    row++;
                    break;
                case '^':
                    row--;
                    break;
            }

            if (col < 0 || row >= map.length || col >= map[row].length || map[row][col] == ' ') {
                moves++;
                System.out.println("Fell off a cliff! Game Over!");
                break;
            }
            if (map[row][col] == '_' || map[row][col] == '|') {
                row = previosRow;
                col = previosCol;
                System.out.println("Bumped a wall.");
            } else if (map[row][col] == '@' || map[row][col] == '#' || map[row][col] == '*') {
                moves++;
                lives--;
                System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                if (lives <= 0) {
                    System.out.println("No lives left! Game Over!");
                    break;
                }

            } else if (map[row][col] == '$') {
                lives++;
                moves++;
                map[row][col] = '.';
                System.out.printf("Awesome! Lives left: %d\n", lives);
            } else if (map[row][col] == '.') {
                moves++;
                System.out.println("Made a move!");
            }

        }

        System.out.printf("Total moves made: %d\n", moves);

    }
}
