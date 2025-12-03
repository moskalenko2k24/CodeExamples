// javac Inheritance.java && java Inheritance
public class Inheritance {
    static class A {
        public void print() {
            System.out.println("A");
        }
    }

    static class B extends A {
        public void print() {
            System.out.println("B");
        }
    }

    public static void main(String[] args) {
        A[] obj = new A[2];
        obj[0] = new A();
        obj[1] = new B();
        obj[0].print(); // A
        obj[1].print(); // B
    }
}