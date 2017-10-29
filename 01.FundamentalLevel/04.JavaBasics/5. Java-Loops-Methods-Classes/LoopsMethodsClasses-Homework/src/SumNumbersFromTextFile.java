import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromTextFile {
    public static void main(String[] args) throws IOException {
        try {
            FileReader fileReader = new FileReader("Input.txt");
            BufferedReader buffer = new BufferedReader(fileReader);

            int sum = 0;

            String line = buffer.readLine();

            if (line == null){
                System.out.print("Empty File.\nPlease input some integer numbers in file with name Input.txt");
                return;
            }
            while (line != null) {
                sum += Integer.parseInt(line);
                line = buffer.readLine();
            }

            System.out.print(sum);
            buffer.close();
        } catch (FileNotFoundException ex){
            System.out.print("Error");
        }
    }
}