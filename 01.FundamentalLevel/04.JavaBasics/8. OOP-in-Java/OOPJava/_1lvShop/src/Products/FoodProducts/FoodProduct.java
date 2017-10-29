package Products.FoodProducts;

import Interfaces.AgeRestriction;
import Interfaces.Expirable;
import Products.Product;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class FoodProduct extends Product implements Expirable {
    private final int minEcpirationDays = 15;
    private final BigDecimal returnPercentage = new BigDecimal(0.7);
    private LocalDate expirationDate;

    public FoodProduct(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction, LocalDate expirationDate) {
        super(name, price, quantity, ageRestriction);
        this.setExpirationDate(expirationDate);
        this.setPrice(price);
    }

    public FoodProduct(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        this(name, price, quantity, ageRestriction, LocalDate.MAX);
    }

    @Override
    public LocalDate getExpirationDate() {
        return expirationDate;
    }

    public void setExpirationDate(LocalDate expirationDate) {
        this.expirationDate = expirationDate;
    }

    @Override
    public void setPrice(BigDecimal price) {
        if (ChronoUnit.DAYS.between(LocalDate.now(), this.getExpirationDate()) <= minEcpirationDays) {
            super.setPrice(price.divide(returnPercentage));
        }
    }
}
