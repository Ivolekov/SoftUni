import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class CurrentDateTime {
    public static void main(String[] args) {

        Date date = new Date();
        System.out.println(date);

//      Custom format:
        DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
        System.out.println(dateFormat.format(date));
    }
}
