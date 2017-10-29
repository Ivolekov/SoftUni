import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class DaysBetweenTwoDates {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");

        String startDate = scanner.nextLine();
        if (startDate.length() == 9) {
            startDate = "0" + startDate;
        }
        String endDate = scanner.nextLine();
        if (endDate.length() == 9) {
            endDate = "0" + endDate;
        }

        LocalDate start = LocalDate.parse(startDate, formatter);
        LocalDate end = LocalDate.parse(endDate,formatter);
        long daysBetween = ChronoUnit.DAYS.between(start, end);
        System.out.print(daysBetween);

    }
}