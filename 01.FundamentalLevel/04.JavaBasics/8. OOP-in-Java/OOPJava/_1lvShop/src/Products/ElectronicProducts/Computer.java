package Products.ElectronicProducts;

import Interfaces.AgeRestriction;
import Interfaces.GuaranteePeriod;

import java.math.BigDecimal;

public class Computer extends ElectonicsProduct {
    private final int totalQuantity = 1000;
    private final BigDecimal returnPercentage = new BigDecimal(0.95);

    public Computer(String name, BigDecimal price, int quantity) {
        super(name, price, quantity, AgeRestriction.None, GuaranteePeriod.Computer.getValue());
        this.setPrice(price);
    }

    @Override
    public void setPrice(BigDecimal price){
        if (this.getQuantity() >= totalQuantity){
            super.setPrice(price.divide(returnPercentage));
        }
    }
}
