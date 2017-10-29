package Interfaces;

public enum GuaranteePeriod {
    Computer(24),
    Appliance(6);

    private int value;

    GuaranteePeriod(int value) {
        this.value = value;
    }
    public int getValue(){
        return value;
    }
}
