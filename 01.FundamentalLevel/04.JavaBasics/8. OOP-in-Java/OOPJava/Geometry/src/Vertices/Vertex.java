package Vertices;

import Contracts.IVertex;

public class Vertex implements IVertex {
    private double x;
    private double y;

    public Vertex(double y, double x) {
        this.setY(y);
        this.setX(x);
    }

    public double getX() {
        return this.x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return this.y;
    }

    public void setY(double y) {
        this.y = y;
    }

    @Override
    public double calculateDistance(IVertex otherVertex) {
        double otherX = otherVertex.getX();
        double otherY = otherVertex.getY();
        double distance = Math.sqrt(Math.pow(this.x - otherX,2) + Math.pow(this.y - otherY,2));
        return distance;
    }
}
