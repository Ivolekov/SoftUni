import java.util.*;
import java.util.logging.Filter;

public class Weightlifting {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        long n = Long.parseLong(scan.nextLine());


        Map<String, TreeMap<String, Long>> players = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" ");
            String name = input[0];
            String exersice = input[1];
            Long weight = Long.parseLong(input[2]);

            if (!players.containsKey(name)) {
                players.put(name, new TreeMap<>());
                players.get(name).put(exersice, weight);
            } else {
                if (!players.get(name).containsKey(exersice)) {
                    players.get(name).put(exersice, weight);
                } else {
                    long oldWeight = players.get(name).get(exersice);
                    players.get(name).put(exersice, weight + oldWeight);
                }
            }
        }

        for (String s : players.keySet()) {
            List<String> exercices = new ArrayList<>();
            System.out.print(s + " : ");
            for (String s1 : players.get(s).keySet()) {
                exercices.add(String.format("%s - %d kg", s1, players.get(s).get(s1)));
            }
            System.out.println(exercices.toString().substring(1, exercices.toString().length() - 1));
        }
    }
}
