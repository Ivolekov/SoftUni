import Interfaces.AgeRestriction;
import Products.FoodProducts.FoodProduct;

import java.math.BigDecimal;

public class MainClass {
    public static void main(String[] args) {
        FoodProduct cigars = new FoodProduct("420 Blaze it fgt", new BigDecimal(6.90), 1400, AgeRestriction.Adult);
        try {
            Customer pecata = new Customer("Pecata", 17, new BigDecimal(30.00));
            PurchaseManager.processPurchase(pecata, cigars);
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }
        try {
            Customer gopeto = new Customer("Gopeto", 18, new BigDecimal(0.44));
            PurchaseManager.processPurchase(gopeto, cigars);
        }catch (Exception ex){
            System.out.print(ex.getMessage());
        }

    }
}
