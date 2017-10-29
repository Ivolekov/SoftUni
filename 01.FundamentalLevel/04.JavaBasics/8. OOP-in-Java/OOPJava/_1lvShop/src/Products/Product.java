package Products;

import Interfaces.AgeRestriction;
import Interfaces.Buyable;

import java.math.BigDecimal;

public abstract class Product implements Buyable {

    private String name;
    private BigDecimal price;
    private int quantity;
    private AgeRestriction ageRestriction;

    public Product(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.ageRestriction = ageRestriction;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name.equals(null)) {
            throw new IllegalArgumentException("The name of the product can not be empty");
        }
        this.name = name;
    }

    public BigDecimal getPrice() {
        return price;
    }

    public void setPrice(BigDecimal price) {
        if (price.compareTo(BigDecimal.ZERO) < 0) {
            throw new IllegalArgumentException("The price of the product can not be negative");
        }
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        if (quantity < 0) {
            throw new IllegalArgumentException("The quantity of the products can not be negative");
        }
        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }
}
