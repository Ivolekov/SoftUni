import java.util.*;

public class DragonArmy {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        LinkedHashMap<String, TreeMap<String, LinkedList<String>>> dragons = new LinkedHashMap<>();

        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" ");
            String type = input[0];
            String name = input[1];
            String damage = input[2];
            if (input[2].equals("null")) {
                damage = "45";
            }
            String health = input[3];
            if (input[3].equals("null")) {
                health = "250";
            }
            String armor = input[4];
            if (input[4].equals("null")) {
                armor = "10";
            }


            TreeMap<String, LinkedList<String>> dragonsName = new TreeMap<>();
            if (dragons.containsKey(type)) {
                dragonsName = dragons.get(type);
                if (!dragonsName.containsKey(name)) {
                    dragonsName.put(name, new LinkedList<>());

                    dragonsName.get(name).add(damage);
                    dragonsName.get(name).add(health);
                    dragonsName.get(name).add(armor);
                } else {
                    if (dragonsName.containsKey(name)) {
                        dragonsName.put(name, new LinkedList<>());
                        dragonsName.get(name).add(damage);
                        dragonsName.get(name).add(health);
                        dragonsName.get(name).add(armor);
                    }

                }
            } else {
                LinkedList<String> stats = new LinkedList<>();
                stats.add(damage);
                stats.add(health);
                stats.add(armor);
                dragonsName.put(name, stats);
                dragons.put(type, dragonsName);
            }
        }
        for (Map.Entry<String, TreeMap<String, LinkedList<String>>> dragon : dragons.entrySet()) {
            String dragonType = dragon.getKey();
            TreeMap<String, LinkedList<String>> dragonsNames = dragon.getValue();
            Double averageDamage = 0.0;
            Double averageHelth = 0.0;
            Double averageArmor = 0.0;
            for (LinkedList<String> status : dragonsNames.values()) {
                averageDamage += Double.parseDouble(status.get(0));
                averageHelth += Double.parseDouble(status.get(1));
                averageArmor += Double.parseDouble(status.get(2));
            }
            String type = String.format("%s::(%.2f/%.2f/%.2f)", dragonType,
                    averageDamage / dragonsNames.size(),
                    averageHelth / dragonsNames.size(), averageArmor / dragonsNames.size());
            System.out.println(type);

            for (Map.Entry<String, LinkedList<String>> dragonName : dragonsNames.entrySet()) {
                String name = dragonName.getKey();
                String[] stats = dragonName.getValue().toString().split(" ");

                System.out.printf("-%s -> damage: %s health: %s armor: %s\n", name, stats[0].replace("[", ""),
                        stats[1], stats[2].replace("]", ""));
            }
        }

    }
}
