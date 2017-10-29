package Products.ElectronicProducts;

import Interfaces.AgeRestriction;
import Products.Product;

import java.math.BigDecimal;

public class ElectonicsProduct extends Product {
    private int guaranteePeriod;

    public ElectonicsProduct(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction, int guaranteePeriod) {
        super(name, price, quantity, ageRestriction);

        this.guaranteePeriod = guaranteePeriod;
    }
}
