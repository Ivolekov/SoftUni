import java.io.*;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;

public class ListOfProducts {
    public static void main(String[] args) throws IOException {
        try {
            FileReader inputReader = new FileReader("listProducts_input.txt");
            BufferedReader reader = new BufferedReader(inputReader);

            ArrayList<Product> products = new ArrayList<>();
            String line = reader.readLine();

            while (line != null) {
                String[] splitLine = line.split(" ");
                String name = splitLine[0];
                BigDecimal price = new BigDecimal(splitLine[1]);

                Product currentProduct = new Product(price, name);
                products.add(currentProduct);

                line = reader.readLine();
            }

            Collections.sort(products);

            File outputWriter = new File("listProducts_output.txt");
            PrintStream writer = new PrintStream(outputWriter);

            for (Product product : products) {
                writer.println(product.getPrice() + " " + product.getName());
            }


        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }
    }

    private static class Product implements Comparable{
        private String name;
        private BigDecimal price;

        public Product(BigDecimal price, String name) {
            this.setName(name);
            this.setPrice(price);
        }
        public String getName(){
            return name;
        }
        public void setName(String name){
            this.name = name;
        }
        public BigDecimal getPrice(){
            return price;
        }
        public void setPrice(BigDecimal price){
            this.price = price;
        }

        @Override
        public int compareTo(Object o) {
            Product otherProduct = (Product) o;
            return this.price.compareTo(otherProduct.price);
        }
    }
}