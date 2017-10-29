import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Site A = ");
        int siteA = input.nextInt();
        System.out.print("Site B = ");
        int siteB  = input.nextInt();
        int rectangleArea = siteA * siteB;
        System.out.println("Rectangle area is: " + rectangleArea);

    }
}
