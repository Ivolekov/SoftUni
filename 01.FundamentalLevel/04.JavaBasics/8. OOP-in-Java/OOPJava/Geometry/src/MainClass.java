import Shapes.PlaneShapes.Circle;
import Shapes.PlaneShapes.PlaneShape;
import Shapes.PlaneShapes.Rectangle;
import Shapes.PlaneShapes.Triangle;
import Shapes.Shape;
import Vertices.Vertex;
import com.sun.javaws.exceptions.InvalidArgumentException;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class MainClass {
    public static void main(String[] args) throws InvalidArgumentException {

        Vertex pointA = new Vertex(15, 15);
        Vertex pointB = new Vertex(23, 30);
        Vertex pointC = new Vertex(55, 25);
        Triangle triangle = new Triangle(pointA, pointB, pointC);

        Vertex rectangleVertex = new Vertex(20, 20);
        Rectangle rectangle = new Rectangle(rectangleVertex, 15, 20);

        Vertex circleCenter = new Vertex(30, 30);
        Circle circle = new Circle(circleCenter, 15);

        PlaneShape[] planeShapes = new PlaneShape[]{triangle, rectangle, circle};

        ArrayList<Shape> shapes = new ArrayList<Shape>() {
            {
                addAll(Arrays.asList(planeShapes));
            }
        };

        shapes.forEach(System.out::println);

        List<PlaneShape> sortedPlaneShapes = shapes.stream()
                .filter(s -> s instanceof PlaneShape)
                .map(s -> (PlaneShape) s)
                .sorted()
                .collect(Collectors.toList());


        System.out.println();
        System.out.println("Sorted Plane Shapes");
        for (PlaneShape sortedPlaneShape : sortedPlaneShapes) {
            System.out.println(sortedPlaneShape.toString().trim());
        }
    }
}
