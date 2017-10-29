import java.util.*;

public class DragonSharp {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());


        for (int i = 0; i < n; i++) {
            String[] input = scan.nextLine().toString().split(" ");
            if (input[0].equals("if")){
                String bool = input[1].replace("(","").replace(")","");
                boolean a = Boolean.parseBoolean(bool);
                if (a == true){
                    if (input[4].equals("out")) {
                        Integer loops = Integer.parseInt(input[3]);
                        for (int j = 0; j < loops; j++) {
                            System.out.println(input[5].replace("\"","") + " " + input[6] + " " + input[7].replace("\";",""));
                        }
                }
            }
            if (input[0].equals("else")) {
                Integer loops = Integer.parseInt(input[2]);
                for (int j = 0; j < loops; j++) {
                    System.out.println(input[4].replace("\"","") + " " + input[5].replace("\";",""));

                }
            }


            }

        }
    }
}
