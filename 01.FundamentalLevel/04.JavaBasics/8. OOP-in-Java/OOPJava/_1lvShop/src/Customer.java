import java.math.BigDecimal;

public class Customer {
    private String name;
    private int age;
    private BigDecimal balance;

    public Customer(String name, int age, BigDecimal balance) {
        this.name = name;
        this.age = age;
        this.balance = balance;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name.equals(null)) {
            throw new IllegalArgumentException("The name can not be empty");
        }
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if (age < 0) {
            throw new IllegalArgumentException("the age can not be negative");
        }
        this.age = age;
    }

    public BigDecimal getBalance() {
        return balance;
    }

    public void setBalance(BigDecimal balance) {
        if (balance.compareTo(BigDecimal.ZERO) < 0){
            throw  new IllegalArgumentException("The balance can not be negative");
        }
            this.balance = balance;
    }
}
