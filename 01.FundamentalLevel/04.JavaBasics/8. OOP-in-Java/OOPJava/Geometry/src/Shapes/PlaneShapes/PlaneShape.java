package Shapes.PlaneShapes;

import Contracts.AreaMeasurable;
import Contracts.PerimeterMeasurable;
import Shapes.Shape;
import Vertices.Vertex;

import java.util.ArrayList;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable, Comparable<PlaneShape> {
    private Vertex vertex;
    private ArrayList<Vertex> vertices;

    public PlaneShape(Vertex vertex) {
        this.setVertex(vertex);
        this.vertices = new ArrayList<Vertex>() {{
            add(vertex);
        }};
    }

    public Vertex getVertex() {
        return this.vertex;
    }

    public void setVertex(Vertex vertex) {
        this.vertex = vertex;
    }

    public ArrayList<Vertex> getVertices() {
        return this.vertices;
    }

    @Override
    public int compareTo(PlaneShape other) {
        if (this.getPerimeter() > other.getPerimeter()) {
            return 1;
        } else if (other.getPerimeter() > this.getPerimeter()) {
            return -1;
        }

        return 0;
    }

}
