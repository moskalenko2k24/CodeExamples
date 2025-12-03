import java.util.Scanner;

public class InputExample {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Input two numbers: ");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        System.out.printf("Sum of numbers: %d", a + b);
    }
}