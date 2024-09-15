/*
https://atcoder.jp/contests/abc272/tasks/abc272_a
*/
import java.util.Scanner;

public class Abc272a {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        int total = 0;
        for (int i = 0; i < n; i++) {
            String num = sc.next();
            total += Integer.parseInt(num);
        }

        System.out.println(total);
    }
}