import java.util.Scanner;
import static java.lang.System.out;

//import java.io.Console;

public class SumTwoNumbers {

	public static void main(String[] args) {

		EnterNumbersWithScanner();

	}
	
	public static int SumTwoNumers(int firstNumberToSum, int secondNumberToSum) {
		
		int sum = firstNumberToSum + secondNumberToSum;
		
		return sum;
	}
	
	public static void EnterNumbersWithScanner() {
		
		Scanner in = new Scanner(System.in);
		
		out.print("Enter first number to sum:");
		int firstNumberToSumParsed = in.nextInt();
		out.println();
		
		out.print("Entere second number to sum: ");
		int secondNumberToSumParsed = in.nextInt();
		out.println();
		
		out.print("The sum of the two numbers is: "  +SumTwoNumers(firstNumberToSumParsed, secondNumberToSumParsed));
		
		in.close();
	}
	
//	public static void EnterNumbersWithScanner() {
//		Console console = System.console();
//		
//		int firstNumberToSumParsed = Integer.parseInt(console.readLine("Enter first number to sum: "));
//		int secondNumberToSumParsed = Integer.parseInt(console.readLine("Entere second number to sum: "));
//		
//		out.print("The sum of the two numbers is: "  +SumTwoNumers(firstNumberToSumParsed, secondNumberToSumParsed));
//	}
}
