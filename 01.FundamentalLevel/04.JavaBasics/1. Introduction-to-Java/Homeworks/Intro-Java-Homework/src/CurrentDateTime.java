import static java.lang.System.out;
import java.time.LocalDateTime;

public class CurrentDateTime {

	public static void main(String[] args) {
		
		LocalDateTime currentDateTime = LocalDateTime.now();
		
		out.println(currentDateTime);

	}

}
