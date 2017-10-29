import java.util.*;

public class OfficeStuf {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        TreeMap<String, LinkedHashMap<String, Integer>> stufs = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" - ");

            String company = input[0].substring(1, input[0].length());
            Integer amount = Integer.parseInt(input[1]);
            String product = input[2].substring(0, input[2].length() - 1);

            if (!stufs.containsKey(company)) {
                stufs.put(company, new LinkedHashMap<>());
                stufs.get(company).put(product, amount);
            } else {
                if (!stufs.get(company).containsKey(product)) {
                    stufs.get(company).put(product, amount);
                } else {
                    int oldAmount = stufs.get(company).get(product);
                    stufs.get(company).put(product, (amount + oldAmount));
                }

            }
        }

        for (String companyName : stufs.keySet()) {
            List<String> officeStuf = new ArrayList<>();
            System.out.print(companyName + ": ");
            for (String product : stufs.get(companyName).keySet()) {
                officeStuf.add(product + "-" + stufs.get(companyName).get(product));
            }
            System.out.println(officeStuf.toString().substring(1, officeStuf.toString().length() - 1));
        }

    }
}
