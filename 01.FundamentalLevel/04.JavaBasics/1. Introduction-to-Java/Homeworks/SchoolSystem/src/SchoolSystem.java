import java.util.*;

public class SchoolSystem {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());

        TreeMap<String, TreeMap<String, ArrayList<Double>>> students = new TreeMap<String, TreeMap<String, ArrayList<Double>>>();
        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().split(" ");
            String fullName = input[0] + " " + input[1];
            String subject = input[2];
            double mark = Double.parseDouble(input[3]);

            TreeMap<String, ArrayList<Double>> subjects = new TreeMap<>();
            if (students.containsKey(fullName)) {
                subjects = students.get(fullName);
                if (!subjects.containsKey(subject)) {
                    subjects.put(subject, new ArrayList<>());
                }
                subjects.get(subject).add(mark);
            } else {
                ArrayList<Double> marks = new ArrayList<>();
                marks.add(mark);
                subjects.put(subject, marks);
                students.put(fullName, subjects);
            }

        }
        for (Map.Entry<String, TreeMap<String, ArrayList<Double>>> student : students.entrySet()) {
            String studentName = student.getKey();
            TreeMap<String, ArrayList<Double>> subjects = student.getValue();
            String output = studentName + ": [";
            ArrayList<Double> avvMarks = new ArrayList<>();
            for (Map.Entry<String, ArrayList<Double>> subject : subjects.entrySet()) {
                String subjectName = subject.getKey();
                Object[] marks = subject.getValue().toArray();
                output += subjectName + " - " + String.format("%.2f", averageOf(marks)) + ", ";
                avvMarks.add(averageOf(marks));
            }
            output = output.substring(0, output.length()-2) + "]";
            System.out.print(output + "\n");
        }
    }

    public static double averageOf(Object[] arr) {
        double sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum += (double) arr[i];
        }
        double average = sum / arr.length;

        return average;
    }
}
