package Contracts;

public interface IVertex {
    double getX();
    double getY();
    double calculateDistance(IVertex otherVertex);
}
