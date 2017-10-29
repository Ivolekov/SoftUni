package Products.ElectronicProducts;

import Interfaces.AgeRestriction;
import Interfaces.GuaranteePeriod;

import java.math.BigDecimal;

public class Appliance extends ElectonicsProduct{
    private final int totalQuantity = 50;
    private final BigDecimal returnPercentage = new BigDecimal(1.05);

    public Appliance(String name, BigDecimal price, int quantity) {
        super(name, price, quantity, AgeRestriction.None, GuaranteePeriod.Appliance.getValue());
        this.setPrice(price);
    }

    @Override
    public void setPrice(BigDecimal price){
        if (this.getQuantity() >= totalQuantity){
            super.setPrice(price.divide(returnPercentage));
        }
    }
}
