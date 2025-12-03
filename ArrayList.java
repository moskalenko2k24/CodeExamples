import java.util.ArrayList;

class Program {
    public static void main(String[] args) {
        // ArrayList<Integer> list = new ArrayList<Integer>();
        var list = new ArrayList<Integer>();
        System.out.println("var list = new ArrayList<Integer>();");
        System.out.println("(same as ArrayList<Integer> list = ...)");

        System.out.println();
        System.out.println(".add(element), O(1) amortized");
        System.out.println("list.add(1); list.add(2); list.add(4)");
        list.add(1);
        list.add(2);
        list.add(4);
        System.out.println(list);

        System.out.println();
        System.out.println(".add(index, element), O(N)");
        System.out.println("list.add(0, 2); list.add(3, 5)");
        list.add(0, 2);
        list.add(3, 5);
        System.out.println(list);

        System.out.println();
        System.out.println(".set(index, element), O(1)");
        list.set(0, 0);
        list.set(3, 3);
        System.out.println("list.set(0, 0); list.set(3, 3)");
        System.out.println(list);

        System.out.println();
        System.out.println(".get(index), O(1)");
        System.out.println("list.get(0) == " + list.get(0));
        System.out.println("list.get(4) == " + list.get(4));

        System.out.println();
        System.out.println(".size(), O(1)");
        System.out.println("list.size() == " + list.size());

        System.out.println();
        System.out.println(".remove(index), O(n))");
        list.remove(0);
        list.remove(0);
        System.out.println("list.remove(0); list.remove(0);");
        System.out.println(list);

        System.out.println("Iterating list, method 1");
        System.out.println("for (int i = 0; i < list.size(); i++)\n  list.get(i)");
        for (int i = 0; i < list.size(); i++)
            System.out.print(list.get(i) + " ");
        System.out.println();

        System.out.println();
        System.out.println("Iterating list, method 2");
        System.out.println("for (Integer element : list)");
        for (Integer element : list)
            System.out.print(element + " ");
        System.out.println();

        System.out.println();
    }
}
