import Products.FoodProducts.FoodProduct;
import Products.Product;

import java.time.LocalDate;

public class PurchaseManager {
    public static void processPurchase(Customer customer, Product product) {
        if (product.getQuantity() <= 0) {
            throw new IllegalArgumentException("Product is out of stock");
        }
        if (product.getClass().getSimpleName().equals("FoodProduct")) {
            if (((FoodProduct) product).getExpirationDate().compareTo(LocalDate.now()) < 0) {
                throw new IllegalArgumentException("Product has expired");
            }
        }
        if (customer.getBalance().compareTo(product.getPrice()) < 0) {
            throw new IllegalArgumentException(customer.getName() + "! " + "You do not have enough money to buy this product!");
        }
        if (customer.getAge() < 18) {
            throw new IllegalArgumentException(customer.getName() + "! " + "You are too young to buy this product!");
        }

        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance().subtract(product.getPrice()));
    }
}
