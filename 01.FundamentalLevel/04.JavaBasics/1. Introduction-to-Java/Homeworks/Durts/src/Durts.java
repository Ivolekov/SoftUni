import java.util.Scanner;

public class Durts {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Integer cX = scan.nextInt();
        Integer cY = scan.nextInt();
        Integer radius = scan.nextInt();
        Integer count = scan.nextInt();

        double verticalMinX = cX - (0.5 * radius);
        double verticalMaxX = cX + (0.5 * radius);
        double verticalMinY = cY - radius;
        double verticalMaxY = cY + radius;

        double horizontalMinY = cY - (0.5 * radius);
        double horizontalMaxY = cY + (0.5 * radius);
        double horizontalMinX = cX - radius;
        double horizontalMaxX = cX + radius;

        for (int i = 0; i < count; i++) {

            int x = scan.nextInt();
            int y = scan.nextInt();

            boolean isInVerticalFigure = x >= verticalMinX && y >= verticalMinY && x <= verticalMaxX && y <= verticalMaxY;
            boolean isInHorizontalFigure = x >= horizontalMinX && y >= horizontalMinY && x <= horizontalMaxX && y <= horizontalMaxY;

            if (isInVerticalFigure || isInHorizontalFigure) {
                System.out.println("yes");
            } else {
                System.out.println("no");
            }
        }
    }
}
