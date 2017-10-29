import java.util.Scanner;

public class SortArraysOfStrings {

	public static void main(String[] args) {
		
		Scanner in = new Scanner(System.in);
		
		int numberOfStringsToBeEntered = in.nextInt();
		
		SortStrings(numberOfStringsToBeEntered);
		
		in.close();
	}
	
	public static void SortStrings(int numberOfStringsToBeEntered)
	{
		String[] stringsToBeSorted = new String[numberOfStringsToBeEntered];
		Scanner in = new Scanner(System.in);
		
		for(int i = 0; i < numberOfStringsToBeEntered; i++)
		{
			String enterWord = in.nextLine();
			
			stringsToBeSorted[i] = enterWord; 
		}
		
	    for (int i = 0; i < stringsToBeSorted.length - 1; i++)
	    {
	        int index = i;
	        for (int j = i + 1; j < stringsToBeSorted.length; j++)
	            if (stringsToBeSorted[j].compareTo(stringsToBeSorted[index]) < 0)
	                index = j;
	  
	        String smallerString = stringsToBeSorted[index]; 
	        stringsToBeSorted[index] = stringsToBeSorted[i];
	        stringsToBeSorted[i] = smallerString;
	    }
		
		in.close();
		
//		Arrays.sort(stringsToBeSorted);
		
		PrintSortedStrings(stringsToBeSorted);
	}
	
	public static void PrintSortedStrings(String[] stringsToBeSorted)
	{
		for(String stringsSorted : stringsToBeSorted)
		{
			System.out.println(stringsSorted);
		}
	}
}
