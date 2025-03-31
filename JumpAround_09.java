package ArrayTasks;

import java.util.Arrays;
import java.util.Scanner;

public class JumpAround_09 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
       int[] numbers = Arrays.stream(scanner.nextLine().split((" ")))
               .mapToInt(Integer::valueOf).toArray();

       int index = 0;
       long sum = 0;
        while (true) {
            int  tempIndex = index;
            sum += numbers[index];
            index += numbers[index];

            if (index > numbers.length - 1) {
                index = tempIndex - numbers[tempIndex];

                if (index < 0) {
                    break;
                }
            }
        }
        System.out.println(sum);

    }
}